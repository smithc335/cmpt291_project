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
DELETE UserLogin;

-- Add test data for Customer and CustomerPhone

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, EmailAddress, AcctNum, AcctCreateDate, CreditCardNum)
	VALUES (NEXT VALUE FOR Customer_CustomerID_Seq, 'Smith', 'John', '4563 Pine St', 'Edmonton', 'AB', 'T5J2Z1', 'john.smith@gmail.com', NEXT VALUE FOR Customer_AcctNum_Seq, '2025-01-15', '4125169729432940');

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, EmailAddress, AcctNum, AcctCreateDate, CreditCardNum)
	VALUES (NEXT VALUE FOR Customer_CustomerID_Seq, 'Smith', 'Elizabeth', '4563 Pine St', 'Edmonton', 'AB', 'T5J2Z1', 'eliza.smith@gmail.com', (SELECT AcctNum FROM Customer WHERE EmailAddress = 'john.smith@gmail.com'), '2025-01-15', '4125169729432940');

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, EmailAddress, AcctNum, CreditCardNum)
	VALUES (NEXT VALUE FOR Customer_CustomerID_Seq, 'McDonald', 'Catherine', '3786 67 Ave', 'Vancouver', 'BC', 'V5H2K3', 'cathy@mcdonald.ca', NEXT VALUE FOR Customer_AcctNum_Seq, '4175937592275629');

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, EmailAddress, AcctNum, AcctCreateDate, CreditCardNum)
	VALUES (NEXT VALUE FOR Customer_CustomerID_Seq, 'Ferrell', 'Stacey', '714 Elsa Fall Apt. 635', 'Edmonton', 'AB', 'T5H3Z4', 'stacell13@yahoo.com', NEXT VALUE FOR Customer_AcctNum_Seq, '2025-02-15', '4189716201947152');

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, EmailAddress, AcctNum, AcctCreateDate, CreditCardNum)
	VALUES (NEXT VALUE FOR Customer_CustomerID_Seq, 'Mckay', 'Phoebe', '318 Cole Walk', 'Calgary', 'AB', 'T6T0H7', 'p.mckay@hotmail.ca', NEXT VALUE FOR Customer_AcctNum_Seq, '2025-02-23', '4134199034560738');

-- Add test data for CustomerPhone

INSERT INTO CustomerPhone (CustomerID, PhoneNum, PhoneType)
	VALUES ((SELECT CustomerID FROM Customer WHERE EmailAddress = 'john.smith@gmail.com'), '7802634786', 'Mobile');

INSERT INTO CustomerPhone (CustomerID, PhoneNum, PhoneType)
	VALUES ((SELECT CustomerID FROM Customer WHERE EmailAddress = 'stacell13@yahoo.com'), '7805871202', 'Mobile');

INSERT INTO CustomerPhone (CustomerID, PhoneNum, PhoneType)
	VALUES ((SELECT CustomerID FROM Customer WHERE EmailAddress = 'p.mckay@hotmail.ca'), '7805776766', 'Mobile');

INSERT INTO CustomerPhone (CustomerID, PhoneNum, PhoneType)
	VALUES ((SELECT CustomerID FROM Customer WHERE EmailAddress = 'john.smith@gmail.com'), '5871174658', 'Home');

-- Add test data for Employee

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, Province, PostalCode, StartDate) 
	VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, '387584938', 'Smith', 'Claire', 'MacEwan University', 'Edmonton', 'AB', 'T5J2P2', '2025-01-06');

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, Province, PostalCode, StartDate) 
	VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, '238759295', 'Beaulieu', 'Matt', 'MacEwan University', 'Edmonton', 'AB', 'T5J2P2', '2025-01-06');

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, Province, PostalCode, StartDate) 
	VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, '385774936', 'Bains', 'Kovidh', 'MacEwan University', 'Edmonton', 'AB', 'T5J2P2', '2025-01-06');

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, Province, PostalCode, StartDate) 
	VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, '673867955', 'Sutariya', 'Jaisica', 'MacEwan University', 'Edmonton', 'AB', 'T5J2P2', '2025-01-06');

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, Province, PostalCode) 
	VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, '123456789', 'Sharma', 'Amit', '123 Main St', 'Toronto', 'ON', 'M4B1B3');

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, Province, PostalCode, StartDate) 
	VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, '987654321', 'Patel', 'Priya', '456 Elm St', 'Vancouver', 'BC', 'V5K2B1', '2025-03-05');

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, Province, PostalCode, StartDate) 
	VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, '567890123', 'Singh', 'Rahul', '789 Oak St', 'Calgary', 'AB', 'T2N1N4', '2025-02-21');

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, Province, PostalCode, StartDate) 
VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, '345678901', 'Kaur', 'Simran', '321 Pine St', 'Montreal', 'QC', 'H3Z2Y7', '2024-10-31');

