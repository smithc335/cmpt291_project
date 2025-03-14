USE MovieRentalSystem;

-- Remove test data

DELETE RateActor;
DELETE AppearedIn;
DELETE QueueUp;
DELETE Rental;
DELETE Actor;
DELETE Movie;
DELETE EmployeePhone;
DELETE Employee;
DELETE CustomerPhone;
DELETE Customer;

-- Add test data for Customer and CustomerPhone

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, EmailAddress, AcctNum, AcctCreateDate, CreditCardNum)
	VALUES (NEXT VALUE FOR Customer_CustomerID_Seq, 'Smith', 'John', '4563 Pine St', 'Edmonton', 'AB', 'T5J2Z1', 'john.smith@gmail.com', NEXT VALUE FOR Customer_AcctNum_Seq, '2025-01-15', '4125169729432940');

INSERT INTO CustomerPhone (CustomerID, PhoneNum, PhoneType)
	VALUES ((SELECT CustomerID FROM Customer WHERE EmailAddress = 'john.smith@gmail.com'), '7802634786', 'Mobile');

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, EmailAddress, AcctNum, AcctCreateDate, CreditCardNum)
	VALUES (NEXT VALUE FOR Customer_CustomerID_Seq, 'Ferrell', 'Stacey', '714 Elsa Fall Apt. 635', 'Edmonton', 'AB', 'T5H3Z4', 'stacell13@yahoo.com', NEXT VALUE FOR Customer_AcctNum_Seq, '2025-02-15', '4189716201947152');

INSERT INTO CustomerPhone (CustomerID, PhoneNum, PhoneType)
	VALUES ((SELECT CustomerID FROM Customer WHERE EmailAddress = 'stacell13@yahoo.com'), '7805871202', 'Mobile');

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, EmailAddress, AcctNum, AcctCreateDate, CreditCardNum)
	VALUES (NEXT VALUE FOR Customer_CustomerID_Seq, 'Mckay', 'Phoebe', '318 Cole Walk', 'Calgary', 'AB', 'T6T0H7', 'p.mckay@hotmail.ca', NEXT VALUE FOR Customer_AcctNum_Seq, '2025-02-23', '4134199034560738');

INSERT INTO CustomerPhone (CustomerID, PhoneNum, PhoneType)
	VALUES ((SELECT CustomerID FROM Customer WHERE EmailAddress = 'p.mckay@hotmail.ca'), '7805776766', 'Mobile');

-- Add test data for Employee and EmployeePhone

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, Province, PostalCode) 
	VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, '123456789', 'Sharma', 'Amit', '123 Main St', 'Toronto', 'ON', 'M4B1B3');

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, Province, PostalCode, StartDate) 
	VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, '987654321', 'Patel', 'Priya', '456 Elm St', 'Vancouver', 'BC', 'V5K2B1', '2025-03-05');

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, Province, PostalCode, StartDate) 
	VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, '567890123', 'Singh', 'Rahul', '789 Oak St', 'Calgary', 'AB', 'T2N1N4', '2025-02-21');

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, Province, PostalCode, StartDate) 
VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, '345678901', 'Kaur', 'Simran', '321 Pine St', 'Montreal', 'QC', 'H3Z2Y7', '2024-10-31');

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES ((SELECT EmployeeID FROM Employee WHERE SSN = '123456789'), '7802634786', 'Mobile');

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES ((SELECT EmployeeID FROM Employee WHERE SSN = '567890123'), '7805871202', 'Home');

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES ((SELECT EmployeeID FROM Employee WHERE SSN = '567890123'), '7805776766', 'Mobile');

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES ((SELECT EmployeeID FROM Employee WHERE SSN = '345678901'), '5879971002', 'Mobile');

-- Add test data for Movie

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies)
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'Fast & Furious', 'Action', 150.00, 10);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'Superbad', 'Comedy', 120.50, 5);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'Parasite', 'Foreign', 200.00, 7);

-- Add test data for Actor

INSERT INTO Actor (ActorID, Name, Gender, DateOfBirth) 
	VALUES (NEXT VALUE FOR Actor_ActorID_Seq, 'Leonardo DiCaprio', 'M', '1974-11-11');

INSERT INTO Actor (ActorID, Name, Gender, DateOfBirth) 
	VALUES (NEXT VALUE FOR Actor_ActorID_Seq, 'Scarlett Johansson', 'F', '1984-11-22');

INSERT INTO Actor (ActorID, Name, Gender, DateOfBirth) 
	VALUES (NEXT VALUE FOR Actor_ActorID_Seq, 'Tom Hanks', 'M', '1956-07-09');

-- Add test data for Rental

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
	VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 1, 2, 3, '2025-03-07', NULL, NULL);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
	VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 2, 3, 1, '2025-02-25', '2025-03-02', 4);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
	VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 3, 1, 2, '2025-02-20', '2025-02-28', 5);

-- Add test data for QueueUp

INSERT INTO QueueUp (MovieID, CustomerID)
	VALUES ((SELECT MovieId FROM Movie WHERE Name = 'Fast & Furious'), (SELECT CustomerID FROM Customer WHERE EmailAddress = 'john.smith@gmail.com'));

INSERT INTO QueueUp (MovieID, CustomerID)
	VALUES ((SELECT MovieId FROM Movie WHERE Name = 'Fast & Furious'), (SELECT CustomerID FROM Customer WHERE EmailAddress = 'p.mckay@hotmail.ca'));

INSERT INTO QueueUp (MovieID, CustomerID)
	VALUES ((SELECT MovieId FROM Movie WHERE Name = 'Parasite'), (SELECT CustomerID FROM Customer WHERE EmailAddress = 'stacell13@yahoo.com'));

-- Add test data for AppearedIn

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES ((SELECT MovieId FROM Movie WHERE Name = 'Superbad'), (SELECT ActorID FROM Actor WHERE Name = 'Leonardo DiCaprio'));

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES ((SELECT MovieId FROM Movie WHERE Name = 'Fast & Furious'), (SELECT ActorID FROM Actor WHERE Name = 'Tom Hanks'));

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES ((SELECT MovieId FROM Movie WHERE Name = 'Parasite'), (SELECT ActorID FROM Actor WHERE Name = 'Scarlett Johansson'));

-- Add test data for RateActor

INSERT INTO RateActor (RentalID, ActorID, ActorRating)
	VALUES (1, (SELECT ActorID FROM Actor WHERE Name = 'Leonardo DiCaprio'), 5);

INSERT INTO RateActor (RentalID, ActorID, ActorRating)
	VALUES (2, (SELECT ActorID FROM Actor WHERE Name = 'Tom Hanks'), 3);

INSERT INTO RateActor (RentalID, ActorID, ActorRating)
	VALUES (3, (SELECT ActorID FROM Actor WHERE Name = 'Tom Hanks'), 4);