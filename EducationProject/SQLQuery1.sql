CREATE TABLE [UserType]
(
 [UserTypeId]   int NOT NULL identity(1,1) ,
 [UserTypeName] nvarchar(50) NOT NULL ,

 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED ([UserTypeId] ASC)
);
GO








-- ************************************** [TaskCategory]

CREATE TABLE [TaskCategory]
(
 [TaskCategoryId]   int NOT NULL identity(1,1) ,
 [TaskCategoryName] nvarchar(50) NOT NULL ,

 CONSTRAINT [PK_TaskCategory] PRIMARY KEY CLUSTERED ([TaskCategoryId] ASC)
);
GO








-- ************************************** [Package]

CREATE TABLE [Package]
(
 [PackageId]       int NOT NULL identity(1,1) ,
 [PackageName]     nvarchar(50) NOT NULL ,
 [PackageDuration] int NULL ,

 CONSTRAINT [PK_Programs] PRIMARY KEY CLUSTERED ([PackageId] ASC)
);
GO








-- ************************************** [Message]

CREATE TABLE [Message]
(
 [MessageId] int NOT NULL identity(1,1) ,

 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED ([MessageId] ASC)
);
GO








-- ************************************** [Library]

CREATE TABLE [Library]
(
 [LibraryId]       int NOT NULL identity(1,1) ,
 [LibraryItemName] nvarchar(50) NOT NULL ,
 [LibraryItemUrl]  nvarchar(max) NOT NULL ,
 [LibraryItemType] bit NOT NULL ,

 CONSTRAINT [PK_Library] PRIMARY KEY CLUSTERED ([LibraryId] ASC)
);
GO








-- ************************************** [GroupCategoryType]

CREATE TABLE [GroupCategoryType]
(
 [GroupCategoryTypeId]          int NOT NULL  identity(1,1),
 [ProgramCategoryTypeName]      nvarchar(50) NOT NULL ,
 [ProgramCategoryTypeStartTime] time NOT NULL ,
 [ProgramCategoryTypeEndTime]   time NOT NULL ,

 CONSTRAINT [PK_GroupCategoryType] PRIMARY KEY CLUSTERED ([GroupCategoryTypeId] ASC)
);
GO








-- ************************************** [User]

CREATE TABLE [User]
(
 [UserId]     int NOT NULL  identity(1,1),
 [UserTypeId] int NOT NULL ,

 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserId] ASC),
 CONSTRAINT [FK_86] FOREIGN KEY ([UserTypeId])  REFERENCES [UserType]([UserTypeId])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_86] ON [User] 
 (
  [UserTypeId] ASC
 )

GO







-- ************************************** [Teacher]

CREATE TABLE [Teacher]
(
 [TeacherId]      int NOT NULL identity(1,1) ,
 [PackageId]      int NOT NULL ,
 [TeacherName]    nvarchar(50) NOT NULL ,
 [TeacherSurname] nvarchar(50) NOT NULL ,
 [TeacherEmail]   nvarchar(50) NOT NULL ,
 [TeacherPhone]   nvarchar(50) NULL ,
 [TeacherBio]     nvarchar(50) NULL ,
 [TeacherPhoto]   nvarchar(50) NULL ,

 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED ([TeacherId] ASC),
 CONSTRAINT [FK_89] FOREIGN KEY ([PackageId])  REFERENCES [Package]([PackageId]),
 CONSTRAINT UQ_Teacher_Email UNIQUE ([TeacherEmail])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_89] ON [Teacher] 
 (
  [PackageId] ASC
 )

GO







-- ************************************** [Task]

CREATE TABLE [Task]
(
 [TaskId]         int NOT NULL identity(1,1),
 [TaskName]       nvarchar(50) NOT NULL ,
 [TaskUrl]        nvarchar(max) NOT NULL ,
 [TaskStartDate]  nvarchar(50) NOT NULL ,
 [TaskDuration]   int NOT NULL ,
 [TaskDetails]    nvarchar(max) NOT NULL ,
 [TaskCategoryId] int NOT NULL ,

 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED ([TaskId] ASC),
 CONSTRAINT [FK_129] FOREIGN KEY ([TaskCategoryId])  REFERENCES [TaskCategory]([TaskCategoryId])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_129] ON [Task] 
 (
  [TaskCategoryId] ASC
 )

GO







-- ************************************** [Mentor]

CREATE TABLE [Mentor]
(
 [MentorId]      int NOT NULL identity(1,1) ,
 [PackageId]     int NOT NULL ,
 [MentorName]    nvarchar(50) NOT NULL ,
 [MentorSurname] nvarchar(50) NOT NULL ,
 [MentorEmail]   nvarchar(50) NOT NULL ,
 [MentorPhone]   nvarchar(50) NULL ,
 [MentorBio]     nvarchar(max) NULL ,
 [MentorPhoto]   nvarchar(50) NULL ,

 CONSTRAINT [PK_Mentor] PRIMARY KEY CLUSTERED ([MentorId] ASC),
 CONSTRAINT [FK_110] FOREIGN KEY ([PackageId])  REFERENCES [Package]([PackageId]),
 CONSTRAINT UQ_Mentro_Email UNIQUE ([MentorEmail])

);
GO


