/*SELECT 
    livro.id,
    livro.titulo,
    livro.data_publicacao,
    livro.numero_paginas,
    livro.preco,
    livro.isbn,
    genero.nome AS genero,
    editora.nome AS editora,
    autor.nome AS autor
FROM
    livro,
    genero,
    editora,
    autor
WHERE
    livro.id_genero = genero.id
        AND livro.id_editora = editora.id
        AND livro.id_autor = autor.id*/
        
SELECT 
    l.id,
    l.titulo,
    l.data_publicacao,
    l.numero_paginas,
    l.preco,
    l.isbn,
    g.nome AS genero,
    e.nome AS editora,
    a.nome AS autor
FROM
    livro l
        INNER JOIN
    genero g ON l.id_genero = g.id
        INNER JOIN
    editora e ON l.id_editora = e.id
        INNER JOIN
    autor a ON l.id_autor = a.id;

SELECT 
    livro.id,
    livro.titulo,
    livro.data_publicacao,
    livro.numero_paginas,
    livro.preco,
    livro.isbn,
    genero.nome AS genero,
    editora.nome AS editora,
    autor.nome AS autor;