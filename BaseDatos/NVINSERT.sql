ALTER TABLE PROVINCIAS
ALTER COLUMN PROVINCIA VARCHAR(50); -- Aumenta la longitud a 50 caracteres (ajusta según tus necesidades)
-- Inserta las provincias de Argentina en la tabla PROVINCIAS sin mencionar el campo ID_PROVINCIA
-- Inserta las provincias de Argentina en la tabla PROVINCIAS
INSERT INTO PROVINCIAS ( PROVINCIA)
VALUES
( 'Buenos Aires'),
( 'Catamarca'),
( 'Chaco'),
( 'Chubut'),
( 'Córdoba'),
( 'Corrientes'),
( 'Entre Ríos'),
( 'Formosa'),
( 'Jujuy'),
( 'La Pampa'),
( 'La Rioja'),
( 'Mendoza'),
( 'Misiones'),
( 'Neuquén'),
( 'Río Negro'),
( 'Salta'),
( 'San Juan'),
( 'San Luis'),
( 'Santa Cruz'),
( 'Santa Fe'),
( 'Santiago del Estero'),
( 'Tierra del Fuego'),
( 'Tucumán');

-- Modifica la longitud de la columna LOCACLIDAD a un valor mayor (ajusta según tus necesidades)
ALTER TABLE LOCALIDADES
ALTER COLUMN LOCACLIDAD VARCHAR(50);
-- Inserciones de localidades en la tabla LOCALIDADES para algunas provincias de Argentina
SELECT * FROM Localidades
INSERT INTO LOCALIDADES (LOCACLIDAD,ID_PROVINCIA)
VALUES
( 'La Plata', 1), -- Buenos Aires
( 'Mar del Plata', 1), -- Buenos Aires
( 'Córdoba', 2), -- Córdoba
( 'Villa Carlos Paz', 2), -- Córdoba
( 'Mendoza', 3), -- Mendoza
( 'San Rafael', 3), -- Mendoza
( 'Santa Rosa', 4), -- La Pampa
( 'General Pico', 4); -- La Pampa
SELECT * FROM LOCALIDADES

-- Inserciones de 5 barrios ficticios en la tabla BARRIOS para cada localidad en Argentina

ALTER TABLE BARRIOS
ALTER COLUMN BARRIOS VARCHAR(50);
-- Buenos Aires
INSERT INTO BARRIOS (BARRIOS, ID_LOCALIDAD)
VALUES
( 'Barrio Norte', 2), -- La Plata
( 'Barrio Centro', 2), -- La Plata
( 'Barrio Los Pinos', 2), -- La Plata
( 'Barrio La Loma', 2), -- La Plata
( 'Barrio San Carlos', 2) -- La Plata

-- Córdoba
INSERT INTO BARRIOS ( BARRIOS, ID_LOCALIDAD)
VALUES
( 'Barrio Güemes', 3), -- Córdoba
( 'Barrio Nueva Córdoba', 3), -- Córdoba
( 'Barrio Alberdi', 3), -- Córdoba
( 'Barrio General Paz', 3), -- Córdoba
( 'Barrio Observatorio', 3) -- Córdoba

-- Mendoza
INSERT INTO BARRIOS ( BARRIOS, ID_LOCALIDAD)
VALUES
( 'Barrio Ciudad', 5), -- Mendoza
( 'Barrio Godoy Cruz', 5), -- Mendoza
( 'Barrio Las Heras', 5), -- Mendoza
( 'Barrio Maipú', 5), -- Mendoza
( 'Barrio Luján de Cuyo', 5) -- Mendoza

-- La Pampa
INSERT INTO BARRIOS ( BARRIOS, ID_LOCALIDAD)
VALUES
( 'Barrio Centro', 7), -- Santa Rosa
( 'Barrio Malvinas', 7), -- Santa Rosa
( 'Barrio El Faro', 7), -- Santa Rosa
( 'Barrio Los Troncos', 7), -- Santa Rosa
( 'Barrio San Martín', 7); -- Santa Rosa

SELECT * FROM PROVINCIAS
SELECT * FROM LOCALIDADES
SELECT * FROM BARRIOS
INSERT INTO TIPO_FORMATO ( DESCRIPCION)
VALUES
('2D'),
( '3D'),
( 'IMAX'),
( '4D'),
( 'Dolby Atmos');

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
INSERT INTO CINES (ID_BARRIO, NOMBRE_CINE)
VALUES
(2, 'Cine Buenos Aires '),
(2, 'Cine La Plata '),
(3, 'Cine Los Pinos '),
(4, 'Cine La Loma '),
(5, 'Cine San Carlos');

select * from SALAS
select * from FUNCIONES
INSERT INTO SALAS(ID_CINE,CANTIDAD_ASIENTOS, id_butaca,id_funcion) 
VALUES
(2,18,1,5),
(2,18,12,5),
(2,18,3,6),
(2,18,2,7),
(2,18,13,5),
(2,18,7,5),
(2,18,10,5),
(2,18,11,5),
(2,18,6,5),
(2,18,8,5);
select * from salas


INSERT INTO CLASIFICACION ( DESCRIPCION)
VALUES
( 'Apta para todo púb'),
( 'Mayores de 13 años'),
( 'Mayores de 16 años'),
( 'Mayores de 18 años'),
( 'Restringida');

