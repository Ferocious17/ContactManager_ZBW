CREATE DATABASE IF NOT EXISTS ContactManager;

USE ContactManager;

CREATE TABLE person (
    salutation VARCHAR(255),
    firstName VARCHAR(255),
    lastName VARCHAR(255),
    dateOfBirth DATE,
    gender ENUM('Male', 'Female') NOT NULL,
    title VARCHAR(255),
    socialSecurityNumber INT,
    phoneNumberPrivate VARCHAR(20),
    phoneNumberMobile VARCHAR(20),
    phoneNumberBusiness VARCHAR(20),
    email VARCHAR(255),
    status int,
    nationality VARCHAR(255),
    street VARCHAR(255),
    streetNumber INT,
    zipCode INT,
    place VARCHAR(255)

);

CREATE TABLE Customer ( 
	companyName VARCHAR(255),
    customerType ENUM('Active', 'Passive') NOT NULL,
    companyContact VARCHAR(255)
);

CREATE TABLE Employee (

    employeeNumber INT(36),
    department VARCHAR(255),
    startDate DATE,
    endDate DATE,
    employment INT,
    role VARCHAR(255),
    cadreLevel INT
);

CREATE TABLE Trainee (
    traineeYears INT,
    actualTraineeYear INT
);