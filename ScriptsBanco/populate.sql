insert into mov_fin values 
('19.45','20191009','20191203',GETDATE(), (select descricao from nat_gasto where id_gasto= '872'))

select * from mov_fin

insert into nat_gasto values 
('187','Abastecimento')
,('338','Garagem')
,('252','Manutenção')
,('872','Multa')
,('121','Pedagio')
,('190','Sinistro')

select  * from nat_gasto

--Populanto departamentos
insert into departamento values
('COM','Comercial')
,('CONT','Contabilidade')
,('DP','Departamento Pessoal')
,('DIR','Diretoria')
,('FIN','Financeiro')
,('JUR','Juridico')
,('LOG','Logistica')
,('RH','Recuros Humano')
,('TI','TI')
,('ALL','Todos')

select * from departamento

--Populando veiculos
insert into veiculo values
('JBW8216','Passeio','Vermelho','1993','3420755920','Honda','')
,('IAH8249','Passeio','Preto','2001','89338666950','Fiat','')
,('HTV5326','Passageiros','Branco','1998','18201122378','Mercedes-Benz','')
,('HOO3762','Passageiros','Bege','1997','65118839513','Mercedes-Benz','')
,('GIT3912','Caminhão','Prata','1994','95401251396','Volvo','')
,('HTG8120','Caminhão','Prata','1998','22390235181','Volvo','')

CREATE PROC InserirCarro
@placa varchar(10),
@modelo varchar(20),
@cor varchar(10),
@ano date,
@renavam varchar(30),
@marca varchar(50)
as
insert into veiculo values (@placa, @modelo, @cor, @ano, @renavam, @marca, '')
go

CREATE PROC ExcluirCarro
@placa varchar(10),
@renavam varchar(30)
as
update veiculo set D_E_L_E_T_E_ = '*' where placa = '' and renavam = ''

go


exec InserirCarro --'HTG8120','Caminhão','Prata','1998','22390235181','Volvo'

CREATE PROC MostrarCarro
as
select marca as MARCA, placa as PLACA, cor as COR, ano as ANO, renavam as RENAVAM, modelo as MODELO from veiculo where D_E_L_E_T_E_<>'*'
go

exec MostrarCarro

insert into usuario values
('anderson.nascimento',HASHBYTES('sha1','anderson'),'andersons13213@gmail.com','anderson carneiro dos santos nascimento','ADM')
,('paulo.jach',HASHBYTES('sha1','paulojach'),'paulojch@gmail.com','paulo sergio jach','ADM')
,('edivan.costa',HASHBYTES('sha1','edmohamed'),'costa.santos@gmail.com','edivan dos santos costa','ADM')

select * from usuario

--Tabela de movimento financeiro
CREATE PROC MostrarFin
as
select id_financeiro NUM,
nat.id_gasto NATUREZA,
abreviacao DEPARTAMENTO,
placa PLACA,
valor_financeiro VALOR,
data_baixa PAGAMENTO,
comentario MEMO
from mov_fin fin
left join nat_gasto nat on nat.id_gasto = fin.id_gasto
left join departamento dep on id_departamento = id_depart 
where 
fin.D_E_L_E_T_E_<>'*'
go


exec  MostrarFin



select * from mov_fin

CREATE PROC InserirFinan
@id_gasto int,
@id_depart int,
@valor_financeiro float,
@comentario text,
@placa varchar(10)
as 
insert into mov_fin values (@id_gasto, @id_depart, @valor_financeiro,'',@comentario, @placa,'' )
go

exec InserirFinan 

