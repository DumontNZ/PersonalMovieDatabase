Create table MovieCategory(
MovieCategoryId int not null auto_increment,
MovieId int not null,
CategoryId int not null,
Primary key (MovieCategoryId),
Foreign key (MovieId) references Movie(MovieId),
Foreign key (CategoryId) references Category(CategoryId)
);