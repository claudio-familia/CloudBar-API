CREATE DATABASE cloudbar;

USE cloudbar;

CREATE TABLE roles (
	id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(250)
);

CREATE TABLE places (
	id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(250),
    address NVARCHAR(250),
    latitude NVARCHAR(250),
    longitude NVARCHAR(250)
);

CREATE TABLE people (
	id INT PRIMARY KEY AUTO_INCREMENT,
    placeId INT,
    identification NVARCHAR(50) unique not null,
    name NVARCHAR(100) not null,
    lastname NVARCHAR(100) not null,
    datebirth datetime,
    address NVARCHAR(250),
    phone NVARCHAR(20),
    createdAt Datetime,
    createdBy INT,
    updatedAt Datetime,
    updatedBy INT    
);

ALTER TABLE people 
ADD FOREIGN KEY (placeId) REFERENCES places(id);

CREATE TABLE users (
	id INT PRIMARY KEY AUTO_INCREMENT,
    roleId INT,
    personId INT,
    username NVARCHAR(250),
    password NVARCHAR(250),
    createdAt DATETIME,
    createdBy INT,
    updatedAt Datetime,
    updatedBy INT
);

ALTER TABLE users 
ADD FOREIGN KEY (roleId) REFERENCES roles(id);

ALTER TABLE users 
ADD FOREIGN KEY (personId) REFERENCES people(id);

CREATE TABLE orders (
	id INT PRIMARY KEY AUTO_INCREMENT,
    userId INT,
    placeId INT,
    type NVARCHAR(50),
    total DECIMAL(18, 2),
    rating INT,
    createdAt DATETIME,
    createdBy INT,
    updatedAt Datetime,
    updatedBy INT
);

ALTER TABLE orders 
ADD FOREIGN KEY (userId) REFERENCES users(id);

ALTER TABLE orders 
ADD FOREIGN KEY (placeId) REFERENCES places(id);

CREATE TABLE categories (
	id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(100),
    description NVARCHAR(250)
);

CREATE TABLE items (
	id INT PRIMARY KEY AUTO_INCREMENT,
    categoryId INT,
    name NVARCHAR(100),
    description NVARCHAR(250),
    stock INT,
    price DECIMAL(18, 2),
    createdAt DATETIME,
    createdBy INT,
    updatedAt Datetime,
    updatedBy INT
);

ALTER TABLE items 
ADD FOREIGN KEY (categoryId) REFERENCES categories(id);

CREATE TABLE orderLines (
	id INT PRIMARY KEY AUTO_INCREMENT,
    itemId INT,
    quantity INT,
    price DECIMAL(18, 2),
    createdAt DATETIME
);

ALTER TABLE orderLines 
ADD FOREIGN KEY (itemId) REFERENCES items(id);

CREATE TABLE suppliers (
	id INT PRIMARY KEY AUTO_INCREMENT,
    isJuridic BOOLEAN,
    identification NVARCHAR(50) unique not null,
    name NVARCHAR(100),
    address NVARCHAR(250),
    phone NVARCHAR(50)
);

CREATE TABLE supplier_items (
	id INT PRIMARY KEY AUTO_INCREMENT,
    itemId INT,
    supplierId INT,    
	price DECIMAL(18, 2),
    createdAt DATETIME,
    createdBy INT,
    updatedAt Datetime,
    updatedBy INT
);

ALTER TABLE supplier_items 
ADD FOREIGN KEY (itemId) REFERENCES items(id);

ALTER TABLE supplier_items 
ADD FOREIGN KEY (supplierId) REFERENCES suppliers(id);

CREATE TABLE purchaseorders (
	id INT PRIMARY KEY AUTO_INCREMENT,
    userId INT,
    placeId INT,
    supplierId INT,
    invoiceNumber NVARCHAR(100),
    paymentType NVARCHAR(50),
    total DECIMAL(18, 2),
    pending DECIMAL(18, 2)
);

ALTER TABLE purchaseorders 
ADD FOREIGN KEY (userId) REFERENCES users(id);

ALTER TABLE purchaseorders 
ADD FOREIGN KEY (placeId) REFERENCES places(id);

ALTER TABLE purchaseorders 
ADD FOREIGN KEY (supplierId) REFERENCES suppliers(id);

CREATE TABLE purchaseorderlines (
	id INT PRIMARY KEY AUTO_INCREMENT,
    purchaseorderId INT,
    supplierItemsId INT,        
    price DECIMAL(18, 2),
    quantity DECIMAL(18, 2)
);

ALTER TABLE purchaseorderlines 
ADD FOREIGN KEY (purchaseorderId) REFERENCES purchaseorders(id);

ALTER TABLE purchaseorderlines 
ADD FOREIGN KEY (supplierItemsId) REFERENCES supplier_items(id);


CREATE TABLE invoices (
	id INT PRIMARY KEY AUTO_INCREMENT,
    userId INT,
    orderId INT,
    lawTip DECIMAL(18, 2),
    total DECIMAL(18, 2),
    date Datetime,
    ncf NVARCHAR(50),
    ncfDueDate datetime,
    createdAt DATETIME,
    createdBy INT,
    updatedAt Datetime,
    updatedBy INT
);

ALTER TABLE invoices 
ADD FOREIGN KEY (userId) REFERENCES users(id);

ALTER TABLE invoices 
ADD FOREIGN KEY (orderId) REFERENCES orders(id);


