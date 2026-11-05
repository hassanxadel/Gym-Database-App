-- hena bne3mel el database lw mawgooda abl keda
DROP DATABASE IF EXISTS GymMembershipSystem;
CREATE DATABASE GymMembershipSystem
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;
USE GymMembershipSystem;  -- bno2af fel database dih 3ashan el queries el gaiya tetkalem ma3aha

-- MEMBER TABLE

CREATE TABLE MEMBER (
    MemberID INT NOT NULL AUTO_INCREMENT,         
    FName VARCHAR(50) NOT NULL,                    
    LName VARCHAR(50) NOT NULL,                  
    Email VARCHAR(100) NOT NULL,                   
    Phone VARCHAR(20) NOT NULL,                   
    DateOfBirth DATE NOT NULL,                     
    JoinDate DATE NOT NULL DEFAULT (CURRENT_DATE), --  default: el youm
    CONSTRAINT PK_Member PRIMARY KEY (MemberID),                  -- el MemberID howa el primary key
    CONSTRAINT UQ_Member_Email UNIQUE (Email),                    -- mynf3sh etnen 3andhom nafs el email
    CONSTRAINT CHK_Member_DOB CHECK (DateOfBirth < JoinDate)      -- lazem el milad abl ta2re5 join
);

-- TRAINER TABLE

CREATE TABLE TRAINER (
    TrainerID INT NOT NULL AUTO_INCREMENT,          
    FName VARCHAR(50) NOT NULL,                     
    LName VARCHAR(50) NOT NULL,                   
    Email VARCHAR(100) NOT NULL,                    
    Phone VARCHAR(20) NOT NULL,                     
    Level ENUM('Junior','Mid-Level','Senior','Pro') 
                NOT NULL DEFAULT 'Junior',           -- lw msh mahddash el level, yb2a Junior

    CONSTRAINT PK_Trainer PRIMARY KEY (TrainerID),   -- el primary key
    CONSTRAINT UQ_Trainer_Email UNIQUE (Email)        
);

-- ROOM TABLE

CREATE TABLE ROOM (
    RoomID INT NOT NULL AUTO_INCREMENT,              
    RoomName VARCHAR(100) NOT NULL,                 
    Activity VARCHAR(100) NOT NULL,                
    Capacity TINYINT UNSIGNED NOT NULL DEFAULT 10,  
    CONSTRAINT PK_Room PRIMARY KEY (RoomID),
    CONSTRAINT UQ_Room_Name UNIQUE (RoomName),                      
    CONSTRAINT CHK_Room_Capacity CHECK (Capacity BETWEEN 1 AND 50)    -- el 2oda lazem testa3ab min 1 le 50 wa7ed
);

-- PLAN TABLE

CREATE TABLE PLAN (
    PlanID INT NOT NULL AUTO_INCREMENT,              
    PlanName VARCHAR(100) NOT NULL,                
    Description TEXT,                                
    MonthlyFee DECIMAL(10,2) NOT NULL,               
    DurationDays SMALLINT UNSIGNED NOT NULL DEFAULT 30, --  (default: shahar)

    CONSTRAINT PK_Plan PRIMARY KEY (PlanID),
    CONSTRAINT UQ_Plan_Name UNIQUE (PlanName),                        
    CONSTRAINT CHK_Plan_Fee CHECK (MonthlyFee >= 0),             
    CONSTRAINT CHK_Plan_Duration CHECK (DurationDays BETWEEN 1 AND 365) 
);

-- CLASS TABLE