alter table FORMA_PAGO
alter column descripcion varchar (50);
INSERT INTO FORMA_PAGO (DESCRIPCION)
VALUES
( 'Tarjeta de crédito'),
( 'Efectivo'),
( 'Transferencia bancaria'),
( 'PayPal'),
( 'Cheque'),
( 'Pago móvil');

INSERT INTO TIPOS_DOC ( DESCRIPCION)
VALUES
( 'DNI'),
( 'Pasaporte'),
( 'Cédula de identidad'),
( 'Licencia de conducir'),
( 'Tarjeta de residente');

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

-- Inserciones de Actores sin ID con Fechas Invertidas
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

INSERT INTO DIRECTORES (NOMBRE, APELLIDO)
VALUES
('Steven', 'Spielberg'),
('Christopher', 'Nolan'),
('Martin', 'Scorsese'),
('Quentin', 'Tarantino'),
('James', 'Cameron'),
('Peter', 'Jackson'),
('Ridley', 'Scott'),
('James', 'Cameron'),
('George', 'Lucas'),
('Tim', 'Burton'),
('Alfred', 'Hitchcock'),
('Stanley', 'Kubrick'),
('Robert', 'Zemeckis'),
('Catherine', 'Hardwicke'),
('Spike', 'Lee'),
('Clint', 'Eastwood'),
('Woody', 'Allen'),
('Greta', 'Gerwig'),
('Peter', 'Farrelly'),
('Francis', 'Ford Coppola');





alter table EMPLEADOS
alter column EMAIL varchar (50)



-- Inserciones de empleados
INSERT INTO EMPLEADOS ( NOMBRE_EMPLEADO, APELLIDO_EMPLEADO, EMAIL, ID_BARRIO, ID_CARGO)
VALUES
('Juan', 'Pérez', 'juan.perez@email.com', 2, 1), -- Cargo 1, Barrio 1
('María', 'González', 'maria.gonzalez@email.com', 2, 2), -- Cargo 2, Barrio 2
('Carlos', 'Martínez', 'carlos.martinez@email.com', 3, 1), -- Cargo 1, Barrio 3
('Laura', 'Rodríguez', 'laura.rodriguez@email.com', 4, 2), -- Cargo 2, Barrio 4
('Pedro', 'López', 'pedro.lopez@email.com', 5, 1); -- Cargo 1, Barrio 5
-- Continúa con más empleados si es necesario

alter table PAIS_ORIGEN
alter column PAIS VARCHAR (50)
-- Inserciones de países de origen
INSERT INTO PAIS_ORIGEN (PAIS)
VALUES
('Argentina'),
('Estados Unidos'),
('Reino Unido'),
('Francia'),
('España'),
('Italia'),
('Alemania'),
('Canadá'),
('Australia'),
('Japón'),
('Brasil'),
('México'),
('Chile'),
('Colombia');
-- Continúa con más inserciones de países si es necesario


-- Películas Taquilleras
set dateformat dMy
INSERT INTO PELICULAS (TITULO, DURACION, ID_CLASIFICACION, ID_IDIOMA, FEC_ESTRENO, ID_PAIS_ORIGEN)
VALUES
('Casablanca', '1:42:00', 4, 1, '26-11-1942', 6), -- Casablanca (1942)
('Lo que el Viento se Llevó', '3:53:00', 4, 1, '15-12-1939', 7), -- Lo que el Viento se Llevó (1939)
('El Padrino', '2:55:00', 3, 2, '15-03-1972', 8), -- El Padrino (1972)
('Cantando Bajo la Lluvia', '1:43:00', 4, 1, '27-03-1952', 9), -- Cantando Bajo la Lluvia (1952)
('Tiempos Modernos', '1:27:00', 4, 1, '05-02-1936', 10);
-- Películas Antiguas (Continuación)
INSERT INTO PELICULAS (TITULO, DURACION, ID_CLASIFICACION, ID_IDIOMA, FEC_ESTRENO, ID_PAIS_ORIGEN)
VALUES
('Ciudadano Kane', '1:59:00', 4, 1, '05-09-1941', 11), -- Ciudadano Kane (1941)
('El Mago de Oz', '1:42:00', 4, 1, '15-08-1939', 12), -- El Mago de Oz (1939)
('Lo que el Viento se Llevó', '3:58:00', 4, 1, '20-01-1961', 7), -- Lo que el Viento se Llevó (Reestreno en 1961)
('12 Hombres en Pugna', '1:36:00', 4, 1, '10-04-1957', 13), -- 12 Hombres en Pugna (1957)
('El Ciudadano Ilustre', '1:58:00', 4, 1, '08-09-2016', 14); -- El Ciudadano Ilustre (2016)

-- Películas (Continuación)
INSERT INTO PELICULAS (TITULO, DURACION, ID_CLASIFICACION, ID_IDIOMA, FEC_ESTRENO, ID_PAIS_ORIGEN)
VALUES
('El Resplandor', '2:24:00', 2, 1, '23-05-1980', 5), -- El Resplandor (1980)
('Blade Runner', '1:57:00', 2, 2, '25-06-1982', 2), -- Blade Runner (1982)
('ET, el Extraterrestre', '1:55:00', 3, 4, '11-06-1982', 3), -- ET, el Extraterrestre (1982)
('Star Wars: Episodio IV - Una Nueva Esperanza', '2:01:00', 2, 3, '25-05-1977', 4), -- Star Wars: Episodio IV (1977)
('Los Cazafantasmas', '1:45:00', 3, 2, '08-06-1984', 5); -- Los Cazafantasmas (1984)

