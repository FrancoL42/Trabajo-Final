create database CINES
go
use CINES
go
set dateformat dmy
--Clasificacion
create table Clasificacion (
id_clasificacion int identity(1,1) not null,
descripcion varchar(50)
constraint pk_clasificacion primary key(id_clasificacion))
--Generos
create table Generos(
id_genero int identity(1,1) not null,
descripcion varchar(50)
constraint pk_genero primary key(id_genero))
--idioma
create table Idiomas
(id_idioma int identity(1,1) not null,
descripcion varchar(50)
constraint pk_idioma primary key(id_idioma))
--Peliculas
create table peliculas 
(id_pelicula int identity(1,1) not null,
titulo varchar(50),
duracion time,
id_clasificacion int,
id_idioma int,
fec_Estreno datetime,
id_genero int,
director varchar(50),
estado(20)
constraint pk_pelicula primary key(id_pelicula),
constraint fk_clasificacion foreign key(id_clasificacion)
references clasificacion(id_clasificacion),
constraint fk_idioma foreign key(id_idioma)
references idiomas(id_idioma),
constraint fk_genero foreign key(id_genero)
references generos(id_genero))
--Actores
create table Actores(
id_actor int identity(1,1) not null,
nombre varchar(50),
apellido varchar(50),
id_pelicula int 
constraint pk_actor primary key(id_actor),
constraint fk_pelicula_actor foreign key(id_pelicula)
references peliculas(id_pelicula))
--SALAS
create table salas(
id_sala int identity(1,1) not null,
cantidad_asientos int,
estado varchar(50)
constraint pk_sala primary key(id_sala))
--ButacasxSalas
create table ButacasxSalas
(id_sala int not null,
butaca_nro int not null,
estado varchar(50)
constraint Pk_sala_butaca Primary key(id_sala,butaca_nro),
constraint fk_salaxButaca foreign key(id_sala)
references Salas(id_sala))
--Funciones
create table funciones(
id_funcion int identity(1,1) not null,
id_pelicula int,
hora time,
fecha datetime,
PRECIO_ACTUAL money,
id_sala int,
estado varchar(15)
constraint pk_funcion primary key(id_funcion),
constraint fk_pelicula_funcion foreign key(id_pelicula)
references peliculas(id_pelicula),
constraint fk_sala_funcion foreign key(id_sala)
references salas(id_sala))
--Clientes
create table clientes(
id_cliente int identity(1,1) not null,
NOMBRE_CLIENTE varchar(50),
APELLIDO_CLIENTE varchar(50),
DOCUMENTO bigint,
TELEFONO bigint,
EMAIL varchar(50),
constraint pk_clientes primary key(id_cliente)
--usuarios
create table Usuarios(
ID_USUARIO int identity(1,1)not null,
ID_EMPLEADO int,
USUARIO varchar(50),
CONTRASENIA varchar(50)
constraint pk_usuario primary key(ID_USUARIO))

--tipos_Docu
--Cargos
create table cargos(
id_cargo int identity(1,1)not null,
DESCRIPCION VARCHAR(50)
constraint pk_cargo primary key(id_cargo))
--empleados
create table Empleados(
ID_EMPLEADO int not null,
NOMBRE_EMPLEADO varchar(50),
APELLIDO_EMPLEADO varchar(50),
EMAIL varchar(50),
ID_CARGO int,
nro_doc int,
estado varchar(50)
constraint pk_empleado primary key(id_empleado),
constraint fk_cargo foreign key(id_cargo)
references cargos(id_cargo)
--Comprobantes
create table comprobantes(
id_comprobante int identity(1,1) not null,
id_cliente int,
id_empleado int,
fecha datetime,
total_ticket float,
id_funcion int
constraint pk_comprobante primary key(id_comprobante),
constraint fk_cliente foreign key(id_cliente)
references clientes(id_cliente),
constraint fk_empleados foreign key(id_empleado)
references empleados(id_empleado),
constraint fk_funcion foreign key(id_funcion)
references funciones(id_funcion)
--Detalle 
create table Detalle_comprobante(
id_comprobante int not null,
id_sala int not null,
id_butaca int not null
constraint pk_detalle primary key(id_comprobante, id_sala, id_butaca),
constraint fk_sala_butaca foreign key(id_sala, id_butaca)
references ButacasxSalas(id_sala, butaca_nro),
constraint fk_comprobante foreign key(id_comprobante)
references Comprobantes(id_comprobante))