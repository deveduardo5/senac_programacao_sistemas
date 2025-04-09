CREATE TABLE IF NOT EXISTS usuario (
ind INT PRIMARY KEY AUTO_INCREMENT,
email VARCHAR (50) NOT NULL UNIQUE,
senha VARCHAR (20) NOT NULL
);

INSERT INTO usuario (email, senha) VALUES
('neymar.jr@email.com','Brun@123'),
('pablo.vitar@email.com','12345Abc!'),
('sukuna.itadori@email.com','Sete7sete!');
 
-- SELECT
SELECT * FROM usuario WHERE email = 'pablo.vitar@email.com';