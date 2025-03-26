create table torcida (
	credencial int primary key auto_increment,
    nome varchar(100) not null,
    idade int(2) not null,
    endereço varchar(50) not null,
    email varchar(50) not null unique,
    senha varchar(16) not null
);