/*Avaliação SQL*/

/*1. Estrutura das Tabelas*/

CREATE TABLE IF NOT EXISTS fornecedor (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL
);

SELECT 
    *
FROM
    fornecedor;
    
insert into fornecedor (nome, cidade) values ('TechBrasil', 'São Paulo'), ('Computech', 'Rio de Janeiro'), ('Moveis&Co', 'Curitiba');

CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    preco DECIMAL NOT NULL,
    estoque INT NOT NULL,
    id_fornecedor int not null,
    FOREIGN KEY (id_fornecedor)
        REFERENCES fornecedor (id)
);

SELECT 
    *
FROM
    produto;
    
insert into produto (nome, categoria, preco, estoque, id_fornecedor) values ('Celular X', 'Eletrônicos', 2500.00, 30, 1), ('Notebook Y', 'Eletrônicos', 4800.00, 15, 2), ('Mesa de
Madeira', 'Móveis', 750.00, 10, 3), ('Cadeira Z', 'Móveis', 300.00, 25, 3), ('TV 50"', 'Eletrônicos', 3500.00 , 8, 1);

CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    idade INT NOT NULL
);

SELECT 
    *
FROM
    cliente;
    
insert into cliente (nome, cidade, idade) values ('João Silva', 'São Paulo', 35), ('Maria Santos', 'Belo Horizonte', 28), ('Carlos Lima', 'Rio de Janeiro ', 42), ('Fernanda Rocha', 'Curitiba', 30), ('Lucas Ruiz', 'Curitiba', 35), ('Rodrigo Garro', 'Curitiba', 40), ('Galvão Bueno', 'Rio de Janeiro ', 60);

CREATE TABLE IF NOT EXISTS pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    produto_id INT NOT NULL,
    FOREIGN KEY (produto_id)
        REFERENCES produto (id),
    quantidade INT NOT NULL,
    data_pedido DATE NOT NULL,
    cliente_id INT NOT NULL,
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);

SELECT 
    *
FROM
    pedido;
    
insert into pedido (produto_id, quantidade, data_pedido, cliente_id) values ( 1, 2, '2024-03-10', 1), ( 3, 1, '2024-03-11', 2), ( 2, 1, '2024-03-15', 3), ( 5, 3, '2024-03-18', 1), ( 4, 4, '2024-03-20', 4);



/*2. Exercícios Avançados*/

/*Consultas e Filtros (WHERE, ORDER BY, LIKE, BETWEEN)*/

/*1. Selecione os produtos da categoria "Eletrônicos" cujo preço seja superior a R$3000, ordenados do mais caro para o mais barato.*/
SELECT 
    nome, categoria, preco
FROM
    produto
WHERE
    categoria = 'Eletrônicos'
        AND preco > 3000
ORDER BY preco desc;

/*2. Encontre os clientes que não moram em São Paulo e têm idade acima de 30 anos.*/
SELECT 
    *
FROM
    cliente
WHERE
    cidade <> 'São Paulo' AND idade > 30;

/*3. Liste os pedidos feitos entre "2024-03-10" e "2024-03-15", ordenados pela data em ordem crescente.*/
SELECT 
    *
FROM
    pedido
WHERE
    DATE(data_pedido) BETWEEN '2024-03-10' AND '2024-03-15' order by data_pedido asc; 

/*4. Recupere os produtos cujo estoque é menor que 10 unidades e exiba em ordem crescente de estoque.*/
SELECT 
    nome, estoque
FROM
    produto
WHERE
    estoque < 10
ORDER BY estoque ASC;

/*5. Liste os fornecedores que não estão no Rio de Janeiro e cujo nome começa com "T".*/
SELECT 
    *
FROM
    fornecedor
WHERE
    cidade != 'Rio de Janeiro'
        AND nome LIKE 'T%';



/*Agregação e Agrupamento (COUNT, SUM, AVG, GROUP BY)*/

/*1. Calcule o preço médio dos produtos para cada categoria.*/
SELECT 
    categoria, AVG(preco) AS média
FROM
    produto
GROUP BY categoria;

/*2. Conte quantos pedidos cada cliente realizou.*/
SELECT 
    cliente_id, COUNT(quantidade) AS pedidos
FROM
    pedido
GROUP BY cliente_id;

/*3. Liste o total de produtos em estoque por categoria.*/
SELECT 
    categoria, SUM(estoque) AS estoque
FROM
    produto
GROUP BY categoria;

