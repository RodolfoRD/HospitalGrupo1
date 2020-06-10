create database proyecto

use Proyecto


SELECT * FROM INFORMATION_SCHEMA.TABLES
where table_name like '%do%'

create table Medicos (
id int identity (1,1) primary key,
nombre varchar(30) not null, 
exequatur varchar(30) not null,
especialidad varchar(30) not null);

select * from Medicos;
insert into Medicos values ('Daniel tejada','32544-88', 'Urologia');
update Medicos set nombre ='Daniel tejada' , exequatur ='32311-11' , especialidad ='Urologia'  where id=1
delete from Medicos where id = 1




create table Pacientes (
id int identity (1,1) primary key,
nombre varchar(30) not null, 
cedula varchar(30) not null,
asegurado varchar(30) not null);
select * from Pacientes
insert into Pacientes values ('Jose alexander', '12-12-12', 'Si')
update Pacientes set nombre = 'Jose alexander', cedula='12-12-12' , asegurado = 'No' where id = 1
delete from Pacientes where id = 1


create table Habitaciones (
id int identity (1,1) primary key,
numero varchar(30) not null, 
tipo varchar(30) not null,
precio float(12) not null);
select * from Habitaciones
insert into Habitaciones values ('S1','Suite', 20000)
update Habitaciones set numero = 'A-1' , tipo = 'Suite', precio = 2000 where id=1
delete from Habitaciones where id = 1


create table Citas (
id int identity (1,1) primary key,
idPaciente int not null,
idDoctor int  not null,
HoraFecha datetime,
constraint FK_PacientesCitas foreign key (idPaciente) references Pacientes(id), 
constraint FK_DoctoresCitas foreign key (idDoctor) references Medicos(id));
select * from Citas
insert into		Citas values (1, 1, convert(varchar,'2020-04-06 23:08:58.160'));
update Citas set idPaciente = 1, idDoctor = 1 , HoraFecha = '2020-04-07 23:08:58.160' where id = 1
delete from Citas where id=1







create table Ingresos (
id int identity (1,1) primary key,
idPaciente int not null,
idHabitacion int  not null,
Fecha datetime,
constraint FK_PacientesIngresos foreign key (idPaciente) references Pacientes(id), 
constraint FK_HabitacionesIngresos foreign key (idHabitacion) references Habitaciones(id));
select * from Ingresos
insert into Ingresos values (1, 1, convert(varchar,'2020-04-06 23:08:58.160'));
update Ingresos set idPaciente = 2, idHabitacion = 2 , Fecha = '2020-04-06 23:08:58.160' where id = 4
delete from Ingresos where id=1





create table Altas (
id int identity (1,1) primary key,
idIngresos int not null,
FechaSalida datetime,
constraint FK_IngresosAltas foreign key (idIngresos) references Ingresos(id));
select * from Altas





