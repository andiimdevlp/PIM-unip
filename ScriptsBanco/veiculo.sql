/*
   domingo, 24 de novembro de 201921:35:03
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
CREATE TABLE dbo.veiculo
	(
	placa varchar(10) NOT NULL,
	modelo varchar(20) NOT NULL,
	cor varchar(10) NOT NULL,
	ano date NOT NULL,
	renavam varchar(30) NOT NULL,
	marca varchar(50) NOT NULL,
	D_E_L_E_T_E_ char(2),
	constraint UC_veiculo unique (placa, renavam) 
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.veiculo ADD CONSTRAINT
	PK_veiculo PRIMARY KEY CLUSTERED 
	(
	id_veiculo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.veiculo SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.veiculo', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.veiculo', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.veiculo', 'Object', 'CONTROL') as Contr_Per 