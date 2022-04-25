------------CREACION DE TABLAS RELACIONALES------------------
CREATE TABLE CUPO(
	idCupo VARCHAR (20) PRIMARY KEY NOT NULL,
	diaCupo date,
	horaCupo time,
);

CREATE TABLE TALLER(
	idTaller int IDENTITY(1,1) PRIMARY KEY,
	nombreTaller VARCHAR (100),
	fechaHoraCupo VARCHAR (20),
	direccionTaller VARCHAR (255),
	constraint tallerCupoFK foreign key (fechaHoraCupo) references CUPO (idCupo),
);

CREATE TABLE MECANICO(
	idMecanico VARCHAR (20) PRIMARY KEY NOT NULL,
	p_nombre VARCHAR (30),
	s_nombre VARCHAR (30),
	p_apellido VARCHAR (30),
	s_apellido VARCHAR (30),
	telefonoMec VARCHAR (30),
	tipoEmpleado VARCHAR (30),
	numGrupoAsignado int,
);

CREATE TABLE ESTADO(
	idEstado int IDENTITY(1,1) PRIMARY KEY,
	tipoEstado VARCHAR (30),
);

CREATE TABLE CLIENTE(
	idCliente VARCHAR (40) PRIMARY KEY NOT NULL,
	p_nombre VARCHAR (30),
	s_nombre VARCHAR (30),
	p_apellido VARCHAR (30),
	s_apellido VARCHAR (30),
	telefonoCel VARCHAR (30),
	telefonoFijo VARCHAR (30),
	direccionCliente VARCHAR (255),
	correoCliente VARCHAR (150) UNIQUE,
);

CREATE TABLE AUTOMOVIL(
	placa VARCHAR (10) PRIMARY KEY NOT NULL,
	idCliente VARCHAR (40),
	marca VARCHAR (30),
	modelo VARCHAR (30),
	numeroMotor VARCHAR (45),
	color VARCHAR (30),
	fechaHoraIngreso datetime,
	tallerAsignado int,
	mecAsignado VARCHAR (20),
	constraint idClienteFK foreign key (idCliente) references CLIENTE (idCliente),
	constraint autoTallerAsigFK foreign key (tallerAsignado) references TALLER (idTaller),
	constraint autoMecAsigFK foreign key (mecAsignado) references MECANICO (idMecanico)
);

CREATE TABLE ASESOR(
	idAsesor VARCHAR (20) PRIMARY KEY NOT NULL,
	p_nombre VARCHAR (30),
	s_nombre VARCHAR (30),
	p_apellido VARCHAR (30),
	s_apellido VARCHAR (30),
	telefonoAsignado VARCHAR (30),
	tipoEmpleado VARCHAR (30),
	grupoMecAsignado VARCHAR (20),
	constraint grupoMecAsignadoFK foreign key (grupoMecAsignado) references MECANICO (idMecanico)	
);

CREATE TABLE TIPO_EMPLEADO(
	idTipoEmpleado INT IDENTITY(1,1) PRIMARY KEY,
	tipoEmpleado VARCHAR (20)
);

CREATE TABLE CITA(
	idCita VARCHAR (20) PRIMARY KEY NOT NULL,
	idCliente VARCHAR (40),
	nombreCliente VARCHAR (40),
	telefonoCel VARCHAR (30),
	placaAutomovil VARCHAR (10),
	tipo_servicio varchar (100),
	fechaIngresoSolicitud datetime,
	posFechaEntrega date,
	estadoServicio int,
	asesorAsignado VARCHAR (20),
	mecanicoAsignado VARCHAR (20),
	cupoCita VARCHAR (20),
	tallerAsignado int,
	constraint citaclienteFK foreign key (nombreCliente) references CLIENTE (idCliente),
	constraint mecaAsigFK foreign key (mecanicoAsignado) references MECANICO (idMecanico),
	constraint aseAsigFK foreign key (asesorAsignado) references ASESOR (idAsesor),
	constraint estadoFK foreign key (estadoServicio) references ESTADO (idEstado),
	constraint cupoCitaFK foreign key (cupoCita) references CUPO (idCupo),
	constraint placaAutoFK foreign key (placaAutomovil) references AUTOMOVIL (placa),
	constraint tallerAsigFK foreign key (tallerAsignado) references TALLER (idTaller)
);
------------RELACIONALES CON TABLA CITA------------
CREATE TABLE CITA_MANTENIMIENTO(
	idCita VARCHAR (20) PRIMARY KEY,
	tipoMantenimiento VARCHAR (50),
	constraint idCitaMantenimientoFK foreign key (idCita) references CITA (idCita)
);

CREATE TABLE CITA_REPARACION(
	idCita VARCHAR (20) PRIMARY KEY,
	tipoReparacion VARCHAR (100),
	constraint idCitaReparacionFK foreign key (idCita) references CITA (idCita)
);

