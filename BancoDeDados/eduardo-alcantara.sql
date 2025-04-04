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
    
insert into cliente (nome, cidade, idade) values ('João Silva', 'São Paulo', 35), ('Maria Santos', 'Belo Horizonte', 28), ('Carlos Lima ', 'Rio de Janeiro ', 42), ('Fernanda Rocha', 'Curitiba', 30);

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
SELECT nome, categoria, preco FROM produto WHERE categoria = 'Eletrônicos' AND preco > 3000 ORDER BY nome ASC;

/*2. Encontre os clientes que não moram em São Paulo e têm idade acima de 30 anos.*/
SELECT * FROM cliente WHERE cidade <> 'São Paulo' and idade > 30;

/*3. Liste os pedidos feitos entre "2024-03-10" e "2024-03-15", ordenados pela data em ordem crescente.*/
SELECT * FROM pedido WHERE date(data_pedido) between '2024-03-10' AND '2024-03-15';

/*4. Recupere os produtos cujo estoque é menor que 10 unidades e exiba em ordem crescente de estoque.*/
SELECT nome, estoque FROM produto WHERE estoque < 10 ORDER BY estoque ASC;

/*5. Liste os fornecedores que não estão no Rio de Janeiro e cujo nome começa com "T".*/
SELECT * FROM fornecedor WHERE cidade != 'Rio de Janeiro' AND nome LIKE 'T%';

/*Agregação e Agrupamento (COUNT, SUM, AVG, GROUP BY)*/

/*1. Calcule o preço médio dos produtos para cada categoria.*/
SELECT categoria, AVG(preco) FROM produto GROUP BY categoria;

/*2. Conte quantos pedidos cada cliente realizou.*/
SELECT cliente_id, COUNT(quantidade) FROM pedido GROUP BY cliente_id;

/*3. Liste o total de produtos em estoque por categoria.*/
select categoria, sum(estoque) from produto group by categoria;

/*4. Encontre o pedido com a maior quantidade de produtos comprados e exiba o id do
pedido, produto_id e quantidade.*/

/*5. Descubra quantos clientes há em cada cidade, ordenando os resultados da cidade com
mais clientes para a cidade com menos clientes.*/