-- Películas de Marvel
INSERT INTO PELICULAS (TITULO, DURACION, ID_CLASIFICACION, ID_IDIOMA, FEC_ESTRENO, ID_PAIS_ORIGEN)
VALUES
('Iron Man', '2:06:00', 3, 1, '02-05-2008', 4), -- Iron Man (2008)
('Los Vengadores', '2:23:00', 2, 1, '25-04-2012', 4), -- Los Vengadores (2012)
('Guardianes de la Galaxia', '2:01:00', 3, 1, '31-07-2014', 4), -- Guardianes de la Galaxia (2014)
('Black Panther', '2:14:00', 2, 1, '13-02-2018', 4), -- Black Panther (2018)
('Avengers: Endgame', '3:02:00', 2, 1, '24-04-2019', 4); -- Avengers: Endgame (2019)


-- Día 1
set dateformat ymd
INSERT INTO FUNCIONES (HORA, FECHA, PRECIO_ACTUAL, ID_TIPO_FORMATO, id_pelicula) --dawwad
VALUES 
('14:00:00', '2023-11-17', 10.00, 1,21), 
('17:30:00', '2023-11-17', 12.50, 2,22),
('20:00:00', '2023-11-17', 15.00, 3,23),
('22:30:00', '2023-11-17', 13.50, 1,24),
('14:00:00', '2023-11-18', 10.00, 1,25), 
('17:30:00', '2023-11-18', 12.50, 2,26),
('20:00:00', '2023-11-18', 15.00, 3,27),
('22:30:00', '2023-11-18', 13.50, 1,28),
('14:00:00', '2023-11-19', 10.00, 1,29), 
('17:30:00', '2023-11-19', 12.50, 2,21),
('20:00:00', '2023-11-19', 15.00, 3,31),
('22:30:00', '2023-11-19', 13.50, 1,22),
('14:00:00', '2023-11-20', 10.00, 1,33), 
('17:30:00', '2023-11-20', 12.50, 2,34),
('20:00:00', '2023-11-20', 15.00, 3,25),
('22:30:00', '2023-11-20', 13.50, 1,26),
('14:00:00', '2023-11-21', 10.00, 1,27), 
('17:30:00', '2023-11-21', 12.50, 2,38),
('20:00:00', '2023-11-21', 15.00, 3,39),
('22:30:00', '2023-11-21', 13.50, 1,21),
('14:00:00', '2023-11-22', 10.00, 1,22), 
('17:30:00', '2023-11-22', 12.50, 2,23),
('20:00:00', '2023-11-22', 15.00, 3,40),
('22:30:00', '2023-11-22', 13.50, 1,25),
('14:00:00', '2023-11-23', 10.00, 1,26), 
('17:30:00', '2023-11-23', 12.50, 2,27),
('20:00:00', '2023-11-23', 15.00, 3,28),
('22:30:00', '2023-11-24', 13.50, 1,29),
('14:00:00', '2023-11-24', 10.00, 1,21), 
('17:30:00', '2023-11-24', 12.50, 2,32),
('20:00:00', '2023-11-24', 15.00, 3,33),
('22:30:00', '2023-11-25', 13.50, 1,34),
('14:00:00', '2023-11-25', 10.00, 1,35), 
('17:30:00', '2023-11-25', 12.50, 2,36),
('20:00:00', '2023-11-25', 15.00, 3,37),
('22:30:00', '2023-11-26', 13.50, 1,38),
('14:00:00', '2023-11-26', 10.00, 1,39), 
('17:30:00', '2023-11-26', 12.50, 2,30),
('20:00:00', '2023-11-26', 15.00, 3,31),
('22:30:00', '2023-11-27', 13.50, 1,32),
('14:00:00', '2023-11-27', 10.00, 1,33), 
('17:30:00', '2023-11-27', 12.50, 2,34),
('20:00:00', '2023-11-27', 15.00, 3,35),
('22:30:00', '2023-11-28', 13.50, 1,36);


select * from PELICULAS
select * from SALAS
select * from CINES
select * from CLIENTES
select * from EMPLEADOS
select * from FUNCIONES
select * from ACTORES

