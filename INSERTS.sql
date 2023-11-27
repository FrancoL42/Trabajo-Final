--Idiomas
INSERT INTO IDIOMAS (IDIOMA)
VALUES
( 'Español'),
( 'Inglés'),
('Francés'),
( 'Alemán'),
( 'Italiano'),
( 'Portugués'),
( 'Chino'),
( 'Japonés'),
( 'Coreano'),
( 'Ruso');

--Clasificacion
INSERT INTO CLASIFICACION ( DESCRIPCION)
VALUES
( 'Apta para todo púb'),
( 'Mayores de 13 años'),
( 'Mayores de 16 años'),
( 'Mayores de 18 años'),
( 'Restringida');

--Generos
INSERT INTO GENEROS( DESCRIPCION)
VALUES
( 'Acción'),
( 'Comedia'),
( 'Drama'),
( 'Ciencia ficción'),
( 'Aventura'),
( 'Fantasía'),
( 'Romance'),
( 'Suspense'),
( 'Terror'),
( 'Documental');
--PELICULAS
Insert into peliculas(TITULO, DURACION, id_clasificacion, id_idioma, fec_estreno, id_genero, estado) 
values
('Iron Man', '2:06:00', 3, 1, '02-05-2008', 4,'Activa'), -- Iron Man (2008)
('Los Vengadores', '2:23:00', 2, 1, '25-04-2012', 4,'Activa'), -- Los Vengadores (2012)
('Guardianes de la Galaxia', '2:01:00', 3, 1, '31-07-2014', 4, 'Activa'), -- Guardianes de la Galaxia (2014)
('Black Panther', '2:14:00', 2, 1, '13-02-2018', 4, 'Activa'), -- Black Panther (2018)
('Avengers: Endgame', '3:02:00', 2, 1, '24-04-2019', 4, 'Activa'); -- Avengers: Endgame (2019)
INSERT INTO PELICULAS (TITULO, DURACION, ID_CLASIFICACION, ID_IDIOMA, FEC_ESTRENO, ID_PAIS_ORIGEN)
VALUES
('Casablanca', '1:42:00', 4, 1, '26-11-1942', 6,'Activa'), -- Casablanca (1942)
('Lo que el Viento se Llevó', '3:53:00', 4, 1, '15-12-1939', 7,'Activa'), -- Lo que el Viento se Llevó (1939)
('El Padrino', '2:55:00', 3, 2, '15-03-1972', 8,'Activa'), -- El Padrino (1972)
('Cantando Bajo la Lluvia', '1:43:00', 4, 1, '27-03-1952', 9,'Activa'), -- Cantando Bajo la Lluvia (1952)
('Tiempos Modernos', '1:27:00', 4, 1, '05-02-1936', 10,'Activa');
-- Películas Antiguas (Continuación)
INSERT INTO PELICULAS (TITULO, DURACION, ID_CLASIFICACION, ID_IDIOMA, FEC_ESTRENO, ID_PAIS_ORIGEN)
VALUES
('Ciudadano Kane', '1:59:00', 4, 1, '05-09-1941', 11,'Activa'), -- Ciudadano Kane (1941)
('El Mago de Oz', '1:42:00', 4, 1, '15-08-1939', 12,'Activa'), -- El Mago de Oz (1939)
('Lo que el Viento se Llevó', '3:58:00', 4, 1, '20-01-1961', 7,'Activa'), -- Lo que el Viento se Llevó (Reestreno en 1961)
('12 Hombres en Pugna', '1:36:00', 4, 1, '10-04-1957', 13,'Activa'), -- 12 Hombres en Pugna (1957)
('El Ciudadano Ilustre', '1:58:00', 4, 1, '08-09-2016', 14,'Activa'); -- El Ciudadano Ilustre (2016)

