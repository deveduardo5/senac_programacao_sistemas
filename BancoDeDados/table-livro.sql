CREATE TABLE IF NOT EXISTS livro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    data_publicacao DATETIME NOT NULL,
    numero_paginas INT NULL,
    preco DECIMAL(10, 2) NULL,
    isbn VARCHAR(17) NOT NULL UNIQUE,
    id_genero INT NOT NULL,
    id_editora INT NOT NULL,
    id_autor INT NOT NULL,
    foreign key (id_genero)
    references genero (id),
    foreign key (id_editora) references editora(id),
    foreign key (id_autor) references autor(id)
);

/*

//

//FORMAS DIFERENTES DE VERIFICAR UMA DATA.

//

SELECT 

    *

FROM

    livro

WHERE data_publicacao > '1989-12-31'

AND data_publicacao < '2000-01-01';
 
SELECT 

    *

FROM

    livro

WHERE data_publicacao between '1989-12-31' AND '2000-01-01';
 
SELECT 

    *

FROM

    livro

WHERE year(data_publicacao) between '1990' AND '1999';

//

//COMO PROCURA POR UM DADO SEM REPETILO QUANDO APARECE MAIS DE UMA VEZ.

//

select distinct(autor) from livro;

//

//METODOS PARA VERIFICAR VALORES OU CONTAS ARITMÉTICAS.

//

select sum(preco),avg(preco),max(preco),min(preco)  from livro;
 
select count(id) from livro;

//

//ORDENAR UMA COLUNA POR ORDEM CRESCENTE E DESCRECENTE.

//

select * from livro

order by titulo, preco asc;
 
select * from livro

order by titulo desc;

SELECT DISTINCT * FROM autor;
SELECT DISTINCT * FROM genero;
SELECT DISTINCT * FROM editora;

*/
 