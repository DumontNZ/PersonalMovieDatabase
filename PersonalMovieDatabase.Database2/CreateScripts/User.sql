Create table User
(UserId int not null auto_increment,
UserName varchar(50) Not null,
Email varchar(200) not null,
FirstName varchar(50) not null,
Surname varchar(50) not null,
Password varchar(200) not null,
Country varchar (50) not null,
CreatedOnDateUTC TIMESTAMP,
DeleteOnDateUTC date,
PRIMARY KEY (UserId))
;
