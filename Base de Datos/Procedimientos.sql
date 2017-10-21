use PDVsoft

DELIMITER $$
CREATE PROCEDURE spsegObtenerUsuario(in p_codUsuario varchar(25))
begin
	SELECT codUsuario, nomNombre, desPrimerApellido, desSegundoApellido, codContrasena, desCorreo, desURLImagen
    FROM segUsuario where codUsuario = p_codUsuario;
END
$$ 