CREATE TABLE [dbo].[StudentCourse]
(
	[StudentId] INT NOT NULL ,
	[DepartmentCode] NVARCHAR(5) NOT NULL ,
	[CourseNumber] INT NOT NULL ,
	CONSTRAINT [FK_STUDENT] FOREIGN KEY ([StudentId]) REFERENCES [Student]([StudentId]) on delete cascade,
	CONSTRAINT [FK_STUDENT_COURSE] FOREIGN KEY ([DepartmentCode], [CourseNumber]) REFERENCES [Course]([DepartmentCode], [CourseNumber]) on delete cascade,
    CONSTRAINT [PK_StudentCourse] PRIMARY KEY ([StudentId], [DepartmentCode], [CourseNumber]) 

)
