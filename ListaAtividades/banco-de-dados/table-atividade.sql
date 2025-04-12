CREATE TABLE atividade (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    situacao INT NOT NULL DEFAULT 0
);

insert into atividade (titulo) values (@titulo);

update atividade set situacao = @situacao where id = @id;

select * from atividade where situacao = 1;

select * from atividade where situacao = 0;




