CREATE TABLE Owners (
    Id SERIAL PRIMARY KEY,
    FullName VARCHAR(255) NOT NULL DEFAULT '',
    Phone VARCHAR(50) NOT NULL DEFAULT '',
    Email VARCHAR(255) NOT NULL DEFAULT '',
    Adress VARCHAR(255) NOT NULL DEFAULT ''
);


select * from Owners



CREATE TABLE Factories (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Adress VARCHAR(255) NOT NULL,
    FoundationDate DATE NOT NULL
);

drop table Сars

CREATE TABLE CarShop (
    Id SERIAL PRIMARY KEY,
    ShopName VARCHAR(255) NOT NULL,
    Rating INT NOT NULL,
    Guarantee INT NOT NULL
);

CREATE TABLE Brands (
    Id SERIAL PRIMARY KEY,
    BrandName VARCHAR(255) NOT NULL,
    Country VARCHAR(255) NOT NULL
);



CREATE TABLE Cars (
    Id SERIAL PRIMARY KEY,
    FactoryId INT NOT NULL,
    CarShopId INT NOT NULL,
    BrandId INT NOT NULL,
    OwnerId INT NOT NULL,
    ReleaseYear DATE NOT NULL,
    Price INT NOT NULL,
    DriveType INT NOT NULL, -- Предполагается, что DriveType - это перечисление, которое можно хранить как INT
    IsAutomatic BOOLEAN NOT NULL
);

