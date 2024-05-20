CREATE DATABASE pms;
CREATE TABLE admins (     
	AdminUuid varchar(36) NOT NULL,     
    Name varchar(255) NOT NULL,     
    Email varchar(255) NOT NULL,     
    Password varchar(255) NOT NULL )
INSERT INTO admins VALUES (UUID(), 'Test user', 'savenko340@gmail.com', 'test')