-- Películas (Continuación)
INSERT INTO PELICULAS (TITULO, DURACION, ID_CLASIFICACION, ID_IDIOMA, FEC_ESTRENO, ID_PAIS_ORIGEN)
VALUES
('El Resplandor', '2:24:00', 2, 1, '23-05-1980', 5,'Activa'), -- El Resplandor (1980)
('Blade Runner', '1:57:00', 2, 2, '25-06-1982', 2,'Activa'), -- Blade Runner (1982)
('ET, el Extraterrestre', '1:55:00', 3, 4, '11-06-1982', 3,'Activa'), -- ET, el Extraterrestre (1982)
('Star Wars: Episodio IV - Una Nueva Esperanza', '2:01:00', 2, 3, '25-05-1977', 4,'Activa'), -- Star Wars: Episodio IV (1977)
('Los Cazafantasmas', '1:45:00', 3, 2, '08-06-1984', 5,'Activa'); -- Los Cazafantasmas (1984)

-- Películas de Marvel
INSERT INTO PELICULAS (TITULO, DURACION, ID_CLASIFICACION, ID_IDIOMA, FEC_ESTRENO, ID_PAIS_ORIGEN)
VALUES
('Iron Man', '2:06:00', 3, 1, '02-05-2008', 4,'Activa'), -- Iron Man (2008)
('Los Vengadores', '2:23:00', 2, 1, '25-04-2012', 4,'Activa'), -- Los Vengadores (2012)
('Guardianes de la Galaxia', '2:01:00', 3, 1, '31-07-2014', 4,'Activa'), -- Guardianes de la Galaxia (2014)
('Black Panther', '2:14:00', 2, 1, '13-02-2018', 4,'Activa'), -- Black Panther (2018)
('Avengers: Endgame', '3:02:00', 2, 1, '24-04-2019', 4,'Activa'); -- Avengers: Endgame (2019)


--FUNCIONES
INSERT INTO FUNCIONES (HORA, FECHA, PRECIO_ACTUAL, id_pelicula) --dawwad
VALUES 
('14:00:00', '2023-11-17', 10.00, 1), 
('17:30:00', '2023-11-17', 12.50, 2),
('20:00:00', '2023-11-17', 15.00, 3),
('22:30:00', '2023-11-17', 13.50, 4),
('14:00:00', '2023-11-18', 10.00, 5), 
('17:30:00', '2023-11-18', 12.50, 6),
('20:00:00', '2023-11-18', 15.00, 7),
('22:30:00', '2023-11-18', 13.50, 8),
('14:00:00', '2023-11-19', 10.00, 9), 
('17:30:00', '2023-11-19', 12.50, 11),
('20:00:00', '2023-11-19', 15.00, 1),
('22:30:00', '2023-11-19', 13.50, 2),
('14:00:00', '2023-11-20', 10.00, 3), 
('17:30:00', '2023-11-20', 12.50, 4),
('20:00:00', '2023-11-20', 15.00, 5),
('22:30:00', '2023-11-20', 13.50, 6),
('14:00:00', '2023-11-21', 10.00, 7), 
('17:30:00', '2023-11-21', 12.50, 8),
('20:00:00', '2023-11-21', 15.00, 9),
('22:30:00', '2023-11-21', 13.50, 1),
('14:00:00', '2023-11-22', 10.00, 12), 
('17:30:00', '2023-11-22', 12.50, 3),
('20:00:00', '2023-11-22', 15.00, 10),
('22:30:00', '2023-11-22', 13.50, 15),
('14:00:00', '2023-11-23', 10.00, 16), 
('17:30:00', '2023-11-23', 12.50,7),
('20:00:00', '2023-11-23', 15.00, 8),
('22:30:00', '2023-11-24', 13.50, 9),
('14:00:00', '2023-11-24', 10.00, 1), 
('17:30:00', '2023-11-24', 12.50, 2),
('20:00:00', '2023-11-24', 15.00, 3),
('22:30:00', '2023-11-25', 13.50, 4),
('14:00:00', '2023-11-25', 10.00, 5), 
('17:30:00', '2023-11-25', 12.50, 6),
('20:00:00', '2023-11-25', 15.00, 7),
('22:30:00', '2023-11-26', 13.50, 8),
('14:00:00', '2023-11-26', 10.00, 9), 
('17:30:00', '2023-11-26', 12.50, 10),
('20:00:00', '2023-11-26', 15.00, 1),
('22:30:00', '2023-11-27', 13.50, 2),
('14:00:00', '2023-11-27', 10.00,3), 
('17:30:00', '2023-11-27', 12.50, 4),
('20:00:00', '2023-11-27', 15.00, 5),
('22:30:00', '2023-11-28', 13.50, 6);
--SALAS
INSERT INTO SALAS(CANTIDAD_ASIENTOS,estado) 
VALUES
(18,'Activa')
(18,'Activa')

