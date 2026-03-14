CREATE TABLE users
(
id INT PRIMARY KEY IDENTITY(1,1),
username VARCHAR(MAX) NULL,
password VARCHAR(MAX) NULL,
status VARCHAR(MAX) NULL,
date_created DATE NULL

)

SELECT * FROM users 

INSERT INTO users (username, password, status, date_created) VALUES('admin', 'admin123', 'Admin', '2025-01-24')




CREATE TABLE categories
(
id INT PRIMARY KEY IDENTITY(1,1),
category VARCHAR(MAX) NULL,
status VARCHAR(MAX) NULL,
date_created DATE NULL
)

SELECT * FROM categories

CREATE TABLE products
(

id INT PRIMARY KEY IDENTITY(1,1),
productid VARCHAR(MAX) NULL,
productname VARCHAR(MAX) NULL,
category VARCHAR(MAX) NULL,
stock INT NULL,
price FLOAT,
status VARCHAR(MAX) NULL,
image VARCHAR(MAX) NULL,
date_insert DATE NULL,
date_update DATE NULL,

)

SELECT * FROM products

CREATE TABLE orders
(

id INT PRIMARY KEY IDENTITY(1,1),
customerId VARCHAR(MAX) NULL,
productids VARCHAR(MAX) NULL,
quantities VARCHAR(MAX) NULL,
prices VARCHAR(MAX) NULL,
total VARCHAR(MAX) NULL,
date_order DATE NULL

)

SELECT * FROM orders
