CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    usuario;
    
insert into usuario (
nome,
email,
senha
)
values (
'Eduardo',
'edu.al@email.com',
'edu@123'
);

insert into usuario (nome, email, senha)
values 
	('Neymar Jr','nj@email.com','Brun@'),
    ('Maria Madalena','mmadalena@email.com','a1s2d3f4'),
    ('Pablo Vitar','p.vitar@email.com','senh@fort3'),
    ('Yuri Alberto','protagonista@email.com','@lenda');