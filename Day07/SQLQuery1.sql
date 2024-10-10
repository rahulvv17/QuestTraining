CREATE TABLE product_categories (
    id BIGINT PRIMARY KEY IDENTITY,
    category_id INT,
    product_id BIGINT,

    CONSTRAINT FK_category_id FOREIGN KEY (category_id) REFERENCES categories(id),
    CONSTRAINT FK_product_id FOREIGN KEY (product_id) REFERENCES products(id)
);


INSERT INTO product_categories (category_id, product_id) 
VALUES 
(2, 1),
(3, 1),
(2, 2),
(3, 2);
