CREATE TABLE Products (
    ProductId INT PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL
);

CREATE TABLE Categories (
    CategoryId INT PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL
);

CREATE TABLE ProductCategories (
    ProductId INT NOT NULL,
    CategoryId INT NOT NULL,
    CONSTRAINT FK_Product FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
    CONSTRAINT FK_Category FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId),
    PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Products (ProductId, ProductName) VALUES
(1, 'Продукт A'),
(2, 'Продукт B'),
(3, 'Продукт C');

INSERT INTO Categories (CategoryId, CategoryName) VALUES
(1, 'Категория X'),
(2, 'Категория Y'),
(3, 'Категория Z');

INSERT INTO ProductCategories (ProductId, CategoryId) VALUES
(1, 1),
(1, 2),
(2, 3);

SELECT 
    p.ProductName, 
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductId = pc.ProductId
LEFT JOIN 
    Categories c ON pc.CategoryId = c.CategoryId
ORDER BY 
    p.ProductName, c.CategoryName;