CREATE NONCLUSTERED INDEX [fkIdx_110] ON [Mentor] 
 (
  [PackageId] ASC
 )

GO







-- ************************************** [GroupCategory]

CREATE TABLE [GroupCategory]
(
 [GroupCategoryId]     int NOT NULL  identity(1,1),
 [GroupCategoryTypeId] int NOT NULL ,
 [GroupCategoryName]   nvarchar(50) NOT NULL ,

 CONSTRAINT [PK_GroupCategory] PRIMARY KEY CLUSTERED ([GroupCategoryId] ASC),
 CONSTRAINT [FK_75] FOREIGN KEY ([GroupCategoryTypeId])  REFERENCES [GroupCategoryType]([GroupCategoryTypeId])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_75] ON [GroupCategory] 
 (
  [GroupCategoryTypeId] ASC
 )

GO







-- ************************************** [Group]

CREATE TABLE [Group]
(
 [GroupId]         int NOT NULL identity(1,1) ,
 [PackageId]       int NOT NULL ,
 [MentorId]        int NOT NULL ,
 [TeacherId]       int NOT NULL ,
 [GroupCategoryId] int NOT NULL ,
 [GroupStartDate]  date NULL ,

 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED ([GroupId] ASC),
 CONSTRAINT [FK_48] FOREIGN KEY ([PackageId])  REFERENCES [Package]([PackageId]),
 CONSTRAINT [FK_54] FOREIGN KEY ([MentorId])  REFERENCES [Mentor]([MentorId]),
 CONSTRAINT [FK_57] FOREIGN KEY ([TeacherId])  REFERENCES [Teacher]([TeacherId]),
 CONSTRAINT [FK_80] FOREIGN KEY ([GroupCategoryId])  REFERENCES [GroupCategory]([GroupCategoryId])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_48] ON [Group] 
 (
  [PackageId] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_54] ON [Group] 
 (
  [MentorId] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_57] ON [Group] 
 (
  [TeacherId] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_80] ON [Group] 
 (
  [GroupCategoryId] ASC
 )

GO







-- ************************************** [Student]

CREATE TABLE [Student]
(
 [StudentId]               int NOT NULL identity(1,1),
 [GroupId]                 int NOT NULL ,
 [StudentName]             nvarchar(50) NULL ,
 [StudentSurname]          nvarchar(50) NULL ,
 [StudentBirthDate]        date NULL ,
 [StudentEmail]            nvarchar(50) NULL ,
 [StudentPhone]            nvarchar(50) NULL ,
 [StudentRegistrationDate] datetime NULL ,
 [StudentPhoto]            nvarchar(50) NULL ,
 [StudentBio]              nvarchar(max) NOT NULL ,

 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([StudentId] ASC),
 CONSTRAINT [FK_51] FOREIGN KEY ([GroupId])  REFERENCES [Group]([GroupId]),
 CONSTRAINT UQ_Student_Email UNIQUE ([StudentEmail] )

);
GO


CREATE NONCLUSTERED INDEX [fkIdx_51] ON [Student] 
 (
  [GroupId] ASC
 )

GO







-- ************************************** [Transcript]

CREATE TABLE [Transcript]
(
 [TranscriptId] int  NOT NULL identity(1,1) ,
 [TaskId]       int NOT NULL ,
 [StudentId]    int NOT NULL ,
 [TaskPoint]    int NOT NULL ,

 CONSTRAINT [PK_Transcript] PRIMARY KEY CLUSTERED ([TranscriptId] ASC),
 CONSTRAINT [FK_156] FOREIGN KEY ([TaskId])  REFERENCES [Task]([TaskId]),
 CONSTRAINT [FK_159] FOREIGN KEY ([StudentId])  REFERENCES [Student]([StudentId])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_156] ON [Transcript] 
 (
  [TaskId] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_159] ON [Transcript] 
 (
  [StudentId] ASC
 )

GO







-- ************************************** [AssignTask]

CREATE TABLE [AssignTask]
(
 [AssignTaskId] int NOT NULL identity(1,1) ,
 [TaskId]       int NOT NULL ,
 [StudentId]    int NOT NULL ,

 CONSTRAINT [PK_AssignTask] PRIMARY KEY CLUSTERED ([AssignTaskId] ASC),
 CONSTRAINT [FK_141] FOREIGN KEY ([TaskId])  REFERENCES [Task]([TaskId]),
 CONSTRAINT [FK_144] FOREIGN KEY ([StudentId])  REFERENCES [Student]([StudentId])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_141] ON [AssignTask] 
 (
  [TaskId] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_144] ON [AssignTask] 
 (
  [StudentId] ASC
 )

GO







