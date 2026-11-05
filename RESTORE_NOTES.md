# Restore Notes — O2 Gym Membership System

## Project summary & stack

A university database-course project: a Windows desktop app for managing a gym
(members, trainers, rooms, classes, plans, payments, enrollments) backed by MySQL.

- **UI / app layer:** C# WinForms, .NET Framework 4.7.2 (`GymMembershipSystem.csproj`, `GymMembershipSystem.sln`)
- **Data access:** `MySql.Data` (MySQL Connector/NET) 9.7.0, via NuGet (`packages/`)
- **Database:** MySQL 8.0, schema + seed data + stored procedures/functions in `GymMembershipSystem.sql`
- **Build tool:** MSBuild (via Visual Studio 2022 Community)

## Install, build, run (fresh machine)

1. Install **Visual Studio 2022** (Community is fine) with the ".NET desktop development" workload, or just the Build Tools + .NET Framework 4.7.2 targeting pack.
2. Install **MySQL Server 8.0** and note the root password.
3. Create the database:
   ```
   mysql -uroot -p < GymMembershipSystem.sql
   ```
4. Open `GymMembershipSystem/App.config` and set the `GymDb` connection string's `Pwd=` to your MySQL root password (or create a less-privileged user and use that).
5. Build:
   ```
   MSBuild GymMembershipSystem.sln -t:Rebuild -p:Configuration=Debug
   ```
6. Run `GymMembershipSystem/bin/Debug/GymMembershipSystem.exe`.

## Bugs fixed

| File | Problem | Fix |
|---|---|---|
| `GymMembershipSystem.sql` | Two stray stray characters (`\` after the MEMBER inserts, `=` before the ROOM inserts) broke the script when run straight through `mysql` | Removed the stray tokens |
| `DataAccess/DatabaseHelper.cs` | Hardcoded connection string (and password) baked into source; `ExecuteSelect`/`ExecuteAction` had no way to pass parameters | Connection string now read from `App.config` (`connectionStrings/GymDb`), with the old value kept as a fallback; both methods now accept an optional `MySqlParameter[]` |
| `Forms/Form1.cs`, `TrainerForm.cs`, `RoomForm.cs`, `ClassForm.cs`, `PaymentForm.cs`, `PlanFrom2.cs`, `EnrollmentForm.cs` | **SQL injection**: every Add/Update/Delete built its query via string interpolation of raw textbox input (e.g. `$"...VALUES ('{fName}', ...)"`). A name containing a quote (`O'Brien`) would also have broken the query outright. | Rewrote every Add/Update/Delete query to use parameterized `MySqlParameter`s instead of string interpolation |
| `Forms/MainMenu.cs`, `Form1.cs`, `RoomForm.cs`, `ClassForm.cs` | Stray/misindented extra closing braces at file end (cosmetic, harmless to the compiler but confusing) | Cleaned up brace structure |
| `Forms/Form1.cs` | Duplicate `using GymMembershipSystem.DataAccess;` (compiler warning) | Removed the duplicate |
| `Forms/ReportsForm.cs` | Unused `using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;` | Removed |
| `Forms/MainMenu.Designer.cs` and 7 other `*.Designer.cs` files | Window titles were the WinForms defaults (`"Form1"`, `"Form2"`, class names) instead of anything meaningful | Set descriptive titles ("Manage Members", "Manage Trainers", etc.) |

## Dependency / SDK changes

None required — the project already targeted .NET Framework 4.7.2 with NuGet packages
already restored under `packages/`, and Visual Studio 2022's MSBuild built it without
any upgrade. No SDK changes were made.

## UI improvements

- Added `UiTheme.cs`, a small static helper applied from every form's constructor
  (`UiTheme.Apply(this)`). It recursively sets:
  - A consistent light background and font (Segoe UI) across all forms.
  - Flat, teal-accented buttons (`FlatStyle.Flat`, consistent back/fore color, hand cursor) instead of mismatched default Windows buttons.
  - Consistent `DataGridView` styling: white background, colored header row, alternating row shading, no 3D border.
- Gave every window a real, descriptive title bar instead of the WinForms-default "Form1"/"Form2".

This is a code-only theme layer — no existing screens, controls, or flows were removed;
everything still uses WinForms, matching the original technology choice.

## Known limitations / what you still need to provide

- **`App.config` is gitignored** because it holds your real local MySQL password. A
  template lives at `GymMembershipSystem/App.config.example` — copy it to `App.config`
  and set `Pwd=` to your MySQL root (or app-specific) password. The one currently on
  disk already has your password filled in from this session, so the app runs as-is;
  it just won't be committed to git.
- No automated tests exist for this project. Given the app is thin UI-over-SQL with no
  business logic outside of the stored procedures/functions in `GymMembershipSystem.sql`,
  the most valuable "test" is exercising each form's Load/Add/Update/Delete buttons by
  hand (see below) — which was done as part of this restoration.
- Client-side input validation (e.g. required fields, numeric-only IDs) is minimal;
  invalid input is caught by MySQL constraints and reported via a message box rather
  than validated before the query runs. This matches the original design and was left
  as-is since it didn't cause crashes, just one extra round trip to the DB on bad input.

## How to test it

The app is currently running. From the main menu ("O2 Gym Membership System"):

1. **Members** → Load Members, try Add (fill in name/email/phone/DOB/join date), click
   a grid row then Update or Delete.
2. **Trainers / Rooms / Classes / Plans / Payments / Enrollments** → same Load/Add/
   Update/Delete pattern; reference grids (e.g. double-click a member/class row) auto-fill
   the ID fields.
3. **Reports** → "Member Payment History" and "Revenue by Plan" buttons pull from the
   stored procedure / aggregate query respectively.

Try a name with an apostrophe (e.g. `O'Brien`) in Add Member — it now saves correctly
instead of breaking the query, confirming the SQL-injection fix.
