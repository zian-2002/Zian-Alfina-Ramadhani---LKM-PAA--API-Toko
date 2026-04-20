-- CUSTOMERS
CREATE TABLE customers (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    phone VARCHAR(15),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- PRODUCTS
CREATE TABLE products (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- ORDERS
CREATE TABLE orders (
    id SERIAL PRIMARY KEY,
    customer_id INT,
    product_id INT,
    quantity INT,
    total_price DECIMAL(10,2),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (customer_id) REFERENCES customers(id),
    FOREIGN KEY (product_id) REFERENCES products(id)
);

-- INDEX
CREATE INDEX idx_customer ON orders(customer_id);
CREATE INDEX idx_product ON orders(product_id);

-- SAMPLE DATA (5)
INSERT INTO customers (name, phone) VALUES
('Zian','0811'),('Sinta','0822'),('Ofi','0833'),('Adel','0844'),('Lovya','0855');

INSERT INTO products (name, price) VALUES
('Shampoo',20000),('Pomade',50000),('Gel',30000),('Sisir',10000),('Spray',40000);

INSERT INTO orders (customer_id, product_id, quantity, total_price) VALUES
(1,1,2,40000),(2,2,1,50000),(3,3,3,90000),(4,4,2,20000),(5,5,1,40000);

select * from products
