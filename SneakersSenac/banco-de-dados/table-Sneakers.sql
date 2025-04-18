CREATE TABLE produto 
(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR (50) NOT NULL,
data_cadastro_produto DATE NOT NULL
);
insert into produto (nome) values (@nome);
update produto set venda = @venda where id = @id;

CREATE TABLE estoque
(
id INT PRIMARY KEY AUTO_INCREMENT,
produto INT NOT NULL,
quantidade INT NOT NULL, 
data_estoque DATE NOT NULL
);
insert into estoque (produto) values (@produto);

CREATE TABLE venda
(
id INT PRIMARY KEY AUTO_INCREMENT,
produto INT NOT NULL,
estoque INT NOT NULL,
data_venda DATE NOT NULL
);
