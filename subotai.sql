drop table Orders;
drop table Carts;
drop table CreditCards;
drop table ProductsSold;
drop table Users;
drop table ProductDescriptionValues;
drop table ProductItems;
drop table ProductDescriptionElements;
drop table Pictures;
drop table Products;
drop table Categories;
drop table Translations;
drop table Phrases;
drop table Languages;

create table Languages
(
	Id bigint identity primary key,
	Name text,
	Currency text
);

create table Phrases
(
	Id bigint identity primary key,
	Phrase text
);


insert into Languages (name) values ('_polish');

insert into Phrases (Phrase) values ('_unknown_database_error');

create table Translations
(
	Id bigint identity primary key,
	IdLanguages bigint references Languages(Id),
	IdPhrases bigint references Phrases(Id),
	Translation text
);

create table Categories 
(
	Id integer identity primary key,
	Name text
);

create table Products 
(
	Id integer identity primary key,
	IdCategories int references Categories(Id),
	Name text,
	ProductVat decimal,
	IsPriceGross int,
	HowMuchCount int,
	Description text,
	Price decimal
);

create table Pictures
(
	Id integer identity primary key,
	IdProducts integer references Products(id),
	Photo text -- base 64
);

create table ProductItems 
(
	Id integer identity primary key,
	IdProducts integer references Products(Id),
	Name text
);

create table ProductDescriptionElements 
(
	Id integer identity primary key,
	IdProducts integer references Products(id),
	ParameterName text 

);

create table ProductDescriptionValues
(
	Id integer identity primary key,
	IdProductDescriptionElements integer references ProductDescriptionElements(Id),
	Value text -- json
);

create table Users
(
	Id bigint identity primary key,
	ComesFrom int,
	Gender int,
	Name text,
	Surname text,
	Email text,
	Phone text,
	Password text,
	EmailVerified int,
	City text,
	PostCode text,
	Street text,
	IdLanguages bigint references Languages(Id)
);

create table ProductsSold
(
	Id integer identity primary key,
	IdProduct int references Products(Id),
	SoldCount int,
	Price decimal,
	IdLanguages bigint references Languages(Id), -- for currency
	IdUser bigint references Users(Id)
);

create table CreditCards
(
	Id integer identity primary key,
	IdUsers bigint references Users(Id),
	Number text,
	Month text,
	Year text,
	Owner text
);

create table Carts 
(
	Id integer identity primary key,
	IdProductItems int references ProductItems(Id),
	IdUser bigint references Users(id)
);

create table Orders 
(
	Id integer identity primary key,
	IdCarts integer references Carts(Id),
	IdUser bigint references Users(id)
);
