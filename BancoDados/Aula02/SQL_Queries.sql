CREATE DATABASE sistemacadastros;

SELECT id,
		nome,
        cgccpf,
        tipo_pessoa
FROM pessoa
;

SELECT id,
		id_pessoa,
        convenio
FROM paciente
;

SELECT id,
		id_pessoa,
		crm,
        especialidade,
        setor,
        tipo_fornecedor,
        tipo_prestador
FROM prestador
;

/*EXIBIR PACIENTES*/
SELECT p.id as codigo_pessoa,
		pa.id as codigo_paciente,
		p.nome,
        pa.convenio
FROM pessoa as p
JOIN paciente as pa
	ON (p.id = pa.id_pessoa)
;

/*EXIBIR PRESTADORES*/
SELECT p.id as codigo_pessoa,
		pre.id as codigo_prestador,
		p.nome,
        p.tipo_pessoa,
        pre.crm,
        pre.especialidade,
        pre.setor,
        pre.tipo_fornecedor,
        pre.tipo_prestador
FROM pessoa as p
JOIN prestador as pre
	ON (p.id = pre.id_pessoa)
;

/*PESSOAS, PRESTADORES E PACIENTES JUNTOS*/
select p.id as codigo_pessoa,
        p.nome,
        p.cgccpf,
        p.tipo_pessoa,
        pa.convenio,
        '' as crm,
        '' as especialidade,
        '' as setor,
        '' as tipo_prestador,
        '' as tipo_fornecedor
from pessoa as p
join paciente as pa
on (p.id = pa.id_pessoa)
union
select p.id as codigo_pessoa,
        p.nome,
        p.cgccpf,
        p.tipo_pessoa,
        '' as convenio,
        pre.crm,
        pre.especialidade,
        pre.setor,
        pre.tipo_prestador,
        pre.tipo_fornecedor
from pessoa as p
join prestador as pre
on (p.id = pre.id_pessoa)
;