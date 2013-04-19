Create table Movie(
MovieId int not null auto_increment,
Title varchar(100),
Year varchar(4) not null,
Rating int,
Own bool,
Watched bool,
ComputerLocation varchar(500),
UserId int not null,
Primary Key (MovieId),
Foreign Key(UserId) references User(UserId)
);

