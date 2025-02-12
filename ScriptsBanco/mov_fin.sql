/*
   domingo, 24 de novembro de 201920:37:53
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
CREATE TABLE dbo.mov_fin
	(
	id_financeiro int NOT NULL IDENTITY (1, 1),
	id_depart int NOT NULL,
	id_gasto int NOT NULL,
	valor_financeiro decimal(7, 2) NOT NULL,
	data_baixa date NULL,
	comentario text,
	placa varchar(10) NOT NULL,
	CONSTRAINT fk_id_depart FOREIGN KEY (id_depart) REFERENCES departamento(id_departamento),
	CONSTRAINT fk_gasto FOREIGN KEY (id_gasto) REFERENCES nat_gasto(id_gasto),
	D_E_L_E_T_E_ char(2),
	constraint UC_movi_fin unique (id_gasto, valor_financeiro,id_depart, placa ) 
	
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.mov_fin ADD CONSTRAINT
	PK_mov_fin PRIMARY KEY CLUSTERED 
	(
	id_financeiro
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.mov_fin SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.mov_fin', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.mov_fin', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.mov_fin', 'Object', 'CONTROL') as Contr_Per 