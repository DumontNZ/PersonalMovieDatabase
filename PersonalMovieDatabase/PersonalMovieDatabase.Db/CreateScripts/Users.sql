delimiter $$

CREATE TABLE `users` (
  `userId` int(20) NOT NULL AUTO_INCREMENT,
  `userName` varchar(50) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `surname` varchar(50) NOT NULL,
  `email` varchar(200) NOT NULL,
  `password` varchar(50) NOT NULL,
  `dateCreatedUTC` datetime NOT NULL,
  `dateDelectedUTC` datetime DEFAULT NULL,
  `userscol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`userId`,`userName`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8$$

