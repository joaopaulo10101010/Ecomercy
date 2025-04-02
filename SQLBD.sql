create database bdEcommerce;
use bdEcommerce;

create table Usuario(
	Id int primary key auto_increment,
    Nome varchar(50) not null,
    Email varchar(50) not null,
    Senha varchar(50) not null
);

Create table Cliente(
	CodCli int primary key auto_increment,
    NomeCli varchar(50) not null,
    TelCli varchar(20) not null,
    EmailCli varchar(50) not null
);


Select * from Usuario;
Select * from Cliente;