CREATE TABLE CLASS (
    ClassID INT NOT NULL AUTO_INCREMENT,  
    TrainerID INT NOT NULL,                 
    RoomID INT NOT NULL,                    
    ClassName VARCHAR(100) NOT NULL,      
    Description TEXT,                      
    ScheduleDay ENUM(                      
        'Saturday','Sunday','Monday','Tuesday','Wednesday','Thursday','Friday'
    ) NOT NULL,
    StartTime TIME NOT NULL,               
    EndTime TIME NOT NULL,                  

    CONSTRAINT PK_Class PRIMARY KEY (ClassID),
    CONSTRAINT FK_Class_Trainer FOREIGN KEY (TrainerID) REFERENCES TRAINER(TrainerID)
        ON DELETE RESTRICT ON UPDATE CASCADE,  -- maynfsh temse7 trainer 3ando classes
    CONSTRAINT FK_Class_Room FOREIGN KEY (RoomID) REFERENCES ROOM(RoomID)
        ON DELETE RESTRICT ON UPDATE CASCADE,  -- maynf3sh temse7 room feha classes
    CONSTRAINT CHK_Class_Times CHECK (EndTime > StartTime) -- el end lazem ba3d el start 
);

CREATE TABLE PAYMENT (
    PaymentID INT NOT NULL AUTO_INCREMENT,     
    MemberID INT NOT NULL,                     
    PlanID INT NOT NULL,                      
    PaymentDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP, 
    Amount DECIMAL(10,2) NOT NULL,        

    CONSTRAINT PK_Payment PRIMARY KEY (PaymentID),
    CONSTRAINT FK_Payment_Member FOREIGN KEY (MemberID) REFERENCES MEMBER(MemberID)
        ON DELETE CASCADE ON UPDATE CASCADE,   -- lw el member etmese7, el payments bt3to bitmse7 ma3ah
    CONSTRAINT FK_Payment_Plan FOREIGN KEY (PlanID) REFERENCES PLAN(PlanID)
        ON DELETE RESTRICT ON UPDATE CASCADE,  -- ma2darsh temse7 plan 3aleha payments
    CONSTRAINT CHK_Payment_Amount CHECK (Amount > 0) -- el mabla8 lazem akbar men sefr
);

CREATE TABLE ENROLLMENT (
    EnrollmentID INT NOT NULL AUTO_INCREMENT,  
    MemberID INT NOT NULL,                  
    ClassID INT NOT NULL,                 
    EnrollmentDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT PK_Enrollment PRIMARY KEY (EnrollmentID),
    CONSTRAINT FK_Enrollment_Member FOREIGN KEY (MemberID) REFERENCES MEMBER(MemberID)
        ON DELETE CASCADE ON UPDATE CASCADE,   -- lw el 3edo etmese7, tasgeelatoh bitmse7u
    CONSTRAINT FK_Enrollment_Class FOREIGN KEY (ClassID) REFERENCES CLASS(ClassID)
        ON DELETE CASCADE ON UPDATE CASCADE,   -- lw el calss etmese7et, tasgeelatheha bitmse7 ma3aha
    CONSTRAINT UQ_Enrollment_Member_Class UNIQUE (MemberID, ClassID) -- el member ma2darsh yetsgel nafs el class marten
);


INSERT INTO MEMBER (FName, LName, Email, Phone, DateOfBirth, JoinDate) VALUES
('Ahmed', 'Hassan', 'ahmed.hassan@email.com', '01001234567', '1990-05-14', '2023-01-10'),
('Sara', 'Khalil', 'sara.khalil@email.com', '01112345678', '1995-08-22', '2023-02-15'),
('Mohamed', 'Ali', 'mohamed.ali@email.com', '01223456789', '1988-11-03', '2023-03-01'),
('Nour', 'Ibrahim', 'nour.ibrahim@email.com', '01534567890', '2000-01-17', '2023-03-20'),
('Kareem', 'Samir', 'kareem.samir@email.com', '01145678901', '1993-07-09', '2023-04-05'),
('Hana', 'Youssef', 'hana.youssef@email.com', '01556789012', '1997-03-25', '2023-04-18'),
('Omar', 'Farouk', 'omar.farouk@email.com', '01167890123', '1985-12-30', '2023-05-02'),
('Layla', 'Mostafa', 'layla.mostafa@email.com', '01278901234', '1999-06-11', '2023-06-07'),
('Yasser', 'Nabil', 'yasser.nabil@email.com', '01589012345', '1991-09-28', '2023-07-14'),
('Dina', 'Ramadan', 'dina.ramadan@email.com', '01290123456', '1996-04-06', '2023-08-01'),
('Tamer', 'Gaber', 'tamer.gaber@email.com', '01101234567', '1987-02-19', '2023-09-10'),
('Reem', 'Adel', 'reem.adel@email.com', '01001234567', '2001-10-05', '2023-10-22');
\
INSERT INTO TRAINER (FName, LName, Email, Phone, Level) VALUES
('Mahmoud', 'Sayed', 'mahmoud.sayed@o2gym.com', '01001111111', 'Senior'),
('Rania', 'Fathi', 'rania.fathi@o2gym.com', '01002222222', 'Pro'),     
('Sherif', 'Lotfy', 'sherif.lotfy@o2gym.com', '01003333333', 'Mid-Level'),
('Amira', 'Wael', 'amira.wael@o2gym.com', '01004444444', 'Junior'),     
('Hossam', 'Tarek', 'hossam.tarek@o2gym.com', '01005555555', 'Senior'),
('Noha', 'Badr', 'noha.badr@o2gym.com', '01006666666', 'Mid-Level');

