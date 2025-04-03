/*Exercícios SQL 02*/

/*1. Consultas Básicas*/

/*Exercício 1: Selecionando Dados*/
create table if not exists cliente (
	id int primary key auto_increment,
    nome varchar(100) not null,
    idade int (02) not null,
    cidade varchar(50),
    saldo decimal not null
);

insert into cliente (
	nome,
    idade,
    cidade,
    saldo
) values
	('Carlos', 45, 'São Paulo', 2500.00),
    ('Mariana', 32, 'Rio de Janeiro', 3200.50),
    ('Pedro', 27, 'Belo Horizonte', 1500.75),
    ('Fernanda', 38, 'Curitiba', 4200.00);
    
SELECT 
    *
FROM
    pedido;
    
/*Tarefas:*/

/*1. Selecione todos os clientes que moram no Rio de Janeiro.*/
SELECT 
    *
FROM
    cliente
WHERE
    cidade = 'Rio de Janeiro';
    
/*2. Liste os clientes com saldo superior a 2.000, ordenados pelo saldo em ordem
decrescente.*/
SELECT 
    *
FROM
    cliente
WHERE
    saldo > 2.000
ORDER BY saldo DESC;

/*3. Recupere apenas os nomes e idades dos clientes com mais de 30 anos.*/
SELECT 
    nome, idade
FROM
    cliente
WHERE
    idade > 30;
    
/*2. Filtrando e Aplicando Condições*/

/*Exercício 2: Cláusula WHERE*/

/*1. Encontre todos os clientes cuja idade está entre 25 e 40 anos.*/
SELECT 
    *
FROM
    cliente
WHERE
    idade > 25 AND idade < 40;
    
/*2. Recupere os clientes cujo nome começa com 'F'.*/
SELECT 
    *
FROM
    cliente
WHERE
    nome LIKE 'F%';
    
/*3. Liste os clientes que não moram em São Paulo nem Curitiba.*/
SELECT 
    *
FROM
    cliente
WHERE
    cidade != 'São Paulo' and cidade != 'Curitiba';
    
/*3. Agregação e Agrupamento*/

/*Exercício 3: COUNT, SUM, AVG, GROUP BY*/

CREATE TABLE IF NOT EXISTS pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    cliente_id INT NOT NULL,
    valor DECIMAL NOT NULL,
    data_pedido VARCHAR(10) NOT NULL
);

insert into pedido (
	cliente_id,
    valor,
    data_pedido
) values 
	(1, 500.00, '2024-03-10'),
    (2, 1200.00, '2024-03-12'),
    (3, 300.50, '2024-03-15'),
    (1, 800.00, '2024-03-18');

SELECT 
    *
FROM
    pedido;
    
/*Tarefas:*/

/*1. Conte quantos pedidos foram feitos no total.*/
SELECT 
    COUNT(*)
FROM
    pedido;

/*2. Calcule o valor médio dos pedidos.*/
SELECT 
    AVG(valor)
FROM
    pedido;

/*3. Agrupe os pedidos por cliente_id e exiba o total gasto por cada cliente.*/
SELECT
	cliente_id,
    SUM(valor)
FROM
    pedido
GROUP BY cliente_id;

/*4. Junções (Joins)*/

/*Exercício 4: INNER JOIN, LEFT JOIN*/

/*1. Use um INNER JOIN para exibir os pedidos junto com o nome do cliente
correspondente.*/



/*SELECT 
    cliente.id,
    cliente.nome,
    cliente.idade,
    cliente.cidade,
    cliente.saldo,
    pedido.valor AS valor,
    pedido.data_pedido AS data_pedido,
    pedido.cliente_id AS id_cliente
FROM
    cliente l
        INNER JOIN
    pedido pedido ON pedido.id_pedido = pedido.id;*/