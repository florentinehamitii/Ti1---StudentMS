Create procedure usp_InsertCourses(
@Titulli nvarchar(100),
@Sessionet int,
@InsertBy nvarchar(1),
@InsertDate Date)
as
insert into Courses(
Titulli,
Sessionet,
InsertBy,
InsertDate)
Values(@Titulli,@Sessionet,@InsertBy,@InsertDate)
go