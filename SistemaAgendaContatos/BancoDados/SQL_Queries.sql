select * from contatos;
select * from compromissos;
delete from contatos where id = 1;

SELECT c.ID, c.Nome, c.Telefone, c.Celular, c.Email, c.Rua, c.Numero, c.Bairro, c.Cidade, c.UF, com.Titulo, com.dataini as Data_Inicio, com.datafim as Data_Fim
FROM contatos c
INNER JOIN compromissos com ON c.id = com.id_contatos
;

SELECT (c.nome) FROM contatos c INNER JOIN compromissos com ON c.id = com.id_contatos;
/*(c.id, c.nome, c.telefone, c.celular, c.email, c.rua, c.numero, c.bairro, c.cidade, c.uf, com.titulo, com.dataini, com.datafim)*/

UPDATE contatos nome SET nome = 'Gustavoooo' where id = 2;