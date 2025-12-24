-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema ClothesManagement
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ClothesManagement
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ClothesManagement` DEFAULT CHARACTER SET utf8 ;
USE `ClothesManagement` ;

-- -----------------------------------------------------
-- Table `ClothesManagement`.`user`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ClothesManagement`.`user` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT 'User ID',
  `username` VARCHAR(45) NOT NULL COMMENT 'User name: for login/register',
  `password` VARCHAR(100) NOT NULL COMMENT 'password to login/register',
  `role` ENUM('admin', 'staff') NULL DEFAULT 'staff',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ClothesManagement`.`clothes_type`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ClothesManagement`.`clothes_type` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT 'Clothes type ID',
  `name` VARCHAR(45) NOT NULL COMMENT 'Clothes type name',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `name_UNIQUE` (`name` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ClothesManagement`.`clothes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ClothesManagement`.`clothes` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT 'Clothes ID',
  `name` VARCHAR(45) NOT NULL COMMENT 'Clothes name',
  `typeID` INT NOT NULL COMMENT 'foreign key to clothes type ID',
  `size` ENUM('S', 'M', 'L', 'XL', 'XXL', 'OS') NULL COMMENT 'Size clothes:\nS: small\nM: medium\nL: large\nXL: extra large\nXXL: extrax2 large\nOS: over size',
  `color` VARCHAR(20) NULL COMMENT 'color of clothes',
  `price` DECIMAL(10,2) NOT NULL COMMENT 'moneyyyy',
  `quantity` INT NOT NULL DEFAULT 0 COMMENT 'clothes quantity',
  PRIMARY KEY (`id`),
  INDEX `type_id_idx` (`typeID` ASC) VISIBLE,
  CONSTRAINT `clothes_type_id`
    FOREIGN KEY (`typeID`)
    REFERENCES `ClothesManagement`.`clothes_type` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ClothesManagement`.`bill`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ClothesManagement`.`bill` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT 'Bill ID',
  `dateSold` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'day that sold clothes for customer',
  `customerName` VARCHAR(100) NOT NULL COMMENT 'Customer name',
  `userID` INT NULL COMMENT 'foregin key to user',
  PRIMARY KEY (`id`),
  INDEX `user_id_idx` (`userID` ASC) VISIBLE,
  CONSTRAINT `user_id`
    FOREIGN KEY (`userID`)
    REFERENCES `ClothesManagement`.`user` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ClothesManagement`.`bill_detail`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ClothesManagement`.`bill_detail` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT 'bill detail ID',
  `billID` INT NOT NULL COMMENT 'foregin key to bill ID\n',
  `clothesID` INT NOT NULL COMMENT 'foregin key to clothes ID',
  `quantity` INT NOT NULL,
  `price` DECIMAL(10,2) NOT NULL COMMENT 'price at the day sold',
  `totalPrice` DECIMAL(10,2) GENERATED ALWAYS AS (quantity * price) STORED COMMENT 'total price = quantity * price',
  PRIMARY KEY (`id`),
  INDEX `bill_id_idx` (`billID` ASC) VISIBLE,
  INDEX `clothes_id_idx` (`clothesID` ASC) VISIBLE,
  CONSTRAINT `bill_id`
    FOREIGN KEY (`billID`)
    REFERENCES `ClothesManagement`.`bill` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `clothes_id`
    FOREIGN KEY (`clothesID`)
    REFERENCES `ClothesManagement`.`clothes` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


INSERT INTO `user` (username, password, role) VALUES
('admin', 'admin123', 'admin'),
('nhanvien1', '123456', 'staff'),
('nhanvien2', '123456', 'staff');



INSERT INTO clothes_type (name) VALUES
('Ao thun'),
('Ao so mi'),
('Quan jean'),
('Quan tay'),
('Vay'),
('Dam'),
('Ao khoac');


INSERT INTO clothes (name, typeID, size, color, price, quantity) VALUES
('Ao thun tron', 1, 'M', 'trang', 150000, 50),
('Ao thun in hinh', 1, 'L', 'den', 180000, 40),
('Ao so mi tay dai', 2, 'M', 'xanh', 250000, 30),
('Ao so mi ngan tay', 2, 'L', 'trang', 230000, 25),

('Quan jean xanh', 3, 'L', 'xanh', 350000, 20),
('Quan jean den', 3, 'M', 'den', 360000, 15),

('Quan tay nam', 4, 'L', 'xam', 400000, 10),

('Vay ngan', 5, 'M', 'hong', 320000, 18),
('Dam dai', 6, 'L', 'do', 450000, 12),

('Ao khoac du', 7, 'XL', 'den', 500000, 8);


INSERT INTO bill (customerName, userID) VALUES
('Nguyen Van A', 2),
('Tran Thi B', 2),
('Le Van C', 3);


INSERT INTO bill_detail (billID, clothesID, quantity, price) VALUES
(1, 1, 2, 150000),
(1, 5, 1, 350000),

(2, 3, 1, 250000),
(2, 8, 1, 320000),

(3, 2, 3, 180000),
(3, 6, 1, 360000);


SELECT * FROM user;
SELECT * FROM clothes_type;
SELECT * FROM clothes;
SELECT * FROM bill;
SELECT * FROM bill_detail;
