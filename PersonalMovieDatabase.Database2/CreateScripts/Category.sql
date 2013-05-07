create table Category(
CategoryId int not null auto_increment,
Title varchar(50) not null,
UserId int not null, 
Foreign key (UserId) references User(UserId),
primary key(CategoryId)
);