select *
from convenio;

select *
from pessoa;

delete from pessoa where id = 16;

select *
from paciente;

delete from paciente where id = 7;

select *
from endereco;

delete from endereco where id = 15;

select *
from pessoa p
join endereco e
	on p.id = e.id_pessoa
;