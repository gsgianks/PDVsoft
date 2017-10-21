create database PDVsoft;

use PDVsoft;

create table segUsuario(
codUsuario varchar(25) primary key,
nomNombre varchar(30),
desPrimerApellido varchar(25),
desSegundoApellido varchar(25),
codContrasena varchar(30),
desCorreo varchar(50),
desURLImagen varchar(100)
);

create table segModulo(
cocModulo varchar(5),
desNombre varchar(20),
desColor varchar(6)
);

create table segOpcion(
codOpcion varchar(20),
desOpcion varchar(20)
);


-- Usuarios para Prueba
INSERT INTO segUsuario(codUsuario, nomNombre, desPrimerApellido, desSegundoApellido, codContrasena, desCorreo, desURLImagen)  VALUES('ggamboa','GianCarlos', 'Gamboa', 'Salazar', 'gsgianks', 'gsgiank@gmail.com', 'URL');
INSERT INTO segUsuario(codUsuario, nomNombre, desPrimerApellido, desSegundoApellido, codContrasena, desCorreo, desURLImagen)  VALUES('rVelasquez','Rolando', 'Velasquez', 'Salas', 'Temporal123', 'velasquez@gmail.com', 'URL');

-- Procedimiento para prueba
DELIMITER $$
create procedure spObtenerUsuario()
begin
	SELECT * FROM segUsuario;
end
$$ 
drop procedure spInsertarUsuario

DELIMITER $$
create procedure spInsertarUsuario(in p_codUsuario varchar(25),in p_nomNombre varchar(30),
in p_desPrimerApellido varchar(25),
in p_desSegundoApellido varchar(25),
in p_codContrasena varchar(30),
in p_desCorreo varchar(50),
in p_desURLImagen varchar(100))
begin
	INSERT INTO segUsuario (codUsuario, nomNombre, desPrimerApellido, desSegundoApellido, codContrasena, desCorreo, desURLImagen) VALUES(p_codUsuario,p_nomNombre, p_desPrimerApellido, p_desSegundoApellido, p_codContrasena, p_desCorreo, p_desURLImagen);
end
$$ 

call spObtenerUsuario