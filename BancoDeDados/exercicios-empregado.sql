create table if not exists empregado (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade int(02) NOT NULL,
    departamento varchar(50) not null,
    salario decimal NOT NULL
);