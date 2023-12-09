IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'ds8-parcial2')
BEGIN
	CREATE DATABASE [ds8-parcial2]
END
GO
    USE [ds8-parcial2]
GO

USE [ds8-parcial2]
GO

DROP TABLE IF EXISTS [Estudiantes];

CREATE TABLE [Estudiantes] (
	Id BIGINT IDENTITY PRIMARY KEY,
	Cedula VARCHAR(250) NOT NULL,
	Nombre VARCHAR(250) NOT NULL,
	Apellido VARCHAR(250) NOT NULL,
	Parcial1 INT NOT NULL,
	Parcial2 INT NOT NULL,
	Parcial3 INT NOT NULL,
	ExamenFinal INT NOT NULL,
	UNIQUE(Cedula)
);