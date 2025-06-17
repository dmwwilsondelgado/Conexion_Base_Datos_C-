use base_datos_solution005;
-- Tabla de empleados
create table empleados (
    id_empleado int primary key auto_increment,
    nombre varchar(100),
    documento varchar(20) unique,
    rol varchar(50),
    correo varchar(100)
);

-- Tabla de clientes frecuentes
create table clientes (
    id_cliente int primary key auto_increment,
    nombre varchar(100),
    documento varchar(20) unique,
    telefono varchar(20),
    correo varchar(100)
);

-- Tabla de vehículos
create table vehiculos (
    placa varchar(10) primary key,
    tipo varchar(50), -- moto, carro, camioneta...
    color varchar(30),
    id_cliente int,
    foreign key (id_cliente) references clientes(id_cliente)
);

-- Tabla de ingresos y salidas
create table parqueo (
    id_registro int primary key auto_increment,
    placa varchar(10),
    id_empleado int,
    hora_ingreso datetime,
    hora_salida datetime,
    total_pago decimal(10,2),
    estado enum('EN PARQUEO', 'SALIDO') default 'EN PARQUEO',
    foreign key (placa) references vehiculos(placa),
    foreign key (id_empleado) references empleados(id_empleado)
);
