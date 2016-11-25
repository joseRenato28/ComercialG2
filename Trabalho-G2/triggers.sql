use trabalhoG2Db;

DELIMITER $$
CREATE TRIGGER update_input_stock
BEFORE INSERT ON inputstockproducts
FOR EACH ROW BEGIN
UPDATE products
SET amount = amount + NEW.amount
WHERE id_product = NEW.product_id_product;
END$$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER update_input_stock3
BEFORE DELETE ON inputstockproducts
FOR EACH ROW BEGIN
UPDATE products
SET amount = amount -OLD.amount
WHERE id_product = OLD.product_id_product;
END$$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER update_output_stock
BEFORE INSERT ON outputstockproducts
FOR EACH ROW BEGIN
UPDATE products
SET amount = amount - NEW.amount
WHERE id_product = NEW.product_id_product;
END$$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER update_output_stock3
BEFORE DELETE ON outputstockproducts
FOR EACH ROW BEGIN
UPDATE products
SET amount = amount + OLD.amount
WHERE id_product = OLD.product_id_product;
END$$
DELIMITER ;
