select id,
		nome,
		datanascimento,
        idade,
        status
from pessoa
/*order by nome asc
asc ascendente
desc decrescente*/
;

select id,
		id_pessoa,
		login,
        senha,
        status
from usuario
;

SELECT p.id as codigo_pessoa,
		u.id as codigo_usuario,
		p.nome,
        p.datanascimento as nascimento,
        p.idade,
        p.status as situacao_pessoa,
        u.login,
        u.senha,
        u.status as status_usuario
FROM pessoa as p
JOIN usuario as u
	ON (p.id = u.id_pessoa)
;

SELECT *
FROM pessoa
WHERE datanascimento < '1998-01-01'
;