-- Create the Product table with ProdID as a string (VARCHAR) and unique
CREATE TABLE Product (
    ProdID VARCHAR(20) PRIMARY KEY,  -- ProdID as a string and unique
    ProdName NVARCHAR(100),
    Quantity INT,
    Price DECIMAL(10, 2),
    Origin NVARCHAR(50),
    ExpireDate DATETIME
);

delete from PRoduct 
where ProdID = 'abcxyz'

-- Insert dummy data into the Product table
INSERT INTO Product (ProdID, ProdName, Quantity, Price, Origin, ExpireDate)
VALUES
    ('P001', 'Widget A', 100, 19.99, 'USA', '2024-12-31'),
    ('P002', 'Gadget B', 50, 29.99, 'China', '2025-06-30'),
    ('P003', 'Tool C', 75, 39.99, 'Germany', '2024-09-30');
	
INSERT INTO Product (ProdID, ProdName, Quantity, Price, Origin, ExpireDate)
VALUES('P004', 'Elysia Signet', 50, 29.99, N'Nhật Bản', '2023-06-30');