select * from salas
--BUTACASxSALAS
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 1,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 2,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 3,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 4,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 5,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 6,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 7,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 8,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 9,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 10,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 11,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 12,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 13,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 14,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 15,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 16,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 17,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(1, 18,'Disponible')

insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 1,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 2,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 3,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 4,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 5,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 6,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 7,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 8,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 9,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 10,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 11,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 12,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 13,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 14,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 15,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 16,'Disponible')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 17,'Ocupada')
insert into ButacasxSalas(id_sala, butaca_nro, estado)
values(2, 18,'Ocupada')

--cargos
INSERT INTO CARGOS ( DESCRIPCION)
VALUES
( 'Gerente'),
( 'Cajero'),
( 'Conserje'),
( 'Proyeccionista'),
( 'Asistente de ventas'),
( 'Limpieza'),
( 'Técnico de sonido'),
( 'Técnico proyección');


--empleados
INSERT INTO EMPLEADOS ( NOMBRE_EMPLEADO, APELLIDO_EMPLEADO, EMAIL, ID_BARRIO, ID_CARGO)
VALUES
('Juan', 'Pérez', 'juan.perez@email.com', 2, 1), -- Cargo 1, Barrio 1
('María', 'González', 'maria.gonzalez@email.com', 2, 2), -- Cargo 2, Barrio 2
('Carlos', 'Martínez', 'carlos.martinez@email.com', 3, 1), -- Cargo 1, Barrio 3
('Laura', 'Rodríguez', 'laura.rodriguez@email.com', 4, 2), -- Cargo 2, Barrio 4
('Pedro', 'López', 'pedro.lopez@email.com', 5, 1); -- Cargo 1, Barrio 5
insert into EMPLEADOS(NOMBRE_EMPLEADO, APELLIDO_EMPLEADO, EMAIL, estado)
values ('WEB', 'WEB', '-', 'ACTIVO')

--actores*
INSERT INTO ACTORES (NOMBRE, APELLIDO)
VALUES
('Brad', 'Pitt'),
('Tom', 'Hanks'),
('Meryl', 'Streep'),
('Angelina', 'Jolie'),
('Leonardo', 'DiCaprio'),
('Tom', 'Cruise'),
('Julia', 'Roberts'),
('Johnny', 'Depp'),
('Will', 'Smith'),
('Scarlett', 'Johansson'),
('Robert', 'Downey Jr.'),
('Jennifer', 'Lawrence'),
('Denzel', 'Washington'),
('Charlize', 'Theron'),
('Matt', 'Damon'),
('Nicole', 'Kidman'),
('Bradley', 'Cooper'),
('Natalie', 'Portman'),
('Chris', 'Hemsworth'),
('Anne', 'Hathaway'),
('Harrison', 'Ford'),
('Keanu', 'Reeves'),
('Emma', 'Watson'),
('Samuel', 'L. Jackson'),
('Angelina', 'Jolie');
--USUARIOS
insert into usuarios( ID_EMPLEADO, USUARIO, CONTRASENIA)
    Values(1,'Manu','123')
insert into usuarios( ID_EMPLEADO, USUARIO, CONTRASENIA)
    Values(2,'Martin','321')

--CLIENTES, COMPROBANTE Y DETALLE INSERTAR CON EL PROGRAMA
