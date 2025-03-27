CREATE TABLE IF NOT EXISTS livro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    data_publicacao DATETIME NOT NULL,
    numero_paginas INT NULL,
    preco DECIMAL(10, 2) NULL,
    isbn VARCHAR(17) NOT NULL UNIQUE,
    genero VARCHAR(30) NOT NULL,
    editora VARCHAR(50) NOT NULL,
    autor VARCHAR(100) NOT NULL
);