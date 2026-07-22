CREATE DATABASE CompanyDB;
USE CompanyDB;

create table Employee(
	Ssn int primary key UNIQUE not null,
    Fname varchar(50) not null,
    Lname varchar(50) not null,
    Minit varchar(50) not null,
    Address varchar(50),
    sex char(1) CHECK (sex in ('M', 'F')),
    Bdate date,
    Salary decimal(10,2) CHECK (Salary > 0),
    DeptNumber int,
    superSsn int,
    FOREIGN KEY (superSsn) REFERENCES Employee(Ssn)
	-- FOREIGN KEY (DeptNumber) REFERENCES Department(DeptNumber)
);

create table Department(
	Dname varchar(50) UNIQUE not null,
    DeptNumber int PRIMARY KEY UNIQUE not null,
    NumberOfEmployees int,
    startDate date,
    manager int,
    FOREIGN KEY (manager) REFERENCES Employee(Ssn)
);

create table DepartmentLocation(
    DeptNumber int,
    department_location VARCHAR(50) PRIMARY KEY,
    FOREIGN KEY (DeptNumber) REFERENCES Department(DeptNumber)
);

create table Project(
	Pname varchar(50) UNIQUE not null,
    PNumber int PRIMARY KEY UNIQUE not null,
    PLocation varchar(50),
    DeptNumber int,
    FOREIGN KEY (DeptNumber) REFERENCES Department(DeptNumber)
);

create table Works_On(
	Hours decimal(4,2),
    Essn int,
    Pno int,
    FOREIGN KEY (Essn) REFERENCES Employee(Ssn),
    FOREIGN KEY (Pno) REFERENCES Project(PNumber)
);

create table Dependent(
	DependentName varchar(50) primary key,
    Sex char(1) CHECK (sex in ('M', 'F')),
    birthDate date,
    Relationship varchar(20),
    Essn int,
    FOREIGN KEY (Essn) REFERENCES Employee(Ssn)
);

-- normal insertion
insert into Employee (Ssn, Fname, Lname, Minit, Address, Sex, Bdate, Salary, Super_ssn, DeptNumber)
values (1001, 'Sara', 'Mohammed', 'A', '123 Muscat St', 'F', '2001-05-16', 850.00, NULL, NULL);

-- relate the deparment with the previous employee
insert into Department (Dname, DeptNumber, NumberOfEmployees, StartDate, Manager_ssn)
values ('Engineering', 10, 2, '2020-01-07', 1001);

-- insert new employee with previous one as supervisor
insert into Employee (Ssn, Fname, Lname, Minit, Address, Sex, Bdate, Salary, Super_ssn, DeptNumber)
values (1002, 'Noor', 'Salim', 'B', '456 Qurum St', 'F', '1992-08-22', 2300.00, 1001, 10);

-- inser a project
insert into Project (Pname, PNumber, PLocation, DeptNumber)
values ('Spark to code Project', 101, 'Building A', 10);

-- insert records into Works_On and Dependent
insert into Works_On (Hours, Essn, Pno)
values (20.50, 1002, 101);
insert into Dependent (DependentName, Sex, BirthDate, Relationship, Essn)
values ('Ahmed', 'M', '2018-11-05', 'Son', 1001);



-- Update statement for the salary 
UPDATE Employee 
SET Salary = Salary * 1.10 
WHERE Ssn = 1002;

-- Update Noor to a new Department 
UPDATE Employee 
SET DeptNumber = 20 
WHERE Ssn = 1002;

-- Change 'Spark to code Project' location 
UPDATE Project 
SET PLocation = 'Building C' 
WHERE PNumber = 101;

-- Update hours worked on Spark to code project 
UPDATE Works_On 
SET Hours = 35.00 
WHERE Essn = 1002 AND Pno = 101;

-- Correct a dependent's relationship 
UPDATE Dependent 
SET Relationship = 'brother' 
WHERE Essn = 1002 AND DependentName = 'Ahmed';



DELETE FROM Works_On 
WHERE Essn = 1002 AND Pno = 101;

DELETE FROM Employee 
WHERE Ssn = 1002;