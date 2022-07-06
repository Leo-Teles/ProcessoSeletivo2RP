USE ProcessoSeletivo2RP;
GO

INSERT INTO TiposUsuarios (TituloTipoUsuario)
VALUES					('Administrador'),
                        ('Root'),
						('Comum');
GO

INSERT INTO Usuarios (IdTipoUsuario, Nome, Email, Senha, Situacao)
VALUES				(1, 'Administrador', 'admin@email.com', 'adimin123',1),
					(2, 'Root', 'root@email.com', 'root123',1),
					(3, 'Comum', 'comum@email.com', 'comum123', 1);
GO