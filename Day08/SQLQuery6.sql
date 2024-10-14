--Update Operation
UPDATE Medications
SET stock_quantity = stock_quantity + 50
WHERE name = 'Paracetamol';

--Join Operations 
--Write a JOIN query to list all medications and their corresponding supplier names.
SELECT Medications.name AS Medication_Name, Suppliers.name AS Supplier_Name
FROM Medications
JOIN Suppliers ON Medications.supplier_id = Suppliers.id;

--Write a query to display the sales data, including the medication name, customer name, and the total amount of the sale.
SELECT Sales.id, Customers.name AS Customer_Name, Medications.name AS Medication_Name, Sales.total_price
FROM Sales
JOIN Customers ON Sales.customer_id = Customers.id
JOIN Medications ON Sales.medication_id = Medications.id;

CREATE PROCEDURE AddSupplier (
    @name VARCHAR(50),
    @contact_person VARCHAR(50),
    @phone_no VARCHAR(10),
    @email VARCHAR(50),
    @address VARCHAR(50)
)
AS
BEGIN
    INSERT INTO Suppliers (name, contact_person, phone_no, email, address)
    VALUES (@name, @contact_person, @phone_no, @email, @address);
END;

EXEC AddSupplier 
    @name = 'HealthCorp', 
    @contact_person = 'Jane Smith', 
    @phone_no = '1234567890', 
    @email = 'info@healthcorp.com', 
    @address = '123 Health Street';