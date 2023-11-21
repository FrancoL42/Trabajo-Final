
create PROCEDURE ObtenerButacasDisponiblesConInfo
    @Titulo VARCHAR(100),
    @fechaFuncion varchar(10) ,
    @id_sala INT ,
    @HoraFuncion TIME 
AS
BEGIN
    -- Seleccionar el nombre de la película, la función, el día, la sala y las butacas disponibles
    SELECT P.Titulo AS NombrePelicula, F.Hora AS HoraFuncion, B.id_butaca, B.nro_butaca, B.fila
    FROM BUTACAS b 
	join FUNCIONES_SALAS fs on fs.ID_SALA = bs.id_sala
	join Pelicula_Funciones pf on fs.ID_FUNCION = pf.id_funcion
	join PELICULAS p on p.ID_PELICULA = pf.id_pelicula
	join FUNCIONES f on f.ID_FUNCION = pf.id_funcion
    WHERE  NOT EXISTS (
        -- Excluir las butacas ya compradas para la película, función, sala y fecha seleccionadas
        SELECT dc.id_butaca
        FROM Detalle_Comprobante DC
		where dc.id_butaca = bs.id_butacas_Sala
    )
    AND P.Titulo LIKE '%' + @Titulo + '%'
	AND F.FECHA = @fechaFuncion          AND F.Hora = @HoraFuncion
		  AND FS.id_sala = @id_sala
	 
END;


EXEC ObtenerButacasDisponiblesConInfo @titulo = 'Iron',@FechaFuncion ='17/11/2023', @HoraFuncion = '22:30:00', @id_sala = 1

---------------------------------------------------------------------------------------------------------------------------------------------------------------
  alter procedure SP_CONSULTAR_FUNCIONES
  @fecha varchar(50),
  @pelicula varchar(100)
  AS
  BEGIN
  set dateformat dmy
  SELECT f.ID_FUNCION,f.FECHA,f.HORA,p.ID_PELICULA,p.TITULO,f.PRECIO_ACTUAL 
  FROM FUNCIONES f 
  join PELICULAS p on p.id_pelicula = f.id_pelicula
  where @fecha = f.FECHA
  AND @pelicula = p.TITULO
  END;
  EXEC SP_CONSULTAR_FUNCIONES @Fecha = '25-11-2023', @pelicula = 'Iron Man'
  select * from FUNCIONEs f
  join PELICULAS p on p.ID_PELICULA = f.ID_PELICULA
  order by TITULO

  ---------------------------------------------------------------------------------------------------------------------------------------------------------------
   ------------------------------------------------------------------------------------------------------------------------------------------------

  create procedure SP_CONSULTAR_PELICULAS
  AS
  BEGIN
  SELECT  p.ID_PELICULA, p.TITULO,p.DURACION,p.ID_CLASIFICACION,p.ID_IDIOMA,p.FEC_ESTRENO,p.ID_PAIS_ORIGEN  
  FROM PELICULAS p
  END;


  select * from COMPROBANTES c
  join DETALLE_COMPROBANTE d on d.id_comprobante = c.ID_COMPROBANTE
  join CLIENTES cl on cl.ID_CLIENTE = c.ID_CLIENTE
  EXEC SP_CONSULTAR_PELICULAS
   ------------------------------------------------------------------------------------------------------------------------------------------------
   create procedure SP_CONSULTAR_DETALLES
   AS
   BEGIN
   SELECT * FROM DETALLE_COMPROBANTE
   END;
   ------------------------------------------------------------------------------------------------------------------------------------------------
   create procedure SP_CONSULTAR_COMPROBANTES
   AS
   BEGIN
   SELECT * FROM COMPROBANTES
   END;
   -------------------------------------------------------------------------------------------------------------------------------------------------
   create procedure GenerarCompra
   @Cliente int,
   @Fecha datetime,
   @idComprobante int output
   as
   begin 
		Insert into COMPROBANTES (id_cliente,id_empleado,fecha,id_cine)
		VALUES (@Cliente,1,@Fecha,1)
		set @idComprobante = SCOPE_IDENTITY();
	end;
-------------------------------------------------------------------------------------------------------------------------------------------------
  create procedure GenerarCliente
  @nombre varchar(20),
  @apellido varchar (20),
  @documento int,
  @telefono int,
  @email varchar (70),
  @id_cliente int OUTPUT
  as
  begin
		insert into Clientes(NOMBRE_CLIENTE,APELLIDO_CLIENTE, DOCUMENTO, TELEFONO, EMAIL)
		values (@nombre,@apellido,@documento,@telefono,@email)
		set @id_cliente = SCOPE_IDENTITY();
end;


		-------------------------------------------------------------------------------------------------------------------------------------------------
create PROCEDURE GenerarDetalle
@idComprobante int,
@idFuncion int,
@idSala int,
@precio float
as
begin
     insert into DETALLE_COMPROBANTE(id_comprobante, id_funcion, id_sala, precio_total)
	 values(@idComprobante, @idFuncion, @idSala, @precio)
	 end;
	 -------------------------------------------------------------------------------------------------------------------------------------------------
create proc SP_INSERTAR_BUTACA
@idButaca int 
as
begin 
insert into SALAS(id_butaca) values (@idButaca)
end




create proc SP_CONSULTAR_COMPROBANTE_PARAMETROS
@documento int,
@cliente varchar(50)
as
begin
select co.ID_COMPROBANTE, co.FECHA, precio_total, c.APELLIDO_CLIENTE, c.DOCUMENTO from COMPROBANTES co
join CLIENTES c on c.ID_CLIENTE = co.ID_CLIENTE
join DETALLE_COMPROBANTE d on co.id_comprobante = d.id_comprobante
where c.APELLIDO_CLIENTE = @cliente and c.DOCUMENTO = @documento
end

exec SP_CONSULTAR_COMPROBANTE_PARAMETROS 12345678, Pérez


select * from COMPROBANTES c
join clientes cl on cl.id_cliente = c.id_cliente



exec SP_CONSULTAR_COMPROBANTE_PARAMETROS 12345678, 'pérez'

create proc SP_BORRAR_COMPROBANTE
@id int
as 
begin
delete DETALLE_COMPROBANTE
where id_comprobante = @id
delete COMPROBANTES
where ID_COMPROBANTE = @id
end

CREATE PROCEDURE SP_IniciarSesionEmpleado
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

ALTER procedure SP_Peliculas_Detalles
as
begin 
    SELECT distinct P.ID_PELICULA,P.TITULO,P.DURACION,G.DESCRIPCION,C.DESCRIPCION 'Clasificacion',I.IDIOMA,P.FEC_ESTRENO, A.NOMBRE + ' ' + A.APELLIDO 'Actor Principal'
    FROM PELICULAS P 
    join CLASIFICACION c on p.ID_CLASIFICACION = c.ID_CLASIFICACION
    JOIN IDIOMAS I ON P.ID_IDIOMA = I.ID_IDIOMA
    JOIN ACTORES_PELICULAS AP ON AP.ID_PELICULA = P.ID_PELICULA
    JOIN ACTORES A ON A.ID_ACTOR = AP.ID_ACTOR
    join Peliculas_genero pg ON PG.ID_PELICULA = P.ID_PELICULA
    JOIN GENEROS G ON G.ID_GENERO = PG.ID_GENERO

    END;


	select * from COMPROBANTES c
	join CLIENTES  cl on cl.ID_CLIENTE = c.ID_CLIENTE
	join DETALLE_COMPROBANTE d on d.id_comprobante = c.ID_COMPROBANTE


	select * from FUNCIONES f

	ALTER procedure SP_Peliculas_Detalles
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