-- Inserciones en la tabla ACTORES_PELICULAS
--INSERT INTO ACTORES_PELICULAS (ID_ACTOR, ID_PELICULA)
--VALUES
--(1, 1),  -- Brad Pitt en Casablanca (1942)
--(2, 2),  -- Tom Hanks en Lo que el Viento se Llevó (1939)
--(3, 3),  -- Meryl Streep en El Padrino (1972)
--(4, 4),  -- Angelina Jolie en Cantando Bajo la Lluvia (1952)
--(5, 5),  -- Leonardo DiCaprio en Tiempos Modernos (1936)
--(6, 6),  -- Tom Cruise en Ciudadano Kane (1941)
--(7, 7),  -- Julia Roberts en El Mago de Oz (1939)
--(8, 8),  -- Johnny Depp en Lo que el Viento se Llevó (Reestreno en 1961)
--(9, 9),  -- Will Smith en 12 Hombres en Pugna (1957)
--(10, 10), -- Scarlett Johansson en El Ciudadano Ilustre (2016)
--(11, 11), -- Robert Downey Jr. en El Resplandor (1980)
--(12, 12), -- Jennifer Lawrence en Blade Runner (1982)
--(13, 13), -- Denzel Washington en ET, el Extraterrestre (1982)
--(14, 14), -- Charlize Theron en Star Wars: Episodio IV (1977)
--(15, 15), -- Matt Damon en Los Cazafantasmas (1984)
--(16, 16), -- Nicole Kidman en Iron Man (2008)
--(17, 17), -- Bradley Cooper en Los Vengadores (2012)
--(18, 18), -- Natalie Portman en Guardianes de la Galaxia (2014)
--(19, 19), -- Chris Hemsworth en Black Panther (2018)
--(20, 20);
--INSERT INTO ACTORES_PELICULAS (ID_ACTOR, ID_PELICULA)
--VALUES-- Anne Hathaway en Avengers: Endgame (2019)
--(11,20),
--(19,20),
--(10,20);
-- Insertar productos en la tabla PRODUCTOS_CANDY_BAR
INSERT INTO PRODUCTOS_CANDY_BAR (NOMBRE, DESCRIPCION, PRECIO)
VALUES
    ('Palomitas', 'Bolsa grande de palomitas', 5.99),
    ('Refresco', 'Lata de refresco', 2.49),
    ('Nachos', 'Bandeja de nachos con queso', 4.99),
    ('Chocolate', 'Barra de chocolate', 1.99);
	-- Insertar ventas en la tabla VENTAS_CANDY_BAR


-- Insertar butacas
insert into BUTACAS (NRO_BUTACA, FILA)
VALUES (1,'A'),
	   (2,'A'),
	   (3,'A'),
	   (4,'A'),
	   (5,'A'),
	   (6,'A'),
	   (7,'B'),
	   (8,'B'),
	   (9,'B'),
	   (10,'B'),
	   (11,'B'),
	   (12,'B'),
	   (13,'C'),
	   (14,'C'),
	   (15,'C'),
	   (16,'C'),
	   (17,'C'),
	   (18,'C');
	   SELECT * FROM SALAS
	   SELECT * FROM BUTACAS
--INSERT butacas_salas(id_butaca,id_sala)
--VALUES(1,1),
--	  (2,1),
--	  (3,1),
--	  (4,1),
--	  (5,1),
--	  (6,1),
--	  (7,1),
--	  (8,1),
--	  (9,1),
--	  (10,1),
--	  (11,1),
--	  (12,1),
--	  (13,1),
--	  (14,1),
--	  (15,1),
--	  (16,1),
--	  (17,1),
--	  (18,1);


-- Insert para la tabla CLIENTES
INSERT INTO CLIENTES (NOMBRE_CLIENTE, APELLIDO_CLIENTE, ID_TIPO_DOC, DOCUMENTO, TELEFONO, EMAIL)
VALUES
    ('Juan', 'Pérez', 1, 12345678, 987654321, 'juan.perez@example.com'),
    ('María', 'González', 2, 23456789, 876543210, 'maria.gonzalez@example.com'),
    ('Carlos', 'López', 1, 34567890, 765432109, 'carlos.lopez@example.com'),
    ('Laura', 'Martínez', 2, 45678901, 654321098, 'laura.martinez@example.com'),
    ('Luis', 'Ramírez', 1, 56789012, 543210987, 'luis.ramirez@example.com'),
    ('Ana', 'Sánchez', 2, 67890123, 432109876, 'ana.sanchez@example.com'),
    ('Javier', 'Hernández', 1, 78901234, 321098765, 'javier.hernandez@example.com'),
    ('Sofía', 'Díaz', 2, 89012345, 210987654, 'sofia.diaz@example.com'),
    ('Carlos', 'González', 1, 12345678, 987654321, 'carlos.gonzalez@example.com'),
    ('Laura', 'Martínez', 2, 23456789, 876543219, 'laura.martinez@example.com'),
    ('Roberto', 'Pérez', 1, 34567890, 765432198, 'roberto.perez@example.com'),
    ('Isabel', 'López', 2, 45678901, 654321987, 'isabel.lopez@example.com'),
    ('Ana', 'Ramírez', 1, 56789012, 543219876, 'ana.ramirez@example.com'),
    ('Javier', 'Sánchez', 2, 67890123, 432198765, 'javier.sanchez@example.com'),
    ('Marta', 'Torres', 1, 78901234, 321987654, 'marta.torres@example.com'),
    ('Andrés', 'López', 2, 89012345, 219876543, 'andres.lopez@example.com'),
    ('Jennifer', 'Lopez', 1, 12345678, 555555555, 'jlo@example.com'),
    ('Brad', 'Pitt', 2, 23456789, 666666666, 'brad@example.com'),
    ('Angelina', 'Jolie', 1, 34567890, 777777777, 'angelina@example.com'),
    ('Leonardo', 'DiCaprio', 2, 45678901, 888888888, 'leo@example.com'),
    ('Lionel', 'Messi', 1, 20345678, 1122334455, 'lionel@example.com'),
    ('Diego', 'Maradona', 2, 30456789, 2233445566, 'diego@example.com'),
    ('Carlos', 'Gardel', 1, 40567890, 3344556677, 'carlos@example.com'),
    ('Eva', 'Perón', 2, 50678901, 4455667788, 'eva@example.com'),
    ('Marta', 'Minujin', 1, 60789012, 5566778899, 'marta@example.com'),
    ('Jorge Luis', 'Borges', 2, 70890123, 6677889900, 'borges@example.com'),
    ('Susana', 'Giménez', 1, 80901234, 7788990011, 'susana@example.com'),
    ('René', 'Favaloro', 2, 90012345, 8899001122, 'rene@example.com'),
    ('Juan', 'Pérez', 1, 56789012, 5566778899, 'juanperez@example.com'),
    ('Ana', 'García', 2, 67890123, 6677889900, 'anagarcia@example.com'),
    ('Luis', 'Rodríguez', 1, 78901234, 7788990011, 'luisrodriguez@example.com'),
    ('Laura', 'Martínez', 2, 89012345, 8899001122, 'lauramartinez@example.com'),
    ('María', 'López', 1, 90123456, 9000111222, 'marialopez@example.com'),
    ('Carlos', 'Fernández', 2, 12345678, 1001112223, 'carlosfernandez@example.com'),
    ('Elena', 'Gómez', 1, 23456789, 1112223344, 'elenagomez@example.com'),
    ('Pedro', 'Sánchez', 2, 34567890, 2223334455, 'pedrosanchez@example.com');

