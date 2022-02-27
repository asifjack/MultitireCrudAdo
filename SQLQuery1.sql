Create Database MultiLayerCrud_Db

Use MultiLayerCrud_Db

Create table Employees(
 id int not null identity ,
 FirstName varchar(100),
 LastName varchar(100),
 Email varchar(100),
 Gender varchar(100)
) 
insert into Employees values
('Asif','Alam','asif@gmail.com','male'),
('Soha','Khan','soahkhan@gmail.com','female')

select * from Employees;