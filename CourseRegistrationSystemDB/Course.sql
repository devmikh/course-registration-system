CREATE TABLE [dbo].[Course]
(

	[DepartmentCode] NVARCHAR(5) NOT NULL,
	[CourseNumber] INT NOT NULL,
	[CourseTitle] NVARCHAR(150) NOT NULL, 
    CONSTRAINT [PK_Course] PRIMARY KEY ([DepartmentCode], [CourseNumber]),
	CONSTRAINT [FK_DEPARTMENT] FOREIGN KEY ([DepartmentCode]) REFERENCES [Department]([DepartmentCode]) on delete cascade,
)