=
INSERT INTO ROOM (RoomName, Activity, Capacity) VALUES
('Main Hall', 'General Fitness', 40),   
('Cardio Zone', 'Cardio', 30),          
('Spin Studio', 'Cycling', 20),       
('Yoga Room', 'Yoga & Pilates', 15),    
('Boxing Arena', 'Combat Sports', 25);  


INSERT INTO PLAN (PlanName, Description, MonthlyFee, DurationDays) VALUES
('Basic',     'Access to gym floor and cardio equipment only.',                199.00, 30), 
('Standard',  'All Basic benefits plus group class access.',                   349.00, 30),
('Premium',   'All Standard benefits plus personal trainer sessions.',         599.00, 30), 
('Quarterly', 'Standard plan billed every 3 months at a discount.',           950.00, 90), 
('Annual',    'Full premium access for the full year.',                       3500.00, 365); 


INSERT INTO CLASS (TrainerID, RoomID, ClassName, Description, ScheduleDay, StartTime, EndTime) VALUES
(1, 1, 'Morning Strength',    'Full-body resistance training.',           'Saturday',  '07:00:00', '08:00:00'),
(2, 4, 'Yoga Flow',           'Beginner-friendly vinyasa yoga.',          'Sunday',    '09:00:00', '10:00:00'),
(3, 3, 'Spin Blast',          'High-intensity indoor cycling.',           'Monday',    '18:00:00', '19:00:00'),
(4, 2, 'Cardio Burn',         'Interval-based cardio session.',           'Tuesday',   '06:30:00', '07:30:00'), 
(5, 5, 'Boxing Fundamentals', 'Learn basic punches, footwork & combos.',  'Wednesday', '17:00:00', '18:30:00'),
(6, 4, 'Pilates Core',        'Core strength and flexibility work.',      'Thursday',  '10:00:00', '11:00:00'),
(1, 1, 'Evening Powerlifting','Squat, bench, and deadlift coaching.',     'Friday',    '19:00:00', '20:30:00'),
(2, 2, 'HIIT Cardio',         'High-intensity interval training.',        'Saturday',  '16:00:00', '17:00:00');

INSERT INTO PAYMENT (MemberID, PlanID, PaymentDate, Amount) VALUES
( 1, 1, '2023-01-10 10:00:00',  199.00),  -- Ahmed: Basic
( 2, 2, '2023-02-15 11:30:00',  349.00),  -- Sara: Standard
( 3, 3, '2023-03-01 09:00:00',  599.00),  -- Mohamed: Premium
( 4, 1, '2023-03-20 14:00:00',  199.00),  -- Nour: Basic
( 5, 4, '2023-04-05 15:00:00',  950.00),  -- Kareem: Quarterly
( 6, 2, '2023-04-18 10:30:00',  349.00),  -- Hana: Standard
( 7, 5, '2023-05-02 08:00:00', 3500.00),  -- Omar: Annual 
( 8, 3, '2023-06-07 13:00:00',  599.00),  -- Layla: Premium
( 9, 2, '2023-07-14 11:00:00',  349.00),  -- Yasser: Standard
(10, 1, '2023-08-01 16:00:00',  199.00),  -- Dina: Basic
(11, 3, '2023-09-10 09:30:00',  599.00),  -- Tamer: Premium
(12, 4, '2023-10-22 10:00:00',  950.00),  -- Reem: Quarterly
( 1, 2, '2023-02-10 10:00:00',  349.00),  -- Ahmed upgrade men Basic le Standard
( 3, 2, '2023-04-01 09:00:00',  349.00),  -- Mohamed 3amel payment tania
( 5, 3, '2023-05-05 15:00:00',  599.00);  -- Kareem 3amel upgrade le Premium


