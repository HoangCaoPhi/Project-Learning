--
-- Script was generated by Devart dbForge Studio 2020 for MySQL, Version 9.0.338.0
-- Product home page: http://www.devart.com/dbforge/mysql/studio
-- Script date 9/26/2023 5:25:22 PM
-- Server version: 8.0.27
-- Client version: 4.1
--

-- 
-- Disable foreign keys
-- 
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;

-- 
-- Set SQL mode
-- 
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

--
-- Set default database
--
USE ef_learn;

--
-- Drop table `category`
--
DROP TABLE IF EXISTS category;

--
-- Drop table `products`
--
DROP TABLE IF EXISTS products;

--
-- Set default database
--
USE ef_learn;

--
-- Create table `products`
--
CREATE TABLE products (
  ProductId int NOT NULL AUTO_INCREMENT,
  Name varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  Provider varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (ProductId)
)
ENGINE = INNODB,
AUTO_INCREMENT = 5,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci;

--
-- Create table `category`
--
CREATE TABLE category (
  CategoryId int NOT NULL,
  Name varchar(50) DEFAULT NULL,
  Description text DEFAULT NULL,
  PRIMARY KEY (CategoryId)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table products
--
INSERT INTO products VALUES
(2, 'Sản phẩm 2', 'Công ty 1'),
(3, 'máy tính bảng xách tay', 'nhà cung cấp'),
(4, 'string', 'string');

-- 
-- Dumping data for table category
--
-- Table ef_learn.category does not contain any data (it is empty)

-- 
-- Restore previous SQL mode
-- 
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;

-- 
-- Enable foreign keys
-- 
/*!40014 SET FOREIGN_KEY_CHECKS = @OLD_FOREIGN_KEY_CHECKS */;