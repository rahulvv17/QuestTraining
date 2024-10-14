CREATE TABLE accounts (
    id INT PRIMARY KEY IDENTITY(100,1),
    account_number INT UNIQUE,
    name VARCHAR(50) NOT NULL,
    date_of_birth DATE,
    address VARCHAR(100) NOT NULL,
    phone_number VARCHAR(20),
    email VARCHAR(50) NOT NULL UNIQUE,
    account_type VARCHAR(50) NOT NULL, -- Savings, Checking
    balance DECIMAL(18,2) DEFAULT 0
);

CREATE TABLE transactions (
    id INT PRIMARY KEY IDENTITY(200,1),
    from_account_id INT,
    to_account_id INT, 
    amount DECIMAL(18,2),
    transaction_date DATETIME DEFAULT GETDATE(),
    transaction_type VARCHAR(50),
    CONSTRAINT fk_to_account_id FOREIGN KEY (to_account_id) REFERENCES accounts(id),
    CONSTRAINT fk_from_account_id FOREIGN KEY (from_account_id) REFERENCES accounts(id)
);