INSERT INTO ENROLLMENT (MemberID, ClassID, EnrollmentDate) VALUES
( 1, 1, '2023-01-11 10:00:00'),  -- Ahmed: Morning Strength
( 1, 2, '2023-01-12 10:00:00'),  -- Ahmed tani: Yoga Flow 
( 2, 2, '2023-02-16 11:00:00'),  -- Sara: Yoga Flow
( 3, 3, '2023-03-02 09:30:00'),  -- Mohamed: Spin Blast
( 4, 4, '2023-03-21 07:00:00'),  -- Nour: Cardio Burn 
( 5, 5, '2023-04-06 17:00:00'),  -- Kareem: Boxing Fundamentals
( 6, 6, '2023-04-19 10:00:00'),  -- Hana: Pilates Core
( 7, 7, '2023-05-03 19:00:00'),  -- Omar: Evening Powerlifting
( 8, 8, '2023-06-08 16:00:00'),  -- Layla: HIIT Cardio
( 9, 1, '2023-07-15 07:00:00'),  -- Yasser: Morning Strength
(10, 3, '2023-08-02 18:00:00'),  -- Dina: Spin Blast
(11, 5, '2023-09-11 17:00:00'),  -- Tamer: Boxing Fundamentals
(12, 2, '2023-10-23 09:00:00'),  -- Reem: Yoga Flow
( 2, 8, '2023-02-20 16:00:00');  -- Sara tani: HIIT Cardio 



-- kol el members (byosta5dem fel Members form)
SELECT * FROM MEMBER;

-- kol el trainers mratbebin 7asab el level (el a3la awal)
SELECT TrainerID, FName, LName, Email, Phone, Level
FROM TRAINER
ORDER BY Level DESC, LName;

-- join el classes ma3 esm el trainer w el room (multi-table JOIN)
-- mratba 7asab tartib el ayam w el wa2t
SELECT
    c.ClassID,
    c.ClassName,
    c.Description,
    CONCAT(t.FName, ' ', t.LName) AS Trainer,
    t.Level AS TrainerLevel,
    r.RoomName,
    r.Activity,
    c.ScheduleDay,
    c.StartTime,
    c.EndTime
FROM CLASS c
JOIN TRAINER t ON c.TrainerID = t.TrainerID
JOIN ROOM r ON c.RoomID = r.RoomID
ORDER BY
    FIELD(c.ScheduleDay, 'Saturday','Sunday','Monday','Tuesday','Wednesday','Thursday','Friday'),
    c.StartTime;

-- tariikh el payments lkol member ma3 esm el plan (JOIN)
SELECT
    pay.PaymentID,
    CONCAT(m.FName, ' ', m.LName) AS MemberName,
    p.PlanName,
    pay.PaymentDate,
    pay.Amount
FROM PAYMENT pay
JOIN MEMBER m ON pay.MemberID = m.MemberID
JOIN PLAN p ON pay.PlanID = p.PlanID
ORDER BY pay.PaymentDate DESC;  -- el ahdas awal

-- lista el enrollments ma3 payments el class w el trainer (multi-JOIN)
SELECT
    e.EnrollmentID,
    CONCAT(m.FName, ' ', m.LName) AS MemberName,
    c.ClassName,
    c.ScheduleDay,
    c.StartTime,
    c.EndTime,
    CONCAT(t.FName, ' ', t.LName) AS Trainer,
    e.EnrollmentDate
