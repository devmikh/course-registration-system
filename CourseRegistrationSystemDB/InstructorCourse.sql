CREATE TABLE [dbo].[InstructorCourse]
(
	
	[InstructorId] INT NOT NULL,
	[DepartmentCode] NVARCHAR(5) NOT NULL,
	[CourseNumber] INT NOT NULL,
	CONSTRAINT [FK_INSTRUCTOR] FOREIGN KEY ([InstructorId]) REFERENCES [Instructor]([InstructorId]) on delete cascade,
	CONSTRAINT [FK_INSTRUCTOR_COURSE] FOREIGN KEY ([DepartmentCode], [CourseNumber]) REFERENCES [Course]([DepartmentCode], [CourseNumber]) on delete cascade,
    CONSTRAINT [PK_InstructorCourse] PRIMARY KEY ([InstructorId], [DepartmentCode], [CourseNumber]) 

)
