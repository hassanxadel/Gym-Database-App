using System.Drawing;
using System.Windows.Forms;

namespace GymMembershipSystem
{
    // Applies one consistent look (colors/fonts) across every form.
    // Call Apply(this) at the end of each form's constructor.
    internal static class UiTheme
    {
        public static readonly Color Background = Color.FromArgb(245, 247, 250);
        public static readonly Color Accent = Color.FromArgb(0, 121, 107);
        public static readonly Color AccentText = Color.White;
        private static readonly Font BodyFont = new Font("Segoe UI", 9.5F);

        public static void Apply(Form form)
        {
            form.BackColor = Background;
            form.Font = BodyFont;
            StyleControls(form.Controls);
        }

        private static void StyleControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case Button button:
                        button.FlatStyle = FlatStyle.Flat;
                        button.BackColor = Accent;
                        button.ForeColor = AccentText;
                        button.Cursor = Cursors.Hand;
                        button.FlatAppearance.BorderSize = 0;
                        break;
                    case DataGridView grid:
                        grid.BackgroundColor = Color.White;
                        grid.BorderStyle = BorderStyle.None;
                        grid.ColumnHeadersDefaultCellStyle.BackColor = Accent;
                        grid.ColumnHeadersDefaultCellStyle.ForeColor = AccentText;
                        grid.ColumnHeadersDefaultCellStyle.Font = new Font(BodyFont, FontStyle.Bold);
                        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 241, 240);
                        grid.EnableHeadersVisualStyles = false;
                        break;
                }

                if (control.HasChildren)
                {
                    StyleControls(control.Controls);
                }
            }
        }
    }
}