FROM ENROLLMENT e
JOIN MEMBER m ON e.MemberID = m.MemberID
JOIN CLASS c ON e.ClassID = c.ClassID
JOIN TRAINER t ON c.TrainerID = t.TrainerID
ORDER BY e.EnrollmentDate DESC;

-- taqreer el eradat 7asab kol plan (betosta5dm fel ReportsForm)
SELECT
    p.PlanName AS 'Membership Plan',
    COUNT(pay.PaymentID) AS 'Total Subscribers',
    SUM(pay.Amount) AS 'Total Revenue Generated'
FROM PLAN p
LEFT JOIN PAYMENT pay ON p.PlanID = pay.PlanID  -- LEFT JOIN 3ashan yeshmel plans mafeesh 3aleiha payments
GROUP BY p.PlanID, p.PlanName
ORDER BY SUM(pay.Amount) DESC;

-- egmali el masrof lkol member
SELECT
    m.MemberID,
    CONCAT(m.FName, ' ', m.LName) AS MemberName,
    COUNT(pay.PaymentID) AS TotalPayments,
    SUM(pay.Amount) AS TotalSpent
FROM MEMBER m
LEFT JOIN PAYMENT pay ON m.MemberID = pay.MemberID
GROUP BY m.MemberID, m.FName, m.LName
ORDER BY TotalSpent DESC;  -- el  sarf akar awal

-- el rooms elli 3andaha class wa7da aw aktar (HAVING lel filter ba3d el GROUP BY)
SELECT
    r.RoomID,
    r.RoomName,
    r.Activity,
    r.Capacity,
    COUNT(c.ClassID) AS ScheduledClasses
FROM ROOM r
LEFT JOIN CLASS c ON r.RoomID = c.RoomID
GROUP BY r.RoomID, r.RoomName, r.Activity, r.Capacity
HAVING ScheduledClasses >= 1       -- bas el rooms elli fiha classes
ORDER BY ScheduledClasses DESC;

-- el members el msglosh f ay class (LEFT JOIN + IS NULL)
SELECT
    m.MemberID,
    CONCAT(m.FName, ' ', m.LName) AS MemberName,
    m.Email,
    m.JoinDate
FROM MEMBER m
LEFT JOIN ENROLLMENT e ON m.MemberID = e.MemberID
WHERE e.EnrollmentID IS NULL;  -- lw mafesh tasgeel, yb2a msh moshtarek fi ay class

-- kol class ma3 3adad el motasaggeleen w el amaken el mota7a
SELECT
    c.ClassID,
    c.ClassName,
    c.ScheduleDay,
    c.StartTime,
    r.Capacity,
    COUNT(e.EnrollmentID) AS EnrolledCount,
    r.Capacity - COUNT(e.EnrollmentID) AS AvailableSpots  -- el amaken el fadya
FROM CLASS c
JOIN ROOM r ON c.RoomID = r.RoomID
LEFT JOIN ENROLLMENT e ON c.ClassID = e.ClassID
GROUP BY c.ClassID, c.ClassName, c.ScheduleDay, c.StartTime, r.Capacity
ORDER BY EnrolledCount DESC;

SELECT MemberID, FName, LName, Email, Phone, JoinDate
FROM MEMBER
WHERE FName LIKE '%ah%' OR LName LIKE '%ah%';

-- el members illi endamo fi 2023 mratbebin 7asab ta2re5 el t2deem
SELECT MemberID, FName, LName, JoinDate
FROM MEMBER
WHERE YEAR(JoinDate) = 2023
ORDER BY JoinDate;

-- el plans mratbeba 7asab el eradat + el taklifet el youmeyya (value analysis)
SELECT
    p.PlanID,
    p.PlanName,
    p.MonthlyFee,
    p.DurationDays,
    COUNT(pay.PaymentID) AS TimesSubscribed,
    SUM(pay.Amount) AS TotalRevenue,
    ROUND(p.MonthlyFee / p.DurationDays, 2) AS DailyCost  -- el taklifet el youmeyya
