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



use base_datos_solution001;
show databases;

select * from clientes;
select * from inventario_movimientos;
describe peliculas;

describe inventario_movimientos;
select * from productos ;


describe auditoria;



alter table inventario_movimientos modify fecha_movimiento varchar(100);


create table administradores(
 id int primary key auto_increment,
 usuario varchar(20),
 pasword varchar(20)
);
insert into administradores (usuario, pasword)
values ('admin', '12345');
select * from administradores;



describe clientes;


describe clientes;