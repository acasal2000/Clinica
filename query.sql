create database clinica;
use clinica;

create table departamentos(
	codDepartamento int primary key identity(1, 1),
	nomeDepartamento varchar(255) not null
);

alter table departamentos add abreviaturaDep varchar(max);

select * from departamentos;

create table funcionarios(
	codFunc int primary key identity(1,1),
	nome varchar(max) not null,
	cartaoCidadao int not null,
	dataNasc date not null,
	morada varchar(max) not null,
	localidade varchar(max) not null,
	telefone int not null,
	email varchar(max),
	vencimentoBase money,
	tipoContrato varchar(max) not null,
	limiteContrato date,
);

select * from funcionarios;

create table FuncDepartamentos(
	codFuncDep int primary key identity(1, 1),
	codFunc int foreign key references funcionarios(codFunc),
	codDepartamento int foreign key references departamentos(codDepartamento)
);

create table clientes(
	codCliente int primary key identity(1,1),
	nome varchar(max) not null,
	cartaoCidadao int not null,
	dataNasc date not null,
	morada varchar(max) not null,
	localidade varchar(max) not null,
	telefone int not null,
	email varchar(max),
);

select * from clientes;

create table consultas(
	codConsulta int primary key identity(1, 1),
	codFunc int foreign key references funcionarios(codFunc),
	codCliente int foreign key references clientes(codCliente),
	dataConsula date not null,
	obs varchar(max) not null,
	custo money,
);

select * from consultas;

insert into consultas(codFunc, codCliente, dataConsula, obs, custo) values
(1, 2, '2000-10-10', 'asdasda', 10);

delete from consultas;

select consultas.codConsulta AS [Cod. Consulta], consultas.codFunc AS [Cod. Médico], consultas.codCliente AS [Cod. Cliente], 
    funcionarios.nome AS [Nome do Médico], funcionarios.telefone AS [Telefone do Médico], funcionarios.email AS [Email do Médico], 
	clientes.cartaoCidadao [C.C. do Utente], clientes.nome as [Nome do Utente], clientes.telefone AS [Telefone do Utente], clientes.email AS [Email do Utente]  from consultas inner join funcionarios on consultas.codFunc = funcionarios.codFunc
		inner join clientes on consultas.codCliente = clientes.codCliente;

select funcionarios.codFunc from funcionarios where funcionarios.codFunc not in(select FuncDepartamentos.codFunc from FuncDepartamentos);