INSERT INTO COMPROBANTES (ID_CLIENTE, ID_EMPLEADO, FECHA, ID_CINE)
VALUES
    (1, 3, '2023-11-03 12:30:00', 2),
    (2, 3, '2023-11-03 14:45:00', 2),
    (3, 3, '2023-11-03 17:15:00', 3),
    (4, 4, '2023-11-03 19:30:00', 2),
    (5, 5, '2023-11-03 20:15:00', 2),
    (6, 5, '2023-11-03 21:30:00', 3),
    (7, 4, '2023-11-03 16:45:00', 2),
    (8, 4, '2023-11-03 19:00:00', 3),
    (6, 5, '2023-11-04 08:15:00', 2),
    (7, 5, '2023-11-02 20:30:00', 3),
    (8, 4, '2023-11-01 17:45:00', 2),
    (9, 4, '2023-11-01 18:00:00', 3),
    (5, 5, '2023-11-03 20:15:00', 2),
    (6, 5, '2023-11-03 21:30:00', 3),
    (7, 4, '2023-11-03 16:45:00', 2),
    (8, 4, '2023-11-03 19:00:00', 3),
    (6, 5, '2023-11-04 08:15:00', 2),
    (7, 5, '2023-11-02 20:30:00', 3),
    (8, 4, '2023-11-01 17:45:00', 2),
    (9, 4, '2023-11-01 18:00:00', 3),
    (5, 5, '2023-10-10 20:15:00', 2),
    (6, 5, '2023-10-09 21:30:00', 3),
    (7, 4, '2023-10-08 16:45:00', 2),
    (8, 4, '2023-10-07 19:00:00', 3),
    (6, 5, '2023-10-06 08:15:00', 2),
    (7, 5, '2023-10-05 20:30:00', 3),
    (8, 4, '2023-10-04 17:45:00', 2),
    (9, 4, '2023-10-03 18:00:00', 3),
    (6, 5, '2023-09-10 20:15:00', 2),
    (7, 5, '2023-09-09 21:30:00', 3),
    (8, 4, '2023-09-08 16:45:00', 2),
    (10, 4, '2023-09-07 19:00:00', 3),
    (12, 5, '2023-09-06 08:15:00', 2),
    (13, 5, '2023-09-05 20:30:00', 3),
    (14, 4, '2023-09-04 17:45:00', 2),
    (15, 4, '2023-09-03 18:00:00', 3),
    (1, 3, '2023-11-03 12:30:00', 2),
    (2, 3, '2023-11-03 14:45:00', 2),
    (3, 3, '2023-11-03 17:15:00', 3),
    (4, 4, '2023-11-03 19:30:00', 2),
    (5, 5, '2023-11-03 20:15:00', 2),
    (6, 5, '2023-11-03 21:30:00', 3),
    (7, 4, '2023-11-03 16:45:00', 2),
    (8, 4, '2023-11-03 19:00:00', 3),
    (6, 5, '2023-11-04 08:15:00', 2),
    (7, 5, '2023-11-02 20:30:00', 3),
    (8, 4, '2023-11-01 17:45:00', 2),
    (9, 4, '2023-11-01 18:00:00', 3),
    (5, 5, '2023-11-03 20:15:00', 2),
    (6, 5, '2023-11-03 21:30:00', 3),
    (7, 4, '2023-11-03 16:45:00', 2),
    (8, 4, '2023-11-03 19:00:00', 3),
    (6, 5, '2023-11-04 08:15:00', 2),
    (7, 5, '2023-11-02 20:30:00', 3),
    (8, 4, '2023-11-01 17:45:00', 2),
    (9, 4, '2023-11-01 18:00:00', 3),
    (5, 5, '2023-10-10 20:15:00', 2),
    (6, 5, '2023-10-09 21:30:00', 3),
    (7, 4, '2023-10-08 16:45:00', 2),
    (10, 4, '2023-10-07 19:00:00', 3),
    (12, 5, '2023-10-06 08:15:00', 2),
    (13, 5, '2023-10-05 20:30:00', 3),
    (14, 4, '2023-10-04 17:45:00', 2),
    (15, 4, '2023-10-03 18:00:00', 3),
    (16, 4, '2023-10-02 19:15:00', 2),
    (17, 5, '2023-10-01 22:30:00', 3),
    (1, 3, '2022-08-03 12:30:00', 2),
    (2, 3, '2022-08-03 14:45:00', 2),
    (3, 3, '2022-08-03 17:15:00', 3),
    (4, 4, '2022-08-03 19:30:00', 2),
    (5, 5, '2022-08-03 20:15:00', 2),
    (6, 5, '2022-08-03 21:30:00', 3),
    (7, 4, '2022-08-03 16:45:00', 2),
    (8, 4, '2022-08-03 19:00:00', 3),
    (6, 5, '2022-08-04 08:15:00', 2),
    (7, 5, '2022-08-02 20:30:00', 3),
    (8, 4, '2022-08-01 17:45:00', 2),
    (9, 4, '2022-08-01 18:00:00', 3),
    (5, 5, '2022-07-10 20:15:00', 2),
    (6, 5, '2022-07-09 21:30:00', 3),
    (7, 4, '2022-07-08 16:45:00', 2),
    (10, 4, '2022-07-07 19:00:00', 3),
    (12, 5, '2022-07-06 08:15:00', 2),
    (13, 5, '2022-07-05 20:30:00', 3),
    (14, 4, '2022-07-04 17:45:00', 2),
    (15, 4, '2022-07-03 18:00:00', 3),
    (16, 4, '2022-07-02 19:15:00', 2),
    (17, 5, '2022-07-01 22:30:00', 3),
    (1, 3, '2023-11-03 12:30:00', 2),
    (2, 3, '2023-11-03 14:45:00', 2),
    (3, 3, '2023-11-03 17:15:00', 3),
    (4, 4, '2023-11-03 19:30:00', 2),
    (5, 5, '2023-11-03 20:15:00', 2),
    (6, 5, '2023-11-03 21:30:00', 3),
    (7, 4, '2023-11-03 16:45:00', 2),
    (8, 4, '2023-11-03 19:00:00', 3),
    (6, 5, '2023-11-04 08:15:00', 2),
    (7, 5, '2023-11-02 20:30:00', 3),
    (8, 4, '2023-11-01 17:45:00', 2),
    (9, 4, '2023-11-01 18:00:00', 3),
    (5, 5, '2023-11-03 20:15:00', 2),
    (6, 5, '2023-11-03 21:30:00', 3),
    (7, 4, '2023-11-03 16:45:00', 2),
    (8, 4, '2023-11-03 19:00:00', 3),
    (6, 5, '2023-11-04 08:15:00', 2),
    (7, 5, '2023-11-02 20:30:00', 3),
    (8, 4, '2023-11-01 17:45:00', 2),
    (9, 4, '2023-11-01 18:00:00', 3),
    (5, 5, '2023-10-10 20:15:00', 2),
    (6, 5, '2023-10-09 21:30:00', 3),
    (7, 4, '2023-10-08 16:45:00', 2),
    (8, 4, '2023-10-07 19:00:00', 3),
    (6, 5, '2023-10-06 08:15:00', 2),
    (7, 5, '2023-10-05 20:30:00', 3),
    (8, 4, '2023-10-04 17:45:00', 2),
    (9, 4, '2023-10-03 18:00:00', 3),
    (6, 5, '2023-09-10 20:15:00', 2),
    (7, 5, '2023-09-09 21:30:00', 3),
    (8, 4, '2023-09-08 16:45:00', 2),
    (10, 4, '2023-09-07 19:00:00', 3),
    (12, 5, '2023-09-06 08:15:00', 2),
    (13, 5, '2023-09-05 20:30:00', 3),
    (14, 4, '2023-09-04 17:45:00', 2),
    (15, 4, '2023-09-03 18:00:00', 3),
    (1, 3, '2023-11-03 12:30:00', 2),
    (2, 3, '2023-11-03 14:45:00', 2),
    (3, 3, '2023-11-03 17:15:00', 3),
    (4, 4, '2023-11-03 19:30:00', 2),
    (5, 5, '2023-11-03 20:15:00', 2),
    (6, 5, '2023-11-03 21:30:00', 3),
    (7, 4, '2023-11-03 16:45:00', 2),
    (8, 4, '2023-11-03 19:00:00', 3),
    (6, 5, '2023-11-04 08:15:00', 2),
    (7, 5, '2023-11-02 20:30:00', 3),
    (8, 4, '2023-11-01 17:45:00', 2),
    (9, 4, '2023-11-01 18:00:00', 3),
    (5, 5, '2023-11-03 20:15:00', 2),
    (6, 5, '2023-11-03 21:30:00', 3),
    (7, 4, '2023-11-03 16:45:00', 2),
    (8, 4, '2023-11-03 19:00:00', 3),
    (6, 5, '2023-11-04 08:15:00', 2),
    (7, 5, '2023-11-02 20:30:00', 3),
    (8, 4, '2023-11-01 17:45:00', 2),
    (9, 4, '2023-11-01 18:00:00', 3),
    (5, 5, '2023-10-10 20:15:00', 2),
    (6, 5, '2023-10-09 21:30:00', 3),
    (7, 4, '2023-10-08 16:45:00', 2),
    (10, 4, '2023-10-07 19:00:00', 3),
    (12, 5, '2023-10-06 08:15:00', 2),
    (13, 5, '2023-10-05 20:30:00', 3),
    (14, 4, '2023-10-04 17:45:00', 2),
    (15, 4, '2023-10-03 18:00:00', 3),
    (16, 4, '2023-10-02 19:15:00', 2),
    (17, 5, '2023-10-01 22:30:00', 3),
    (1, 3, '2022-08-03 12:30:00', 2),
    (2, 3, '2022-08-03 14:45:00', 2),
    (3, 3, '2022-08-03 17:15:00', 3),
    (4, 4, '2022-08-03 19:30:00', 2),
    (5, 5, '2022-08-03 20:15:00', 2),
    (6, 5, '2022-08-03 21:30:00', 3),
    (7, 4, '2022-08-03 16:45:00', 2),
    (8, 4, '2022-08-03 19:00:00', 3),
    (6, 5, '2022-08-04 08:15:00', 2),
    (7, 5, '2022-08-02 20:30:00', 3),
    (8, 4, '2022-08-01 17:45:00', 2),
    (9, 4, '2022-08-01 18:00:00', 3),
    (5, 5, '2022-07-10 20:15:00', 2),
    (6, 5, '2022-07-09 21:30:00', 3),
    (7, 4, '2022-07-08 16:45:00', 2),
    (10, 4, '2022-07-07 19:00:00', 3),
    (12, 5, '2022-07-06 08:15:00', 2),
    (10, 4, '2022-07-07 19:00:00', 3),
    (12, 5, '2022-07-06 08:15:00', 2);
	

