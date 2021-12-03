create database TercerParcial;

use TercerParcial
--a
create table Banco(Nit nvarchar(15) primary key, Nombre nvarchar(25));
--b
create table Servicios(Codigo nvarchar(15) primary key, Tipo nvarchar(30), Valor nvarchar(15));
--c
create table Factura(NumeroFactura nvarchar(15) primary key, identificacion nvarchar(15), CodigoServicio nvarchar(15), Valor nvarchar(15), Estado nvarchar(15));
--d
create table Pago(NitBanco nvarchar(15), CodigoFactura nvarchar(15), ValorPago nvarchar(15));

insert into Banco(Nit, Nombre) values('B001','Banco de Bogotá');
insert into Banco(Nit, Nombre) values('B002','Banco Popular');
insert into Banco(Nit, Nombre) values('B003','Bancolombia');
insert into Banco(Nit, Nombre) values('B004','Banco Davivienda');

insert into Servicios(Codigo, Tipo,Valor) values('S001','Acta de grado','17000');
insert into Servicios(Codigo, Tipo,Valor) values('S002','Cursos Dirigidos','267000');
insert into Servicios(Codigo, Tipo,Valor) values('S003','Certificado de Calificaciones','14000');
insert into Servicios(Codigo, Tipo,Valor) values('S004','Cancelación de Semestre','38000');

alter table Factura add constraint FK_CodigoServicio foreign key (CodigoServicio) references Servicios(Codigo);
alter table Pago add constraint FK_NitBanco foreign key (NitBanco) references Banco(Nit);
alter table Pago add constraint FK_CodigoFactura foreign key (CodigoFactura) references Factura(NumeroFactura);



