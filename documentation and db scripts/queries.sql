/*1 - stwórz baze danych */

CREATE DATABASE pms

/*2 - stwórz tabele z adminami */
CREATE TABLE `admins` (
  `Uuid` varchar(36) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*3 - stwórz testowego admina, hasło póki nie szyfrowane */

INSERT INTO `admins` VALUE (UUID(), 'Test User', 'testemail@gmail.com', 'password')

/*4 - stwórz tabele z produktami*/
CREATE TABLE products (id int , name varchar(255), dateOfCreation datetime)