CREATE DATABASE ProcessoSeletivo2RP;
GO

USE  ProcessoSeletivo2RP;
GO

CREATE TABLE TiposUsuarios(
IdTipoUsuario INT PRIMARY KEY IDENTITY (1,1),
TituloTipoUsuario VARCHAR(30) UNIQUE NOT NULL
);
GO

CREATE TABLE Usuarios(
IdUsuarios INT PRIMARY KEY IDENTITY (1,1),
IdTipoUsuario INT FOREIGN KEY REFERENCES TiposUsuarios(IdTipoUsuario),
Nome VARCHAR(50) NOT NULL,
Email VARCHAR(100) UNIQUE  NOT NULL,
Senha VARCHAR(50) NOT NULL,
Situacao BIT NOT NULL
);
GO