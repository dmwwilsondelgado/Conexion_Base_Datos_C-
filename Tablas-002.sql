
use base_datos_solution002;
-- Tabla de películas
create table peliculas (
    id_pelicula int primary key auto_increment,
    titulo varchar(100) not null,
    genero varchar(50),
    duracion int, -- en minutos
    clasificacion varchar(10)
);

-- Tabla de salas
create table salas (
    id_sala int primary key auto_increment,
    nombre varchar(50) not null,
    capacidad int not null
);

-- Tabla de funciones
create table funciones (
    id_funcion int primary key auto_increment,
    id_pelicula int,
    id_sala int,
    fecha date,
    hora time,
    foreign key (id_pelicula) references peliculas(id_pelicula),
    foreign key (id_sala) references salas(id_sala)
);

-- Tabla de clientes
create table clientes (
    id_cliente int primary key auto_increment,
    nombre varchar(100),
    correo varchar(100)
);

-- Tabla de entradas
create table entradas (
    id_entrada int primary key auto_increment,
    id_funcion int,
    id_cliente int,
    cantidad int,
    fecha_compra datetime default current_timestamp,
    foreign key (id_funcion) references funciones(id_funcion),
    foreign key (id_cliente) references clientes(id_cliente)
);






