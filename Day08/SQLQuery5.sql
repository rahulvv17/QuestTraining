 CREATE PROCEDURE InsertMedication
    @Name VARCHAR(100),
    @Category VARCHAR(50),
    @Price DECIMAL(10,2),
    @ExpiryDate DATE,
    @SupplierID INT,
    @StockQuantity INT
AS
BEGIN
    

    INSERT INTO Medications (name, category, price, expiry_date, supplier_id, stock_quantity)
    VALUES (@Name, @Category, @Price, @ExpiryDate, @SupplierID, @StockQuantity);
END
EXEC InsertMedication
    @Name = 'Paracetamol',
    @Category = 'Pain Reliever',
    @Price = 2.50,
    @ExpiryDate = '2025-12-31',
    @SupplierID = 1,
    @StockQuantity = 100;