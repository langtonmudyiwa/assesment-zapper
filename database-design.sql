CREATE TABLE Customers (
    customer_id INT PRIMARY KEY,
    name VARCHAR(100),
    email VARCHAR(100)
); 

CREATE TABLE Merchants (
    merchant_id INT PRIMARY KEY,
    name VARCHAR(100),
    contact_email VARCHAR(100)
);

CREATE TABLE Transactions (
    transaction_id INT PRIMARY KEY,
    customer_id INT,
    merchant_id INT,
    transaction_date DATE,
    amount DECIMAL(10, 2),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id),
    FOREIGN KEY (merchant_id) REFERENCES Merchants(merchant_id)
);