FROM PLAN p
LEFT JOIN PAYMENT pay ON p.PlanID = pay.PlanID
GROUP BY p.PlanID, p.PlanName, p.MonthlyFee, p.DurationDays
ORDER BY TotalRevenue DESC;

-- STORED PROCEDURES & FUNCTIONS
-- procedureat w funcsionat mokhzana gawwa el database

DELIMITER $$

-- GetMemberPaymentHistory
-- beterga3 kol el payments ma3 esm el member w el plan
-- betost5dm fel ReportsForm

CREATE PROCEDURE GetMemberPaymentHistory()
BEGIN
    SELECT
        pay.PaymentID,
        m.MemberID,
        CONCAT(m.FName, ' ', m.LName) AS MemberName,
        m.Email,
        p.PlanName AS Plan,
        p.MonthlyFee AS PlanFee,
        pay.Amount AS PaidAmount,
        pay.PaymentDate
    FROM PAYMENT pay
    JOIN MEMBER m ON pay.MemberID = m.MemberID
    JOIN PLAN p ON pay.PlanID = p.PlanID
    ORDER BY pay.PaymentDate DESC;  -- el ahdas awal
END$$

-- GetMemberEnrollments (p_MemberID)
-- beterga3 kol el classes illi member mo3ayan metsgel fiha
-- ==============================
CREATE PROCEDURE GetMemberEnrollments(IN p_MemberID INT)
BEGIN
    SELECT
        e.EnrollmentID,
        c.ClassName,
        c.ScheduleDay,
        c.StartTime,
        c.EndTime,
        CONCAT(t.FName, ' ', t.LName) AS Trainer,
        r.RoomName,
        e.EnrollmentDate
    FROM ENROLLMENT e
    JOIN CLASS c ON e.ClassID = c.ClassID
    JOIN TRAINER t ON c.TrainerID = t.TrainerID
    JOIN ROOM r ON c.RoomID = r.RoomID
    WHERE e.MemberID = p_MemberID  -- bas el classes bta3et el 3edo da
    ORDER BY
        FIELD(c.ScheduleDay, 'Saturday','Sunday','Monday','Tuesday','Wednesday','Thursday','Friday'),
        c.StartTime;
END$$


-- AddMemberWithPlan
-- betsegel meber gedid w biyekteb el payment el awwali bta3toh
-- kolo fi transaction wa7da: ya kolohom yengo7u ya kolohom yefshalu

CREATE PROCEDURE AddMemberWithPlan(
    IN p_FName    VARCHAR(50),
    IN p_LName    VARCHAR(50),
    IN p_Email    VARCHAR(100),
    IN p_Phone    VARCHAR(20),
    IN p_DOB      DATE,
    IN p_JoinDate DATE,
    IN p_PlanID   INT
)
BEGIN
    DECLARE v_MemberID INT;
    DECLARE v_Fee DECIMAL(10,2);

    -- lw 7asal ay error, nerga3 lel 7ala el asliyya (ROLLBACK) w nsheel el error
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        ROLLBACK;
        RESIGNAL;
    END;

    START TRANSACTION;

        -- STEP 1: bensegel el 3edo el gedid
        INSERT INTO MEMBER (FName, LName, Email, Phone, DateOfBirth, JoinDate)
        VALUES (p_FName, p_LName, p_Email, p_Phone, p_DOB, p_JoinDate);

        -- STEP 2: bna5od el ID bta3 el 3edo el leli etsgl delwa2ti
        SET v_MemberID = LAST_INSERT_ID();

        -- STEP 3: bna5od el fees el plan
        SELECT MonthlyFee INTO v_Fee FROM PLAN WHERE PlanID = p_PlanID;

        -- STEP 4: bensegel el payment el awwali
        INSERT INTO PAYMENT (MemberID, PlanID, PaymentDate, Amount)
        VALUES (v_MemberID, p_PlanID, NOW(), v_Fee);

    COMMIT;  

    -- berga3 el ID el gedid w el mabla8 illi etdafa3
    SELECT v_MemberID AS NewMemberID, v_Fee AS AmountCharged;
