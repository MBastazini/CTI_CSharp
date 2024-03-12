SELECT aparelho.*, fabricante.* FROM aparelho INNER JOIN fabricante ON aparelho.id_fabricante = fabricante.id_fabricante
WHERE UPPER(aparelho.modelo) LIKE '%SAMSUNG%'
ORDER BY aparelho.preco