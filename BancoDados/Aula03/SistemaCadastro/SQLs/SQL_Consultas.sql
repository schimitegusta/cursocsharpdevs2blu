select *
from convenio;

select *
from pessoa;

select *
from paciente;

select *
from endereco;

select *
from pessoa p
join endereco e
	on p.id = e.id_pessoa
;