-- Add test data for EmployeePhone

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES ((SELECT EmployeeID FROM Employee WHERE SSN = '123456789'), '7802634786', 'Mobile');

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES ((SELECT EmployeeID FROM Employee WHERE SSN = '567890123'), '7805871202', 'Home');

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES ((SELECT EmployeeID FROM Employee WHERE SSN = '567890123'), '7805776766', 'Mobile');

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES ((SELECT EmployeeID FROM Employee WHERE SSN = '345678901'), '5879971002', 'Mobile');

-- Add test data for UserLogin

INSERT INTO UserLogin (EmployeeID, Username, PasswordHash)
	VALUES ((SELECT EmployeeID FROM Employee WHERE FirstName = 'Claire' and LastName = 'Smith'), 'smithc', '3FE92FCD855752C77DEE500FABF6C309');
	-- Password = claire1234

INSERT INTO UserLogin (EmployeeID, Username, PasswordHash)
	VALUES (2, 'beaulieum', 'B9457A0168DF164F35C9D4289753367F');
	-- Password = matt1234

INSERT INTO UserLogin (EmployeeID, Username, PasswordHash)
	VALUES (3, 'bainsk', '7F4C9AEC5A9D6A01C508224AF1729478');
	-- Password = kovidh1234

INSERT INTO UserLogin (EmployeeID, Username, PasswordHash)
	VALUES (4, 'sutariyaj', '2E01A20F8E63F62721E59E9E372511CE');
	-- Password = jaisica1234

-- Add test data for Movie

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'Iron Man', 'Action', 210.00, 4);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'The Notebook', 'Drama', 150.25, 7);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'Avengers: Age of Ultron', 'Action', 205.00, 8);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'School of Rock', 'Comedy', 100.00, 3);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'She''s the Man', 'Comedy', 275.00, 10);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'Spirited Away', 'Foreign', 175.50, 2);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'Captain America: The Winter Soldier', 'Action', 210.00, 8);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'La La Land', 'Drama', 190.75, 5);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, '10 Things I Hate About You', 'Comedy', 200.00, 7);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'Interstellar', 'Drama', 225.00, 9);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'The Shawshank Redemption', 'Drama', 210.00, 4);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies)
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'Fast & Furious', 'Action', 150.00, 10);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'Superbad', 'Comedy', 120.50, 5);

INSERT INTO Movie (MovieID, Name, Type, DistributionFee, NumCopies) 
	VALUES (NEXT VALUE FOR Movie_MovieID_Seq, 'Parasite', 'Foreign', 200.00, 7);

-- Add test data for Actor

INSERT INTO Actor (ActorID, Name, Gender, DateOfBirth) 
	VALUES (NEXT VALUE FOR Actor_ActorID_Seq, 'Robert Downey Jr.', 'M', '1965-04-04');

INSERT INTO Actor (ActorID, Name, Gender, DateOfBirth) 
	VALUES (NEXT VALUE FOR Actor_ActorID_Seq, 'Jack Black', 'M', '1969-08-28');

INSERT INTO Actor (ActorID, Name, Gender, DateOfBirth) 
	VALUES (NEXT VALUE FOR Actor_ActorID_Seq, 'Emma Stone', 'F', '1988-11-06');

