create database dbExemploModular;

use dbExemploModular;

create table tbUsuario(
 IdUsu int primary key auto_increment,
 NomeUsu Varchar(50) not null,
 Cargo Varchar(50) not null,
 DataNasc date
);

Insert into tbUsuario(NomeUsu,Cargo,DataNasc)
Values('Bob','Monstrorista','2019/04/16'),
('Maria','171','2019/04/16');

Select * from tbUsuario;

