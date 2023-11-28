create database MarksCrud
go
use MarksCrud

create table Student(
StudentRollNo int primary key not null,
StudentName varchar(50),
ClassId varchar(50),
SubjectName varchar(50))

insert into Student values(101,'smruthi','Tenth','Programming'),(102,'pavitra','Ninth','HTML'),
(103,'vibhav','Eighth','NodeJs'),(104,'vinay','Seventh','DotNet'),(105,'Abheejith','Sixth','CSS'),
(106,'yashas','fifth','Java'),(107,'Teja','Fourth','JavaScript'),(108,'Sangeetha','Third','ASPdotNet'),(109,'Sanvi','Fourth','Sql'),(110,'Sangeetha','Second','React')
select* from Student

create table SubjectMarks(
StudentRollNo int foreign key references Student(StudentRollNo),
Marks int )

insert into SubjectMarks values(103,50),(105,75),(110,56),(106,83)




