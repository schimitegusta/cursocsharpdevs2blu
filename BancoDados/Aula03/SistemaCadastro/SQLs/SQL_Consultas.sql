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

SELECT p.*,
		pa.numero_prontuario,
		pa.paciente_risco,
        c.nome,
        e.CEP,
        e.rua,
        e.numero,
        e.bairro,
        e.cidade,
        e.uf
FROM pessoa p 
INNER JOIN endereco e ON p.id = e.id_pessoa
INNER JOIN paciente pa ON p.id = pa.id_pessoa
INNER JOIN convenio c ON pa.id_convenio = c.id && p.id = pa.id_pessoa;

/*select p.id,
        p.nome,
        p.cgccpf,
        p.tipopessoa,
        p.flstatus,
        e.CEP,
        e.rua,
        e.numero,
        e.bairro,
        e.cidade,
        e.uf,
        '' as Convenio,
        '' as NumeroProntuario,
        '' as PacienteRisco
from pessoa as p
join endereco as e
	on (p.id = e.id_pessoa)
union
select '' as ID,
		'' as Nome,
        '' as CGCCPF,
        '' as TipoPessoa,
        '' as FlStatus,
        '' as CEP,
        '' as Rua,
        '' as Numero,
        '' as Bairro,
        '' as Cidade,
        '' as UF,
        con.nome,
		pa.numero_prontuario,
        pa.paciente_risco
from paciente as pa
join convenio as con
	on (pa.id_convenio = con.id)
;*/