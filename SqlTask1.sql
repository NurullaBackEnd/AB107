Create database Ab107;
use Ab107;
Create table Students(
     Id int,
	 Name nvarchar(70),
	 SurName nvarchar(70),
	 Age int,
	 AvgPoint int
);
Select * from Students;
Insert into Students(Id,Name,SurName,Age,AvgPoint)
values(4,'Ali','Aliyev',23,45);	
Select * from Students Where AvgPoint > 51;
Select * from Students Where AvgPoint > 51 and AvgPoint < 90;
Select * from Students Where  Name like 'A%i';