CREATE TABLE ACTUALIZAR_CITA(
	idCita VARCHAR (20) PRIMARY KEY,
	idCliente VARCHAR (40),
	nombreCliente VARCHAR (40),
	telefonoCel VARCHAR (30),
	placaAutomovil VARCHAR (10),
	tipo_servicio varchar (100),
	fechaIngresoSolicitud datetime,
	posFechaEntrega date,
	estadoServicio int,
	asesorAsignado VARCHAR (20),
	mecanicoAsignado VARCHAR (20),
	cupoCita VARCHAR (20),
	tallerAsignado int
);
------INSERTANDO REGISTROS EN LAS TABLAS POR DEFECTO------------
INSERT INTO MECANICO(idMecanico,p_nombre, s_nombre, p_apellido, s_apellido, telefonoMec, tipoEmpleado, numGrupoAsignado)
VALUES ('Mec1','Marvin','Fernando','Oliva','Perez','6576-8797','Mecanico General',1),
('Mec2','Marlon','Miguel','Maldonado','Morales','9292-3333','Mecanico Mantenimiento', 2),
('Mec3','Victor','Alejandro','Escalante','Zuniga','5675-7657','Mecanico General', 1),
('Mec4','Lucas','Manuel','Indigo','Garcia','2457-9823','Mecanico Mantenimiento', 2),
('Mec5','Juan','Fernando','Perez','Ramirez','4567-9123','Mecanico a Domicilio', 3);

INSERT INTO ASESOR (idAsesor, p_nombre, s_nombre, p_apellido, s_apellido, telefonoAsignado, tipoEmpleado, grupoMecAsignado)
VALUES ('Ase1', 'Oscar','Armando','Perez','Sanchez','9999-9999','Asesor', 'Mec1'),
('Ase2', 'Wilmer','Javier','Castro','Hernandez','7654-7654','Asesor','Mec1'),
('Ase3', 'Enrique','Antonio','Zuniga','Morales','1234-4321','Asesor', 'Mec2'),
('Ase4', 'Moises','Alexis','Miranda','Rosales','8888-1234','Asesor', 'Mec3'),
('Ase5', 'Luck','Ernesto','Diaz','Andino','3333-1234','Asesor', 'Mec2');

INSERT INTO CUPO(idCupo)
VALUES ('Lun1'),('Lun2'),('Lun3'),('Lun4'),('Lun5'),('Lun6'),('Lun7'),('Lun8'),('Lun9'),
('Mar1'),('Mar2'),('Mar3'),('Mar4'),('Mar5'),('Mar6'),('Mar7'),('Mar8'),('Mar9'),
('Mie1'),('Mie2'),('Mie3'),('Mie4'),('Mie5'),('Mie6'),('Mie7'),('Mie8'),('Mie9'),
('Jue1'),('Jue2'),('Jue3'),('Jue4'),('Jue5'),('Jue6'),('Jue7'),('Jue8'),('Jue9'),
('Vie1'),('Vie2'),('Vie3'),('Vie4'),('Vie5'),('Vie6'),('Vie7'),('Vie8'),('Vie9'),
('Sab1'),('Sab2'),('Sab3'),('Sab4'),('Sab5'),('Sab6'),('Sab7'),('Sab8'),('Sab9');

INSERT INTO TALLER(nombreTaller,direccionTaller)
VALUES ('AUTO FIX','Aldea las Crucitas, Tegucigalpa, Honduras'),
('Refacciones y Mas SRL','Colonia Kennedy, Calle Principal'),
('Taller Morales','Colonia El Carrizal, Cerca de Mall Premier');

INSERT INTO CLIENTE (idCliente, p_nombre, s_nombre, p_apellido, s_apellido, telefonoCel, telefonoFijo, direccionCliente, correoCliente)
VALUES ('CL-01', 'Carlos','Rafael','Cano','Escoto','9999-9999','2222-2222','Tegucigalpa, Colonia Kennedy, Calle Principal, Casa #1','asd.123@unah.com'),
('CL-02', 'Omar','Chico','Gonzales','Robin','8888-8888','1111-1111','Tegucigalpa, Colonia 21 de Septiembre, Calle Principal, Casa #5','dsa.321@unah.com'),
('CL-03', 'Alex','Mark','irias','Canales','5555-5555','3333-3333','Tegucigalpa, Colonia Hato, Calle Secundaria, Casa #21','alex.irias@unah.com'),
('CL-04', 'Jere','Joel','Andino','Lagos','6666-6666','4444-4444','Tegucigalpa, Colonia Mateo, Calle Principal, Casa #4','jere.joel@unah.com'),
('CL-05', 'Gabi','Natalia','Diaz','Perez','7777-7777','2233-2233','Tegucigalpa, Colonia La Profesia, Quinta Calle, Casa #15','asd.124@unah.com');