END$$


-- GetRevenueByPlan
-- nafs el query bta3et el report, bas metghallef fi procedure
-- 3ashan el calling code maybashsh yekteb el SQL raw

CREATE PROCEDURE GetRevenueByPlan()
BEGIN
    SELECT
        p.PlanName AS 'Membership Plan',
        COUNT(pay.PaymentID) AS 'Total Subscribers',
        SUM(pay.Amount) AS 'Total Revenue Generated'
    FROM PLAN p
    LEFT JOIN PAYMENT pay ON p.PlanID = pay.PlanID
    GROUP BY p.PlanID, p.PlanName
    ORDER BY SUM(pay.Amount) DESC;
END$$

-- DeleteMemberAndCleanup (p_MemberID)
-- bimse7 member men el database
-- el CASCADE 3ala el foreign keys biyeshtaghal w bymse7 payments w enrollments beto3o

CREATE PROCEDURE DeleteMemberAndCleanup(IN p_MemberID INT)
BEGIN
    DECLARE v_Count INT DEFAULT 0;

    -- ba2akel: hal el member da mawgood asl?
    SELECT COUNT(*) INTO v_Count FROM MEMBER WHERE MemberID = p_MemberID;

    IF v_Count = 0 THEN
        -- el member msh mawgood, beba3at error
        SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Member not found.';
    END IF;

    -- el CASCADE 3ala PAYMENT w ENROLLMENT hayeshtaghal 
    DELETE FROM MEMBER WHERE MemberID = p_MemberID;

    SELECT ROW_COUNT() AS RowsDeleted;  -- kam row etmese7et (lazem tb2a 1)
END$$

-- FUNCTION: CalculateMemberAge (p_MemberID)
-- beterga3 el age bel senen lel meber da

CREATE FUNCTION CalculateMemberAge(p_MemberID INT)
RETURNS INT
READS SQL DATA
DETERMINISTIC
BEGIN
    DECLARE v_DOB DATE;
    SELECT DateOfBirth INTO v_DOB FROM MEMBER WHERE MemberID = p_MemberID;
    RETURN TIMESTAMPDIFF(YEAR, v_DOB, CURDATE());  -- el farq bein el milad w el youm bel senen
END$$


-- FUNCTION: GetTotalSpent (p_MemberID)
-- beterga3 egmali el masrof bta3 el 3edo men awwel ma da5al

CREATE FUNCTION GetTotalSpent(p_MemberID INT)
RETURNS DECIMAL(10,2)
READS SQL DATA
DETERMINISTIC
BEGIN
    DECLARE v_Total DECIMAL(10,2) DEFAULT 0.00;
    SELECT COALESCE(SUM(Amount), 0.00) INTO v_Total  -- COALESCE: lw mafeesh payments, yb2a 0 msh NULL
    FROM PAYMENT
    WHERE MemberID = p_MemberID;
    RETURN v_Total;
END$$

DELIMITER ;

-- VERIFY - ta2kod en el script eshtaghal sa7
--  checks 3ashan netakked en el data etdakhalit

-- ba5od el payment history (nafs el ReportsForm button)
CALL GetMemberPaymentHistory();

-- ba5od el revenue 7asab el plan (nafs el Revenue Reports button)
CALL GetRevenueByPlan();

-- ba5ob el age w el payments lkol el mebers
SELECT
    MemberID,
    CONCAT(FName, ' ', LName) AS Name,
    DateOfBirth,
    CalculateMemberAge(MemberID) AS AgeYears,  -- bena5dem el function
    GetTotalSpent(MemberID) AS TotalSpent       -- w el tania kaman
FROM MEMBER
ORDER BY MemberID;

-- el classes bta3et el meber rakam 1 (Ahmed Hassan)
CALL GetMemberEnrollments(1);

-- END OF SCRIPT - khalas el database gamda 