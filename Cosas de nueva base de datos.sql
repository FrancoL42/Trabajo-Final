select * from butacas b
join SALAS s on s.ID_SALA = b.ID_SALA
join FUNCIONES f on f.id_sala = s.ID_SALA
order by b.id_butaca

alter table Butacas 
add estado varchar(50)


update butacas 
set estado = 'Disponible'

update butacas
set estado = 'Ocupada'
where id_butaca between 11 and 18

alter table salas
drop constraint fk_butaca

alter table salas
drop column id_butaca

alter table butacas
add id_sala int 

alter table butacas 
add constraint fk_sala foreign key(id_sala)
references salas(id_sala)

select * from FUNCIONES f
join PELICULAS p on p.ID_PELICULA = f.ID_PELICULA


select * from COMPROBANTES

drop table PRODUCTOS_CANDY_BAR
drop table VENTAS_CANDY_BAR

select * from SALAS



update butacas 
set ID_SALA = 4


insert into butacas(nro_butaca, fila, estado, id_sala) 
values(1,'A', 'Ocupada', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(2,'A', 'Ocupada', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(3,'A', 'Ocupada', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(4,'A', 'Disponible', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(5,'A', 'Disponible', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(6,'A', 'Disponible', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(7,'B', 'Disponible', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(8,'B', 'Disponible', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(9,'B', 'Ocupada', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(10,'B', 'Disponible', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(11,'B', 'Disponible', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(12,'B', 'Disponible', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(13,'C', 'Disponible', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(14,'C', 'Disponible', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(15,'C', 'Ocupada', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(16,'C', 'Disponible', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(17,'C', 'Disponible', 5)
insert into butacas(nro_butaca, fila, estado, id_sala) 
values(19,'C', 'Ocupada', 5)

alter table salas 
drop constraint fk_funcion

alter table salas 
drop column id_funcion

alter table funciones 
add id_sala int

alter table funciones
add constraint fk_sala_funcion foreign key(id_sala)
references salas(id_sala)


select * from butacas 
where id_sala = 5

select * from FUNCIONES


update FUNCIONES 
set id_sala = 4
where ID_FUNCION between 5 and 26

update FUNCIONES 
set id_sala = 5
where ID_FUNCION between 27 and 48



update butacas 
set nro_butaca = 18
where id_butaca = 36



create proc SP_TRAER_BUTACAS
@id int
as 
begin 
select * from butacas b
where b.id_sala = @id
end

exec SP_TRAER_BUTACAS 5

create proc SP_TRAER_TIPO_DOC
as 
begin
select * from TIPOS_DOC
end 


alter table salas 
drop constraint fk_funcion

create table SalasxFuncion
(id_sala int not null,
butaca_nro int not null,
estado varchar(50)
constraint fk_sala_butaca Primary key(id_sala,butaca_nro))


alter table salas
drop column id_cine

select * from Peliculas

alter table peliculas 
drop constraint fk_peli_pais
alter table peliculas
drop column id_pais_origen

drop table PAIS_ORIGEN


select * from CLIENTES

alter table clientes 
drop constraint fk_tipo_doc

alter table clientes 
drop column id_tipo_doc


select * from DETALLE_COMPROBANTE

alter table DETALLE_COMPROBANTE
drop constraint fk_detalle_comp_butacas

alter table DETALLE_COMPROBANTE
drop constraint fk_detalle_comp_Sala

alter table DETALLE_COMPROBANTE
drop column id_sala

alter table DETALLE_COMPROBANTE
drop column id_butaca

drop table Peliculas_Genero

alter table Peliculas
add id_genero int


alter table peliculas 
add constraint fk_genero foreign key(id_genero)
references Generos(id_genero)


alter table comprobantes
drop constraint fk_comp_cine

alter table comprobantes
drop column id_cine

drop table CINES

alter table funciones
drop constraint fk_funcion_tipo_formato

alter table funciones
drop column id_tipo_formato

drop table Tipo_formato

drop table SalasxFuncion

create table ButacasxSalas
(id_sala int not null,
butaca_nro int not null,
estado varchar(50)
constraint Pk_sala_butaca Primary key(id_sala,butaca_nro),
constraint fk_salaxButaca foreign key(id_sala)
references Salas(id_sala))



alter table Peliculas
add director varchar(50)


select * from BARRIOS b 
join LOCALIDADES l on l.ID_LOCALIDAD = b.ID_LOCALIDAD
join PROVINCIAS p on p.ID_PROVINCIA = l.ID_PROVINCIA


update PROVINCIAS
set PROVINCIA = 'Mendoza'
where ID_PROVINCIA = 3

select * from PELICULAS
select * from GENEROS

update PELICULAS 
set id_genero = 1
where ID_PELICULA between 36 and 40


('Iron Man', '2:06:00', 3, 1, '02-05-2008', 4), -- Iron Man (2008)
('Los Vengadores', '2:23:00', 2, 1, '25-04-2012', 4), -- Los Vengadores (2012)
('Guardianes de la Galaxia', '2:01:00', 3, 1, '31-07-2014', 4), -- Guardianes de la Galaxia (2014)
('Black Panther', '2:14:00', 2, 1, '13-02-2018', 4), -- Black Panther (2018)
('Avengers: Endgame', '3:02:00', 2, 1, '24-04-2019', 4); -- Avengers: Endgame (2019)

update PELICULAS 
set director = 'James, Gumm',
where ID_PELICULA between 36 and 40

update PELICULAS 
set estado = 'Activa'

select * from PELICULAS


select p.TITULO, p.DURACION, c.DESCRIPCION,i.IDIOMA, FEC_ESTRENO, g.DESCRIPCION from PELICULAS p
join CLASIFICACION c on p.ID_CLASIFICACION = c.ID_CLASIFICACION
join IDIOMAS i on i.ID_IDIOMA = p.ID_CLASIFICACION
join GENEROS g on g.ID_GENERO = p.id_genero







--ABM SOPORTE
--ABM PELICULAS

--Cargar grilla de peliculas
exec SP_CONSULTAR_PELICULAS
--cargar combo clasificacion
create proc SP_CONSULTAR_CLASIFICACION 
as 
begin
select * from CLASIFICACION
end
--cargar combo idioma
create proc SP_CONSULTAR_IDIOMA
as 
begin 
select * from IDIOMAS
end

exec SP_CONSULTAR_IDIOMA
--cargar combo genero
CREATE PROC SP_CONSULTAR_GENERO
as 
begin 
select * from GENEROS
end
exec SP_CONSULTAR_GENERO

--cargar grilla salas
create proc SP_CONSULTAR_SALAS 
as 
begin 
select * from SALAS
end

exec SP_CONSULTAR_SALAS

delete SALAS
where ID_SALA not between 4 and 6

update salas 
set estado = 'Disponible'

--CONSULTAR SALASxBUTACAS
select * from FUNCIONES



--ALTA PELICULAS
create proc SP_INSERTAR_PELICULAS
@titulo varchar(50),
@duracion time,
@idClasificacion int,
@id_idioma int,
@fecEstreno varchar(50),
@idGenero int,
@director varchar(50)
as
begin 
set dateformat dmy
insert into PELICULAS(TITULO,DURACION,ID_CLASIFICACION,ID_IDIOMA,FEC_ESTRENO,ID_GENERO,DIRECTOR, estado)
values(@titulo, @duracion, @idClasificacion, @id_idioma, @fecEstreno, @idGenero, @director, 'Activa')
end
--Baja Peliculas, Necesario(SP_CONSULTAR_PELICULAS)
create proc SP_BAJA_PELICULAS
@id int
as 
begin
update PELICULAS
set estado = 'Inactiva'
where ID_PELICULA = @id
end

--Modificacion Peliculas, Necesario(Lo mismo que alta)
alter proc SP_MODIFICAR_PELICULA
@idPelicula int,
@duracion time,
@idClasificacion int,
@idIdioma int,
@fecEstreno datetime,
@idGenero int,
@director varchar(50)
as
begin 
set dateformat dmy
update PELICULAS 
set duracion = @duracion,
id_clasificacion = @idClasificacion,
ID_IDIOMA = @idIdioma,
FEC_ESTRENO = @fecEstreno,
id_genero = @idGenero,
director = @director

where ID_PELICULA = @idPelicula
end




--ABM SALAS

alter table salas 
add estado varchar(50)

exec SP_CONSULTAR_SALAS
--ALTA SALA
create proc SP_ALTA_SALAS 
@cantButacas int,
@idSala int output
as 
begin 
insert into SALAS(CANTIDAD_ASIENTOS, estado)
values(@cantButacas, 'Activa');
set @idSala = SCOPE_IDENTITY()
end

create proc SP_ALTA_BUTACAS
@idSala int, 
@nroButaca int
as 
begin
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values (@idSala, @nroButaca, 'Disponible')
end
--BAJA SALA
create proc SP_BAJA_SALA
@idSala int
as 
begin 
update SALAS 
set estado = 'Inactiva'
where ID_SALA = @idSala
end
--MODIFICAR SALA
create proc SP_MODIFICAR_SALA
@idSala int,
@cantButacas
as 
begin 
update SALAS
set CANTIDAD_ASIENTOS = @cantButacas
where ID_SALA = @idSala
end

--ABM FUNCIONES
alter table funciones 
add estado varchar(50)

update FUNCIONES 
set estado = 'Activa'

select * from FUNCIONES

--ALTA FUNCION
create proc SP_ALTA_FUNCIONES 
@Fecfuncion datetime,
@horaFuncion time,
@precio money,
@idPelicula int,
@idSala int
as 
begin
insert into FUNCIONES(FECHA, hora, ID_PELICULA, id_sala, PRECIO_ACTUAL)
values(@Fecfuncion, @horaFuncion, @idPelicula, @idSala, @precio)
end
--BAJA FUNCION
create proc SP_BAJA_FUNCION
@idFuncion int 
as 
begin
update FUNCIONES 
set estado = 'Inactiva'
end
--MODIFICAR FUNCION
create proc SP_MODIFICAR_FUNCION
@idFuncion int,
@fecha varchar(50),
@hora time, 
@idPelicula int,
@idSala int
as 
begin 
update FUNCIONES 
set FECHA = @fecha,
HORA = @hora,
ID_PELICULA = @idPelicula,
id_sala = @idSala
where ID_FUNCION = @idFuncion
end

--ABM EMPLEADOS
create table tipos_documentos
(id_tipo_doc int identity(1,1) not null,
desc_tipo varchar(50)
constraint pk_tipo_doc primary key(id_tipo_doc))


alter table Empleados
add nro_doc int
alter table Empleados
add id_tipo_doc int
alter table Empleados
add constraint fk_tipo_doc foreign key(id_tipo_doc)
references tipos_documentos(id_tipo_doc)

alter table Empleados
add estado varchar(50)
--ALTA EMPLEADO
create proc SP_INSERTAR_EMPLEADO
@apellido varchar(50),
@nombre varchar(50),
@idTipoDoc int,
@nroDoc int(8)
as 
insert into EMPLEADOS(APELLIDO_EMPLEADO, NOMBRE_EMPLEADO, it_tipo_doc, nro_doc, estado)
values(@apellido, @nombre, @idTipoDoc, nroDoc, 'activo')
end

select * from EMPLEADOS

--BAJA EMPLEADO
create proc SP_BAJA_EMPLEADO
@idEmpleado 
as 
update EMPLEADOS 
set estado = 'inactivo'
where ID_EMPLEADO = @idEmpleado

--MODIFICAR EMPLEADO

create proc SP_MODIFICAR_EMPLEADO
@idEmpleado int,
@nombre varchar(50),
@apellido varchar(50),
@idTipoDoc int, 
@nroDoc int
as 
begin
update EMPLEADOS
set NOMBRE_EMPLEADO = @nombre, APELLIDO_EMPLEADO = @apellido, id_tipo_doc = @idTipoDoc, nro_doc = @nroDoc
where ID_EMPLEADO = @idEmpleado
end

alter table DETALLE_COMPROBANTE
drop column precio_total

drop table DETALLE_COMPROBANTE

create table Detalle_comprobante(
id_comprobante int not null,
id_sala int not null,
id_butaca int not null
constraint pk_detalle primary key(id_comprobante, id_sala, id_butaca),
constraint fk_sala_butaca foreign key(id_sala, id_butaca)
references ButacasxSalas(id_sala, butaca_nro),
constraint fk_comprobante foreign key(id_comprobante)
references Comprobantes(id_comprobante))



alter table Comprobantes
add total_Ticket float 



select* from SALAS s
join ButacasxSalas b on b.id_sala = s.ID_SALA

select * from COMPROBANTES


insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 1,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 2,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 3,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 4,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 5,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 6,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 7,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 8,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 9,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 10,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 11,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 12,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 13,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 14,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 15,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 16,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 17,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(4, 18,'Disponible')

insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 1,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 2,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 3,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 4,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 5,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 6,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 7,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 8,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 9,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 10,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 11,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 12,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 13,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 14,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 15,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 16,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 17,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(5, 18,'Ocupada')


alter table comprobantes 
add id_funcion int 

alter table comprobantes 
add constraint fk_funcion_comprobante foreign key(id_funcion)
references funciones(id_funcion)


select * from FUNCIONES


create proc SP_INSERTAR_CLIENTE
@nombre varchar(50),
@apellido varchar(50),
@documento int,
@telefono int,
@email varchar(50),
@idCliente int output
as 
begin 
insert into Clientes(NOMBRE_CLIENTE,APELLIDO_CLIENTE,DOCUMENTO,TELEFONO,EMAIL)
values(@nombre, @apellido,@documento,@telefono,@email)
set @idCliente = SCOPE_IDENTITY()
end

alter proc SP_INSERTAR_COMPROBANTE
@idCliente int,
@idEmpleado int,
@fecha varchar(50),
@total float,
@idFuncion int,
@idComprobante int output
as
begin
insert into COMPROBANTES(ID_CLIENTE, ID_EMPLEADO, FECHA, total_Ticket, id_funcion)
values (@idCliente, @idEmpleado, @fecha, @total, @idFuncion)
set @idComprobante = SCOPE_IDENTITY()
end

alter proc SP_INSERTAR_DETALLE_COMPROBANTE
@idComprobante int,
@idSala int,
@idButaca int
as
begin
insert into Detalle_comprobante(id_comprobante, id_sala, id_butaca)
values(@idComprobante, @idSala, @idButaca)

update ButacasxSalas
set estado = 'Ocupada'
where butaca_nro = @idButaca
end


create proc SP_CONSULTAR_BUTACAXSALA
@idSala int
as 
begin
select * from ButacasxSalas 
where id_sala = @idSala
end

exec SP_CONSULTAR_FUNCIONES '25-11-2023', 'Iron Man'

exec SP_CONSULTAR_PELICULAS

alter proc SP_TRAER_BUTACASXSALAS
@idSala int
as
begin
select * from ButacasxSalas 
where id_sala = @idSala
end

exec SP_TRAER_BUTACASXSALAS 4


select * from FUNCIONES f
join PELICULAS p on p.ID_PELICULA = f.ID_FUNCION
order by TITULO


select * from COMPROBANTES c
join Detalle_comprobante d on d.id_comprobante = c.ID_COMPROBANTE

exec SP_CONSULTAR_CLASIFICACION
exec SP_CONSULTAR_GENERO
exec SP_CONSULTAR_IDIOMA
exec SP_CONSULTAR_PELICULAS

--reporte
select c.ID_COMPROBANTE, c.FECHA, c.total_Ticket, d.id_butaca, f.HORA, p.TITULO, p.ID_PELICULA from COMPROBANTES c
join Detalle_comprobante d on d.id_comprobante = c.ID_COMPROBANTE
join FUNCIONES f on f.ID_FUNCION = c.id_funcion
join PELICULAS p on p.ID_PELICULA = f.ID_PELICULA
where TITULO = 'Iron Man'

select top 1 d.id_comprobante, cl.NOMBRE_CLIENTE +','+ cl.APELLIDO_CLIENTE 'Cliente',f.ID_FUNCION, p.TITULO,s.ID_SALA 'Nro de Sala' ,c.total_Ticket from Detalle_comprobante d
join COMPROBANTES c on c.ID_COMPROBANTE = d.id_comprobante
join CLIENTES cl on cl.ID_CLIENTE = c.ID_CLIENTE
join FUNCIONES f on f.ID_FUNCION = c.id_funcion
join PELICULAS p on f.ID_PELICULA = p.ID_PELICULA
join SALAS s on f.id_sala = s.ID_SALA
order by id_comprobante desc



select * from COMPROBANTES

insert into EMPLEADOS(NOMBRE_EMPLEADO, APELLIDO_EMPLEADO, EMAIL, estado)
values ('WEB', 'WEB', '-', 'ACTIVO')

create proc SP_CONSULTAR_FUNCIONES_SINPARAM
as
begin 
select * from FUNCIONES f
join PELICULAS p on p.ID_PELICULA = f.id_pelicula
end
set dateformat dmy
SELECT f.ID_FUNCION,f.FECHA,f.HORA,p.ID_PELICULA,p.TITULO,f.PRECIO_ACTUAL, F.id_sala 
  FROM FUNCIONES f 
  join PELICULAS p on p.id_pelicula = f.id_pelicula
  where p.TITULO = 'Pulp Fiction'
  AND f.fecha = '15-02-2014'


select * from EMPLEADOS
--FRM CLIENTE
CREATE PROC SP_PELICULAS_CARTELERA