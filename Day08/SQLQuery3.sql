----questions---
---create an account--
INSERT INTO accounts(account_number, [name], date_of_birth, [address], phone_number, email, account_type, balance)
VALUES(9999,'pourna','2001-10-06','pournika','9895589702','pourna@gmail.com','checking',80000.00);
---delete an account---
DELETE FROM accounts WHERE account_number = 2345;
---update an account---
UPDATE accounts SET account_type ='savings' WHERE account_number = 1123;
---deposit an amount---
UPDATE accounts SET balance = balance + 500 WHERE id = 100;


INSERT INTO transactions(from_account_id, to_account_id, amount, transaction_type)
VALUES(null,100,500,'deposit');

SELECT id, account_number, [name],balance FROM accounts WHERE id = 100;

----withdraw an amount---
UPDATE accounts SET balance = balance - 1000 WHERE id =101;


INSERT INTO transactions(from_account_id, to_account_id, amount, transaction_type)
VALUES(null,101,1000,'withdraw');

SELECT account_number, [name],balance FROM accounts WHERE id = 101;

---view history---

SELECT Transactions.id AS transaction_id,
       Transactions.from_account_id ,
	   Transactions.to_account_id,
	   Transactions.amount,
	   Transactions.transaction_type,
	   Transactions.transaction_date,
	   [accounts.name] AS customer_name,
	   accounts.balance
	   FROM Transactions left join accounts ON accounts.id = Transactions.to_account_id ORDER BY Transactions.transaction_date DESC;