INSERT INTO ESTADO(tipoEstado)
VALUES ('NO_INGRESADO'),
('INGRESADO'),
('EN REPARACION'),
('PENDIENTE_DE_RESPUESTOS'),
('LISTO'),
('AUTO_RETIRADO'),
('CANCELADA');

INSERT INTO AUTOMOVIL(placa, marca, modelo, numeroMotor, color, fechaHoraIngreso)
VALUES ('HAJ-5050','Mitsubishi','Lancer','HTY67FTY856','Azul','2022-01-01'),
('HLA-5959','Toyota','Corolla','TM9FU8RT67DT','Verde','2022-01-06'), 
('HKO-5678','Honda','CRV','HJUYWER674GT','Cafe','2022-02-01'),
('HPJ-9876','Hyundai','Elantra','MK9LJ8TF5DE3','Azul','2022-01-01'),
('HPS-0456','Kia','Picanto','BN56GFT76TYJ','Gris','2021-12-01'),
('HKL-6789','Yamaha','DT-250','ER67HJK789L7','Azul','2019-01-01');

INSERT INTO CITA(idCita, idCliente,telefonoCel,tipo_servicio,fechaIngresoSolicitud, posFechaEntrega)
VALUES ('C1','CL-01','9898-9898','Mantenimiento','2022-01-02','2022-02-02'),
('C2','CL-03','9898-9898','Mantenimiento','2022-03-06','2022-04-04'),
('C3','CL-04','9687-2343','Reparacion','2019-01-05','2019-06-09'),
('C4','CL-01','2134-4563','Reparacion','2021-12-02','2022-02-02'),
('C5','CL-05','3467-1245','Mantenimiento','2020-11-03','2021-02-04'),
('C6','CL-02','2345-7654','Reparacion','2022-03-09','2022-04-12');

INSERT INTO CITA_MANTENIMIENTO(idCita,tipoMantenimiento)
VALUES('C1',5000),
('C2',10000),
('C3',15000),
('C4',20000),
('C5',25000);

INSERT INTO CITA_REPARACION(idCita,tipoReparacion)
VALUES('C1','Fallo del motor de arranque'),
('C2','Fallo en el tren delantero'),
('C3','Ruido cerca del motor'),
('C4','OVER ALL'),
('C5','CAMBIO DE MOTOR');

----PROCEDIMIENTO ALMACENADO DE CREAR CLIENTE--------
GO
CREATE PROCEDURE sp_CrearCliente
	@idCliente VARCHAR (40),
	@pNombre VARCHAR (30),
	@sNombre VARCHAR (30),
	@pApellido VARCHAR (30),
	@sApellido VARCHAR (30),
	@telCel VARCHAR (30),
	@telFijo VARCHAR (30),
	@direccion VARCHAR (255),
	@correo VARCHAR (150)
AS
BEGIN
	INSERT INTO CLIENTE VALUES (@idCliente,
	@pNombre,
	@sNombre,
	@pApellido,
	@sApellido,
	@telCel,
	@telFijo,
	@direccion,
	@correo)
END
GO

----PROCEDIMIENTO ALMACENADO DE ACTUALIZAR CLIENTE--------
GO
CREATE PROCEDURE sp_ActualizarCliente
	@idCliente VARCHAR (40),
	@pNombre VARCHAR (30),
	@sNombre VARCHAR (30),
	@pApellido VARCHAR (30),
	@sApellido VARCHAR (30),
	@telCel VARCHAR (30),
	@telFijo VARCHAR (30),
	@direccion VARCHAR (255),
	@correo VARCHAR (150)
AS
BEGIN
	UPDATE CLIENTE SET idCliente=@idCliente,
	p_nombre=@pNombre,
	s_nombre=@sNombre,
	p_Apellido=@pApellido,
	s_Apellido=@sApellido,
	telefonoCel=@telCel,
	telefonoFijo=@telFijo,
	direccionCliente=@direccion,
	correoCliente=@correo
	WHERE idCliente=@idCliente;
END
GO

----PROCEDIMIENTO ALMACENADO DE BORRAR CLIENTE--------
GO
CREATE PROCEDURE sp_BorrarCliente
	@idCliente VARCHAR (40)
AS
BEGIN
	DELETE FROM CLIENTE WHERE idCliente=@idCliente;
END
GO

----PROCEDIMIENTO ALMACENADO DE CANTIDAD DE CITAS POR CLIENTE--------
GO
CREATE PROCEDURE sp_CitasCliente
		@idCliente VARCHAR (40)