INSERT INTO Actor (ActorID, Name, Gender, DateOfBirth) 
	VALUES (NEXT VALUE FOR Actor_ActorID_Seq, 'Chris Evans', 'M', '1981-06-13');

INSERT INTO Actor (ActorID, Name, Gender, DateOfBirth) 
	VALUES (NEXT VALUE FOR Actor_ActorID_Seq, 'Anne Hathaway', 'F', '1982-11-12');

INSERT INTO Actor (ActorID, Name, Gender, DateOfBirth) 
	VALUES (NEXT VALUE FOR Actor_ActorID_Seq, 'Gwyneth Paltrow', 'F', '1972-09-27');

INSERT INTO Actor (ActorID, Name, Gender, DateOfBirth) 
	VALUES (NEXT VALUE FOR Actor_ActorID_Seq, 'Elizabeth Olsen', 'F', '1989-02-16');

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

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 3, 1, 2, '2025-01-20', '2025-01-28', 4.5);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 2, 3, 1, '2026-02-26', '2026-03-03', 4);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 14, 5, 1, '2025-04-20', '2025-04-25', 3.5);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 10, 5, 1, '2025-05-25', '2025-05-27', 3);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 4, 4, 1, '2025-06-10', '2025-06-20', 2);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 4, 2, 1, '2025-07-12', '2025-07-22', 3);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 7, 2, 1, '2025-07-10', '2025-07-15', 4);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 12, 1, 3, '2025-08-05', '2025-08-15', 4.5);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 12, 2, 3, '2025-09-04', '2025-09-14', 5);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 12, 1, 3, '2025-10-25', '2025-10-27', 4);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 13, 1, 3, '2025-11-01', '2025-11-11', 3.5);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 8, 3, 3, '2025-12-20', '2025-12-25', 1);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 11, 4, 2, '2025-12-21', '2025-12-26', 4);

INSERT INTO Rental (RentalID, MovieID, CustomerID, EmployeeID, CheckoutDate, ReturnDate, CustRateMovie) 
    VALUES (NEXT VALUE FOR Rental_RentalID_Seq, 11, 5, 2, '2025-12-21', '2025-12-26', 4);

-- Add test data for QueueUp

INSERT INTO QueueUp (MovieID, CustomerID)
	VALUES ((SELECT MovieId FROM Movie WHERE Name = 'Fast & Furious'), (SELECT CustomerID FROM Customer WHERE EmailAddress = 'john.smith@gmail.com'));

INSERT INTO QueueUp (MovieID, CustomerID)
	VALUES ((SELECT MovieId FROM Movie WHERE Name = 'Fast & Furious'), (SELECT CustomerID FROM Customer WHERE EmailAddress = 'p.mckay@hotmail.ca'));

INSERT INTO QueueUp (MovieID, CustomerID)
	VALUES ((SELECT MovieId FROM Movie WHERE Name = 'Parasite'), (SELECT CustomerID FROM Customer WHERE EmailAddress = 'stacell13@yahoo.com'));

-- Add test data for AppearedIn

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES ((SELECT MovieId FROM Movie WHERE Name = 'Iron Man'), (SELECT ActorID FROM Actor WHERE Name = 'Robert Downey Jr.'));

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES ((SELECT MovieId FROM Movie WHERE Name = 'Iron Man'), (SELECT ActorID FROM Actor WHERE Name = 'Gwyneth Paltrow'));

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES ((SELECT MovieId FROM Movie WHERE Name = 'Captain America: The Winter Soldier'), (SELECT ActorID FROM Actor WHERE Name = 'Robert Downey Jr.'));

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

-- View whole tables

SELECT * FROM UserLogin;
SELECT * FROM Customer;
--SELECT * FROM CustomerPhone;
--SELECT * FROM Employee;
--SELECT * FROM EmployeePhone;
--SELECT * FROM Movie;
--SELECT * FROM Actor;
--SELECT * FROM Rental;
--SELECT * FROM QueueUp;
--SELECT * FROM AppearedIn;
--SELECT * FROM RateActor;

select distinct year(CheckoutDate) from Rental