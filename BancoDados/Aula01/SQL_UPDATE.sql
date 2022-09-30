UPDATE pessoa
	SET datanascimento = '1998-02-22',
		idade = 24
WHERE id IN (2, 4, 6)
;

UPDATE pessoa
	SET datanascimento = '1995-05-18',
		idade = 27
WHERE id IN (3, 5, 7)
;