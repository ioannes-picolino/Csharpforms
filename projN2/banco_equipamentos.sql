/*create database projN2*/

use projN2

create table marcas ( cod_marca integer identity(1,1)  primary key,
                      descricao_marca varchar(100))

create table descricoes_equip ( cod_desc_equip integer identity(1,1)  primary key,
                                descricao_equip varchar(100))

create table locais ( cod_locais integer identity(1,1)  primary key,
                      numero_local integer,
                      descricao_local varchar(100),
					  bloco integer)

create table equipamento ( cod_equip integer identity(1,1) primary key,
                           cod_marca integer foreign key references marcas,
						   serial_number varchar(100) not null,
						   cod_desc_equip integer foreign key references descricoes_equip,
                           disponivel varchar(100) default 'sim',
						   sap_codigo integer,
						   ativo_cefsa integer,
						   cod_locais integer foreign key references locais,
						   armario integer)

create table verificacao_equip (cod_equip integer references equipamento(cod_equip),
                                data_verificacao datetime,
								primary key (cod_equip, data_verificacao),
								observacoes varchar(100));

create table categorias_usuarios (cod_categoria integer identity (1,1) primary key,
                                  descricao_categoria varchar(100))

create table caixas_ferramentas (cod_caixa_ferramenta integer identity (1,1) primary key,
                                  descricao varchar(100),
								  volume varchar(100))

create table status_ (cod_status integer identity (1,1) primary key,
                      descricao_status varchar(100))

create table usuarios (cod_usuario integer identity(1,1)  primary key,
                       cod_categoria integer foreign key references categorias_usuarios,
                       nome varchar(100),
					   email varchar(100),
					   senha varchar(100),
					   curso varchar(100))

create table manutencoes (cod_manutencoes integer identity(1,1)  primary key,
                       cod_equip integer foreign key references equipamento,
                       cod_usuario integer foreign key references usuarios,
					   descricao_falha varchar(100),
					   data_abertura datetime,
					   data_fechamento datetime,
					   observacoes varchar(100),
					   aprovador varchar(100),
					   valido varchar(100))

create table ferramentas (cod_ferramenta integer identity (1,1) primary key,
                          descricao_ferramenta varchar(100),
						  quantidade integer,
						  cod_locais integer foreign key references locais,
						  armario integer)
create table emprestimo_caixa_ferramentas (cod_emp_caixa_ferramentas integer identity (1,1) primary key,
                                           cod_usuario integer foreign key references usuarios,
										   autorizacao varchar (100),
										   data_emprestimo datetime,
										   data_previsao_devolucao datetime,
										   data_devolucao datetime,
										   cod_caixa_ferramenta integer foreign key references caixas_ferramentas)

create table emprestimo_ferramentas (cod_emp_ferramentas integer identity (1,1) primary key,
                                     cod_emp_caixa_ferramentas integer foreign key references emprestimo_caixa_ferramentas,
									 cod_ferramenta integer foreign key references ferramentas,
									 quantidade integer)


create table emprestimo_equip (cod_emprestimo integer identity (1,1) primary key,
                               cod_equip integer foreign key references equipamento,
							   cod_usuario integer foreign key references usuarios,
							   autorizacao varchar(100),
							   data_emprestimo datetime,
							   data_previsao_devolucao datetime,
							   data_devolucao datetime,
							   cod_emp_ferramentas integer foreign key references emprestimo_caixa_ferramentas,
							   motivo varchar (100),
							   cod_status integer foreign key references status_)

insert into marcas ( descricao_marca) values ('Minipa');

insert into descricoes_equip( descricao_equip) values ('Multímetro digital ET-2053 DMM');

insert into descricoes_equip( descricao_equip) values ('Multímetro digital ET-2042C');

insert into descricoes_equip( descricao_equip) values ('Multímetro digital ET-2082C');

insert into locais( numero_local, descricao_local, bloco) values (66, 'Laboratório de Eletrônica', 9);

insert into locais( numero_local, descricao_local, bloco) values (71, 'Laboratório CIM', 9);

insert into categorias_usuarios (descricao_categoria) values('ADM Mestre');

insert into usuarios(cod_categoria, nome, curso) values (1,'Ivan','EC5');

/*select * from usuarios inner join categorias_usuarios on categorias_usuarios.cod_categoria=usuarios.cod_categoria

select cod_equip from equipamento where serial_number=''

select serial_number from equipamento

select*from manutencoes

select*from equipamento

select* from verificacao_equip

INSERT INTO manutencoes (cod_equip, cod_usuario, descricao_falha, data_abertura, data_fechamento, observacoes, aprovador, valido) VALUES ((select cod_equip from equipamento where serial_number='6465664'),1,'teste',23-11-2023,23-11-2023,'teste','Ivan','Sim')*/

