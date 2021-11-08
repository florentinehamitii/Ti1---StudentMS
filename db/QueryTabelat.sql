CREATE TABLE Users(
UserID INT PRIMARY KEY IDENTITY(1,1),
UserName NVARCHAR(50) NOT NULL,
UserPASS NVARCHAR(50) NOT NULL,
ExpiresDate DATE,
InsertBy NVARCHAR,
InsertDate DATE,
LUB NVARCHAR,
LUD DATE,
LUN INT
);

CREATE TABLE Roles(
RoleID INT PRIMARY KEY IDENTITY(1,1),
RoleName NVARCHAR NOT NULL,
InsertBy NVARCHAR,
InsertDate DATE,
LUB NVARCHAR,
LUD DATE,
LUN INT
);




CREATE TABLE Teachers(
TeacherID INT PRIMARY KEY IDENTITY(1,1),
Foto IMAGE,
Emri NVARCHAR(50) NOT NULL,
Mbiemri NVARCHAR(50) NOT NULL,
Gjinia NVARCHAR(1),
Email NVARCHAR(70),
NumriTelefonit NVARCHAR(50),
VendBanimi NVARCHAR(50),--shtoje ne forme
Specializimi NVARCHAR(100) NOT NULL,
WeeklyWorkingHours INT,
InsertBy NVARCHAR,
InsertDate DATE,
LUB NVARCHAR,
LUD DATE,
LUN INT
);
CREATE TABLE Parents(
ParentID INT PRIMARY KEY IDENTITY(1,1),
EmriBabit NVARCHAR(100),
EmriMamit NVARCHAR(100),
Mbiemri NVARCHAR(50),
NrTel NVARCHAR(50),
Email NVARCHAR(50),
InsertBy NVARCHAR,
InsertDate DATE,
LUB NVARCHAR,
LUD DATE,
LUN INT
);

CREATE TABLE Courses(
CourseID INT PRIMARY KEY IDENTITY(1,1),
Titulli NVARCHAR(100) NOT NULL,
Pershkrimi NVARCHAR(MAX) NOT NULL,
Syllabusi VARCHAR(MAX),
Sessionet INT NOT NULL,
InsertBy NVARCHAR,
InsertDate DATE,
LUB NVARCHAR,
LUD DATE,
LUN INT
);
DROP TABLE Students

CREATE TABLE Students(
StudentID INT PRIMARY KEY IDENTITY(1,1),
Emri NVARCHAR(50) NOT NULL,
Mbiemri NVARCHAR(50) NOT NULL,
PrindiID INT FOREIGN KEY REFERENCES Parents(ParentID),
DataLindjes DATE,
Gjinia NVARCHAR(10),
Email NVARCHAR(70),
NumriTelefonit NVARCHAR(50),
Kursi INT FOREIGN KEY REFERENCES Courses(CourseID),
--Vleresimi INT FOREIGN KEY REFERENCES Vleresimet(VleresimiID), ADD VLERESIMIN
InsertBy NVARCHAR,
InsertDate DATE,
LUB NVARCHAR,
LUD DATE,
LUN INT
);

CREATE TABLE Classes(
ClassID INT PRIMARY KEY IDENTITY(1,1),
CourseID INT FOREIGN KEY REFERENCES Courses(CourseID),
TeacherID INT FOREIGN KEY REFERENCES Teachers(TeacherID),
Room INT,
InsertBy NVARCHAR,
InsertDate DATE,
LUB NVARCHAR,
LUD DATE,
LUN INT
);

CREATE TABLE Vleresimet(
VleresimiID INT PRIMARY KEY IDENTITY(1,1),
CourseID INT FOREIGN KEY REFERENCES Courses(CourseID),
TeacherID INT FOREIGN KEY REFERENCES Teachers(TeacherID),
StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
Testi1 INT,
Testi2 INT,
HomeWorks INT,
FinalGrade INT,
InsertBy NVARCHAR,
InsertDate DATE,
LUB NVARCHAR,
LUD DATE,
LUN INT
);