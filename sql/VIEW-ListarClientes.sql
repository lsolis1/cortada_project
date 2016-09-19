create view ListarClientes as
select c.* , ciu.Nombre as NombreCiudad
from Clientes c
LEFT JOIN Ciudades ciu on c.Cod_Postal=ciu.Cod_Postal