/*4. Encontre o pedido com a maior quantidade de produtos comprados e exiba o id do
pedido, produto_id e quantidade.*/
SELECT 
    id AS id_pedido, produto_id, SUM(quantidade)
FROM
    senac.pedido
GROUP BY quantidade DESC
LIMIT 1;

/*5. Descubra quantos clientes há em cada cidade, ordenando os resultados da cidade com
mais clientes para a cidade com menos clientes.*/
SELECT 
    COUNT(nome) AS cliente, cidade
FROM
    cliente
GROUP BY cidade
ORDER BY cliente DESC;



/*Junções (INNER JOIN)*/

/*1. Liste todos os produtos junto com o nome do fornecedor correspondente, ordenados
pelo nome do fornecedor.*/
SELECT 
    p.nome AS produto, f.nome
FROM
    produto p
        INNER JOIN
    fornecedor f ON p.id_fornecedor = f.id
ORDER BY f.nome ASC;

/*2. Mostre os pedidos junto com o nome do cliente e o nome do produto comprado,
ordenando pela data do pedido.*/
SELECT 
    pedido.id AS pedido,
    cliente.nome AS nome,
    produto.nome AS produto,
    pedido.data_pedido
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
        INNER JOIN
    produto ON pedido.produto_id = produto.id
ORDER BY pedido.data_pedido ASC;

/*3. Liste todos os pedidos e exiba o nome do cliente, o nome do produto e o nome do
fornecedor do produto.*/
SELECT 
    pedido.id AS pedido,
    cliente.nome AS nome,
    produto.nome AS produto,
    fornecedor.nome AS fornecedor
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
        INNER JOIN
    produto ON pedido.produto_id = produto.id
        INNER JOIN
    fornecedor ON produto.id_fornecedor = fornecedor.id;

/*4. Mostre a quantidade total de produtos comprados por cada cliente, listando o nome do
cliente e a soma total de produtos adquiridos.*/
SELECT 
    cliente.nome AS nome, SUM(quantidade) AS quantidade
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
GROUP BY cliente.nome;



/*Subconsultas e Modificação de Dados (Subquery, UPDATE, DELETE,
INSERT INTO)*/

/*1. Encontre os produtos cujo preço é superior à média de todos os produtos da mesma
categoria.*/
SELECT 
    *
FROM
    produto p
WHERE
    preco > (SELECT 
            AVG(preco)
        FROM
            produto pr
        WHERE
            p.categoria = pr.categoria)
ORDER BY categoria ASC;

/*2. Aumente o preço dos produtos da categoria "Eletrônicos" em 10%.*/
UPDATE produto 
SET 
    preco = 1.10 * preco
WHERE
    categoria = 'Eletrônicos';

/*3. Remova os pedidos de clientes que moram em Curitiba.*/
DELETE FROM pedido 
WHERE
    cliente_id IN (SELECT 
        cidade
    FROM
        cliente
    
    WHERE
        cidade = 'Curitiba');

SELECT 
    *
FROM
    pedido;

/*4. Insira um novo cliente chamado "Ricardo Lopes", que mora em Porto Alegre e tem 38
anos.*/
insert into cliente (nome, cidade, idade) values ('Ricardo Lopes', 'Porto Alegre', 38);

SELECT 
    *
FROM
    cliente;

/*5. Insira um novo pedido para o cliente "João Silva", comprando 2 unidades de "Notebook
Y" no dia "2024-03-25".*/
SELECT 
    id
FROM
    profuto
WHERE
    nome = 'Notebook Y';

SELECT 
    *
FROM
    cliente
WHERE
    nome = 'joao silva'
        AND cidade = 'sao paulo';

insert into pedido (produto_id, quantidade, data_pedido, cliente_id) values (2, '2024-03-25', (select id from profuto where nome = 'Notebook Y'), (select * from cliente where nome = 'joao silva' and cidade = 'sao paulo'));

/*6. Crie uma consulta que exiba o nome dos clientes que já compraram produtos da
categoria "Móveis".*/
SELECT 
    cliente.nome,
    produto.categoria,
    pedido.id AS 'Número do Pedido',
    produto.nome AS 'Nome do Produto'
FROM
    pedido
        JOIN
    cliente ON cliente_id = cliente.id
        JOIN
    produto ON produto_id = produto.id
WHERE
    produto.id = ANY (SELECT 
            produto.id
        FROM
            produto
        WHERE
            categoria = 'Móveis');
