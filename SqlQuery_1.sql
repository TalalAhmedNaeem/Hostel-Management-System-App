create database hostelsmanagement

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'allroom')
BEGIN
    CREATE TABLE allroom (
        roomNo bigint NOT NULL PRIMARY KEY,
        roomStatus varchar(250) NOT NULL,
        Booked varchar(150) DEFAULT 'No'
    );
END

TRUNCATE TABLE allroom;

INSERT INTO allroom (roomNo, roomStatus, Booked)
VALUES 
(100, 'Yes', 'Yes'),
(101, 'Yes', 'No'),
(102, 'Yes', 'No'),
(200, 'Yes', 'Yes');

SELECT * FROM allroom;