AS
BEGIN
	SELECT idCliente, p_nombre, s_nombre, p_Apellido, s_apellido 
	FROM CLIENTE 
	WHERE @idCliente
	IN 
	(SELECT cita.idCliente 
	FROM CITA 
	GROUP BY cita.idCliente HAVING COUNT (DISTINCT (idCita ))>=1  ) ;
END
GO

----PROCEDIMIENTO ALMACENADO DE NOMBRE COMPLETO CLIENTE--------
GO
CREATE PROCEDURE sp_NombreCliente
	 @idCliente VARCHAR (40)
 AS
 BEGIN
		select p_nombre + ' ' + s_nombre +' '+ p_apellido +' '+ s_apellido as nombre_completo
		from CLIENTE
		where @idCliente = idCliente;
  END
 GO
 
---------VISTA DE NOMBRE COMPLETO DEL CLIENTE-------
go
CREATE VIEW v_NombreCompletoCliente 
AS SELECT CONCAT_WS (' ', P_nombre, S_nombre, P_apellido, S_apellido) as nombre_completo FROM CLIENTE ;
go

-------------- VISTA PARA LAS CITAS ------------------
GO
CREATE VIEW v_Cita
AS SELECT idCita,idCliente,nombreCliente,telefonoCel,
			placaAutomovil,tipo_servicio,fechaIngresoSolicitud,
			posFechaEntrega, estadoServicio,asesorAsignado,
			mecanicoAsignado,cupoCita, tallerAsignado 
FROM CITA;
GO

-------------- VISTA PARA EMPLEADOS ASESOR Y MECANICO ---------------
GO
CREATE VIEW v_EmpleadoAsesor
AS SELECT idAsesor,CONCAT_WS (' ', P_nombre, S_nombre, P_apellido, S_apellido) as nombre_completo,
		telefonoAsignado,tipoEmpleado,grupoMecAsignado FROM ASESOR;
GO

GO
CREATE VIEW v_EmpleadoMecanico
AS SELECT idMecanico,CONCAT_WS (' ', P_nombre, S_nombre, P_apellido, S_apellido) as nombre_completo,
		telefonoMec,tipoEmpleado,numGrupoAsignado FROM MECANICO;
GO

---------------  VISTA PARA LOS AUTOMOVILES -----------------
GO
CREATE VIEW v_Automovil
AS SELECT  placa,idCliente, marca, modelo, numeroMotor, color,fechaHoraIngreso,tallerAsignado, mecAsignado FROM AUTOMOVIL;
GO

--------PRUEBAS DE PROCEDIMIENTOS ALMACENADOS Y VISTAS-------------
EXEC sp_CrearCliente 'CL-06', 'yonis','estay','combi','soler','0000-9999','1111-2222','COPAN','FRG.123@unah.com';

EXEC sp_ActualizarCliente 'CL-06', 'roman','luis','combi','soler','0000-9999','1111-2222','COPAN','FRG.123@unah.com';

EXEC sp_BorrarCliente 'CL-06';

exec sp_NombreCliente'CL-01';

exec sp_CitasCliente 'CL-06';

SELECT * FROM v_NombreCompletoCliente

SELECT * FROM v_Cita



--------------AVANZAR EN FUNCIONES Y TRIGERS FUNCION DE ACTUALIZAR CITAS------
/*
GO
CREATE FUNCTION actualizarTriggerCita () RETURNS VARCHAR AS DECLARE BEGIN
INSERT INTO ACTUALIZAR_CITA VALUES (idCita, NEW.idCliente);
RETURN NULL; END $$;
GO

USE [001-Prueba_Proyecto]
GO
CREATE TRIGGER trgActualizarCitas AFTER UPDATE on CITA
FOR EACH ROW
BEGIN
	INSERT INTO ACTUALIZAR_CITA VALUES (new.idCita,
	NEW.nombre, OLD
	)
END;
GO

   create trigger NOMBREDISPARADOR
  on NOMBRETABLA
  for EVENTO- insert, update o delete
 as 
  SENTENCIAS

GO
CREATE FUNCTION trgActualizarCitas () RETURNS VARCHAR (40) 
	AS 
		BEGIN 
			DECLARE @nCita varchar (40)
			RAISE NOTICE  'función disparadora, acción = %, sobre fila gid = %', TG_OP, NEW.gid;
			INSERT INTO actualizarCita VALUES (new.idCita, new.idCliente, new.telefonoCel,new.tipo_servicio,new.fechaIngresoSolicitud, new.posFechaEntrega);
			RETURN NULL;
		END
RETURN @nCita;
GO
------------CREAR TRIGGER PARA CITAS----------
GO
CREATE TRIGGER cita_actualizada 
AFTER UPDATE ON CITA
FOR EACH ROW 
EXECUTE PROCEDURE tgrActualizarCitas();
GO
*/


