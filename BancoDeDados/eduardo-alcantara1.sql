CREATE TABLE empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    idade INT NOT NULL,
    departamento VARCHAR(50) NOT NULL,
    salario INT NOT NULL
);

insert into empregado (nome, idade, salario, departamento) values
('João', 30, 50000, 'RH'),
('Sarah', 28, 60000, 'TI'),
('Miguel', 35, 55000, 'Vendas'),
('Ana', 27, 62000, 'TI');

insert into empregado (nome, idade, salario, departamento) values
('Paulo', 59, 75000, 'Vendas');

SELECT 
    *
FROM
    empregado;
    

select * from empregado where departamento = 'TI';

select nome, salario from empregado where salario > 55000;

select * from empregado order by idade desc;



select * from empregado where idade between 28 and 35;

select * from empregado where nome like 'M%';

select * from empregado where departamento <> 'RH'; /* <> ou != */



select departamento, count(id) from empregado group by departamento;

select avg(salario) from empregado where departamento = 'TI';

select sum(salario) from empregado where departamento = 'Vendas';

drop table empregado;

create table departamento (
	id int primary key auto_increment,
    nome varchar(50) not null
);

CREATE TABLE empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    idade INT NOT NULL,
    id_departamento int NOT NULL,
    salario INT NOT NULL,
    foreign key (id_departamento)
    references departamento (id)
);

insert into departamento (nome) values ('RH'), ('TI'), ('Vendas');

insert into departamento (nome) values ('Compras');

select * from departamento;

insert into empregado (nome, idade, salario, id_departamento) values
('João', 30, 50000, 1),
('Sarah', 28, 60000, 2),
('Miguel', 35, 55000, 3),
('Ana', 27, 62000, 2),
('Paulo', 59, 75000, 3);

SELECT 
    e.nome AS Empregado, d.nome AS departamento
FROM
    empregado e
        INNER JOIN
    departamento d ON e.id_departamento = d.id;



SELECT 
    d.nome AS departamento, e.nome AS Empregado
FROM
    departamento d
        LEFT JOIN
    empregado e ON d.id = e.id_departamento;
    

select * from empregado where salario > 
(select avg(salario) from empregado);

select e.nome AS Empregado, d.nome AS Departamento from empregado e inner join departamento d on e.id_departamento = d.id where id_departamento = (Select e.id_departamento from empregado e where nome = 'Sarah');



insert into empregado (nome, idade, salario, id_departamento) values ('Tomás', 38, 58000, 3);

select d.nome, count(e.id) AS Total from empregado e join departamento d ON e.id_departamento = d.id group by id_departamento;

update empregado set salario = salario * 1.05 where id_departamento = (select id from departamento where nome = 'TI');

delete from empregado where idade > 40;

select * from empregado;

