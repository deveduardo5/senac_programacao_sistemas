create table if not exists editora (
	id int primary key auto_increment,
    nome varchar(100) not null,
    documento varchar(14) not null unique
);