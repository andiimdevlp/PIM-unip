/*
   domingo, 24 de novembro de 201920:43:32
   Usuário: 
   Servidor: DESKTOP-8B1VJMJ\SQLEXPRESS
   Banco de Dados: terracluster
   Aplicativo: 
*/

/* Para impedir possíveis problemas de perda de dados, analise este script detalhadamente antes de executá-lo fora do contexto do designer de banco de dados.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.departamento
	(
	id_departamento int NOT NULL IDENTITY (1, 1),
	abreviacao varchar(5) NOT NULL,
	departamento varchar(30) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.departamento ADD CONSTRAINT
	PK_departamento PRIMARY KEY CLUSTERED 
	(
	id_departamento
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.departamento SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.departamento', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.departamento', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.departamento', 'Object', 'CONTROL') as Contr_Per 