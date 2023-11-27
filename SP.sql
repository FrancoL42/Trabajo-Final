--ALTA BUTACAS
USE [cines_final]
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTA_BUTACAS]    Script Date: 27/11/2023 0:12:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_ALTA_BUTACAS]
@idSala int, 
@nroButaca int
as 
begin
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values (@idSala, @nroButaca, 'Disponible')
end
--ALTA SALAS
/****** Object:  StoredProcedure [dbo].[SP_ALTA_SALAS]    Script Date: 27/11/2023 0:12:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_ALTA_SALAS] 
@cantButacas int,
@idSala int output
as 
begin 
insert into SALAS(CANTIDAD_ASIENTOS, estado)
values(@cantButacas, 'Activa');
set @idSala = SCOPE_IDENTITY()
end
--BAJA PELICULAS
/****** Object:  StoredProcedure [dbo].[SP_BAJA_PELICULAS]    Script Date: 27/11/2023 0:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_BAJA_PELICULAS]
@id int
as 
begin
update PELICULAS
set estado = 'Inactiva'
where ID_PELICULA = @id
end
--BorrarComprobante
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_BORRAR_COMPROBANTE]
@id int
as 
begin
delete DETALLE_COMPROBANTE
where id_comprobante = @id
delete COMPROBANTES
where ID_COMPROBANTE = @id
end
----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_CONSULTAR_BUTACAXSALA]
@idSala int
as 
begin
select * from ButacasxSalas 
where id_sala = @idSala
end
-----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_CONSULTAR_CLASIFICACION] 
as 
begin
select * from CLASIFICACION
end
-----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_CONSULTAR_COMPROBANTE_PARAMETROS]
@documento int,
@cliente varchar(50)
as
begin
select co.ID_COMPROBANTE, co.FECHA, precio_total, c.APELLIDO_CLIENTE, c.DOCUMENTO from COMPROBANTES co
join CLIENTES c on c.ID_CLIENTE = co.ID_CLIENTE
join DETALLE_COMPROBANTE d on co.id_comprobante = d.id_comprobante
where c.APELLIDO_CLIENTE = @cliente and c.DOCUMENTO = @documento
end
----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  ALTER procedure [dbo].[SP_CONSULTAR_COMPROBANTES]
   AS
   BEGIN
   SELECT * FROM COMPROBANTES
   END;
------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   ALTER procedure [dbo].[SP_CONSULTAR_DETALLES]
   AS
   BEGIN
   SELECT * FROM DETALLE_COMPROBANTE
   END;
-------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 ALTER procedure [dbo].[SP_CONSULTAR_FUNCIONES]
  @fecha varchar(50),
  @pelicula varchar(100)
  AS
  BEGIN
  set dateformat dmy
  SELECT f.ID_FUNCION,f.FECHA,f.HORA,p.ID_PELICULA,p.TITULO,f.PRECIO_ACTUAL, F.id_sala 
  FROM FUNCIONES f 
  join PELICULAS p on p.id_pelicula = f.id_pelicula
  where @fecha = f.FECHA
  AND @pelicula = p.TITULO
  END;
--------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[SP_CONSULTAR_GENERO]
as 
begin 
select * from GENEROS
end
----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_CONSULTAR_IDIOMA]
as 
begin 
select * from IDIOMAS
end
---------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  ALTER procedure [dbo].[SP_CONSULTAR_PELICULAS]
  AS
  BEGIN
  SELECT  p.ID_PELICULA, p.TITULO,p.DURACION,p.ID_CLASIFICACION,p.ID_IDIOMA,p.FEC_ESTRENO
  FROM PELICULAS p
  where p.estado = 'Activa'
  END;
-----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_CONSULTAR_SALAS] 
as 
begin 
select * from SALAS
end
-----
ALTER PROCEDURE [dbo].[SP_IniciarSesionEmpleado]
    @Usuario VARCHAR(50),
    @Contrasenia VARCHAR(50),
    @IdEmpleado INT OUTPUT,
    @IdCargo INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT @IdEmpleado = e.ID_EMPLEADO, @IdCargo = ID_CARGO
    FROM EMPLEADOS e
    join USUARIOS u on u.ID_EMPLEADO= e.ID_EMPLEADO 
    WHERE USUARIO = @Usuario AND CONTRASENIA = @Contrasenia;
END;
------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_INSERTAR_BUTACA]
@idButaca int 
as
begin 
insert into SALAS(id_butaca) values (@idButaca)
end
----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_INSERTAR_CLIENTE]
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
------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_INSERTAR_COMPROBANTE]
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
---------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_INSERTAR_DETALLE_COMPROBANTE]
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
-----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_INSERTAR_PELICULAS]
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
----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_MODIFICAR_PELICULA]
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
-----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SP_Peliculas_Detalles]
as
begin 
    SELECT distinct P.ID_PELICULA,P.TITULO,P.DURACION,G.DESCRIPCION,C.DESCRIPCION 'Clasificacion',I.IDIOMA,P.FEC_ESTRENO, A.NOMBRE + ' ' + A.APELLIDO 'Actor Principal'
    FROM PELICULAS P 
    join CLASIFICACION c on p.ID_CLASIFICACION = c.ID_CLASIFICACION
    JOIN IDIOMAS I ON P.ID_IDIOMA = I.ID_IDIOMA
    JOIN ACTORES A ON A.ID_PELICULA = P.ID_PELICULA
    join Peliculas_genero pg ON PG.ID_PELICULA = P.ID_PELICULA
    JOIN GENEROS G ON G.ID_GENERO = PG.ID_GENERO
    order by 'Actor Principal' asc

    END;
----------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_TRAER_BUTACASXSALAS]
@idSala int
as
begin
select * from ButacasxSalas 
where id_sala = @idSala
end
------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_TRAER_TIPO_DOC]
as 
begin
select * from TIPOS_DOC
end 