select * from COMPROBANTES
	INSERT INTO Peliculas_Genero(id_pelicula,id_genero) --awdaw
	VALUES(21,9),
		  (22,8),
		  (22,1),
		  (23,3),
		  (23,1),
		  (24,3),
		  (25,2),
		  (26,5),
		  (37,1),
		  (37,4),
		  (38,1),
		  (39,6),
		  (30,1),
		  (30,4),
		  (21,4),
		  (32,4),
		  (33,4),
		  (34,1),
		  (34,4),
		  (35,1),
		  (35,4),
		  (36,1),
		  (36,2),
		  (27,1),
		  (37,2),
		  (37,4),
		  (28,1),
		  (28,2),
		  (28,5),
		  (29,1),
		  (29,4),
		  (30,1),
		  (30,4),
		  (30,6);

		 -- select * from Pelicula_Funciones
		  select * from PELICULAS
		 -- select * from FUNCIONES
		  	


		  
			
			--select * from DETALLE_COMPROBANTE
			--select * from VENTAS_CANDY_BAR --
			--select * from butacas_salas
			--select * from Pelicula_Funciones--
			--SELECT * FROM PRODUCTOS_CANDY_BAR
			--insert into VENTAS_CANDY_BAR(ID_COMPROBANTE,ID_PRODUCTO_CANDY_BAR, CANTIDAD,PRECIO_TOTAL)
			--values (1,1,1,10.00),
			--		(2,2,2,14.00),
			--		(3,3,1,9.00),
			--		(4,4,1,5.00),
			--		(5,1,1,10.00),
			--		(6,2,1,7.00),
			--		(7,3,1,9.00),
			--		(8,4,1,5.00),
			--		(9,1,1,10.00),
			--		(10,2,1,7.00),
			--		(11,3,1,9.00),
			--		(12,4,1,5.00),
			--		(13,4,1,5.00),
			--		(14,1,1,10.00),
			--		(15,2,1,7.00),
			--		(16,1,1,10.00),
			--		(17,1,1,10.00),
			--		(18,1,1,10.00);
					select * from PELICULAS
					select * from FUNCIONES
	--				INSERT INTO Pelicula_Funciones(id_funcion,id_pelicula)
	--				values (1,1),
	--					   (1,2),
	--					   (1,3),
	--					   (1,4),
	--					   (2,5),
	--					   (2,6),
	--					   (2,7),
	--					   (2,8),
	--					   (3,9),
	--					   (3,10),
	--					   (3,11),
	--					   (3,12),
	--					   (4,13),
	--					   (4,14),
	--					   (4,15),
	--					   (4,16),
	--					   (5,17),
	--					   (5,18),
	--					   (5,19),
	--					   (5,20),
	--					   (6,1),
	--					   (6,2),
	--					   (6,3),
	--					   (6,4),
	--					   (7,5),
	--					   (7,6),
	--					   (7,1),
	--					   (7,2),
	--					   (8,3),
	--					   (8,4),
	--					   (8,5),
	--					   (8,6),
	--					   (9,7),
	--					   (9,8),
	--					   (9,9),
	--					   (9,10),
	--					   (10,11),
	--					   (10,12),
	--					   (10,13),
	--					   (10,14),
	--					   (11,15),
	--					   (12,16),
	--					   (12,17),
	--					   (12,18),
	--					   (12,19),
	--					   (13,20),
	--					   (13,1),
	--					   (13,2),
	--					   (13,3),
	--					   (14,4),
	--					   (14,5),
	--					   (14,6),
	--					   (15, 7),
 --   (15, 8),
 --   (15, 9),
 --   (15, 10),
 --   (16, 11),
 --   (16, 12),
 --   (16, 13),
 --   (16, 14),
 --   (17, 15),
 --   (18, 16),
 --   (18, 17),
 --   (18, 18),
 --   (18, 19),
 --   (19, 20),
 --   (19, 1),
 --   (19, 2),
 --   (19, 3),
 --   (20, 4),
 --   (20, 5),
 --   (20, 6),
 --   (21, 7),
 --   (21, 8),
 --   (21, 9),
 --   (21, 10),
 --   (22, 11),
 --   (22, 12),
 --   (22, 13),
 --   (22, 14),
 --   (23, 15),
 --   (24, 16),
 --   (24, 17),
 --   (24, 18),
 --   (25, 19),
 --   (25, 20),
 --   (25, 1),
 --   (25, 2),
 --   (26, 3),
 --   (26, 4),
 --   (26, 5),
 --   (26, 6),
 --   (27, 7),
 --   (27, 8),
 --   (27, 9),
 --   (27, 10),
 --   (28, 11),
 --   (28, 12),
 --   (28, 13),
 --   (28, 14),
 --   (29, 15),
 --   (29, 16),
 --   (29, 17),
 --   (29, 18),
 --   (30, 19),
 --   (30, 20),
 --   (30, 1),
 --   (30, 2),
 --   (31, 3),
 --   (31, 4),
 --   (31, 5),
 --   (31, 6),
 --   (32, 7),
 --   (32, 8),
 --   (32, 9),
 --   (32, 10),
 --   (33, 11),
 --   (33, 12),
 --   (33, 13),
 --   (33, 14),
 --   (34, 15),
 --   (34, 16),
 --   (34, 17),
 --   (34, 18),
 --   (35, 19),
 --   (35, 20),
 --   (35, 1),
 --   (35, 2),
 --   (35, 3),
 --   (35, 4),
 --   (35, 5),
 --   (35, 6);
	--insert into FUNCIONES_SALAS (ID_FUNCION,ID_SALA)
	--values (1,1),
	--		(2,1),
	--		(3,1),
	--		(4,1),
	--		(5,1),
	--		(6,1),
	--		(7,1),
	--		(8,1),
	--		(9,1),
	--		(10,1),
	--		(11,1),
	--		(12,1),
	--		(13,1),
	--		(14,1),
	--		(15,1),
	--		(16,1),
	--		(17,1),
	--		(18,1),
	--		(19,1),
	--		(20,1);


	select * from SALAS

INSERT INTO DETALLE_COMPROBANTE (id_comprobante, id_butaca, id_sala, id_pelicula, id_funcion, precio_total) --asd
VALUES
    (1, 4, 4, 2, 5, 25.00),
    (2,  2, 5, 3, 6, 30.50),
    (3,  3, 6, 2, 7, 22.75),
    (4,  4, 4, 8, 8, 28.00),
    (5,  4, 4, 8, 9, 28.00),
    (6,  4, 4, 5, 10, 25.00),
    (7,  2, 5, 3, 11, 30.50),
    (8,  3, 6, 2, 12, 22.75),
    (9,  4, 4, 2, 13, 28.00),
    (10,  5, 6, 2, 14, 20.25),
    (11,  6, 4, 5, 15, 35.75),
    (12,  7, 5, 7, 16, 27.50),
    (13,  8, 5, 3, 17, 33.25),
    (14,  10, 5, 8, 18, 18.75),
    (15,  10, 4, 9, 19, 29.50),
    (16,  11, 4, 4, 20, 24.25),
    (17,  12, 4, 1, 21, 31.00),
    (18,  13, 4, 5, 22, 15.00),
    (19,  14, 6, 8, 23, 28.50),
    (20,  15, 5, 2, 24, 22.75),
    (21,  16, 4, 7, 25, 27.00),
    (22,  17, 4, 2, 26, 32.50),
    (23,  18, 5, 6, 27, 26.75),
    (24,  4, 4, 2, 28, 21.25),
    (25,  1, 4, 3, 29, 23.00),
    (26,  1, 6, 9, 30, 29.75),
    (27, 3, 4, 4, 31, 34.25),
    (28,  3, 5, 7, 32, 27.50),
    (29,  4, 4, 2, 33, 22.00),
    (30,  5, 4, 5, 34, 30.75),
    (31,  6, 5, 5, 31, 25.25);

	select * from DETALLE_COMPROBANTE
	select * from CLIENTES
	select * from PELICULAS

	insert into usuarios( ID_EMPLEADO, USUARIO, CONTRASENIA)
    Values(1,'Manu','123')
insert into usuarios( ID_EMPLEADO, USUARIO, CONTRASENIA)
    Values(2,'MARTO','Aprobanos')