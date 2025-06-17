-- Tabla de productos
create table productos (
    id_producto int primary key auto_increment,
    nombre varchar(100) not null,
    descripcion varchar(255),
    precio decimal(10,2),
    stock_actual int not null
);

-- Tabla de movimientos de inventario
create table inventario_movimientos (
    id_movimiento int primary key auto_increment,
    id_producto int ,
    tipo_movimiento varchar(10) check (tipo_movimiento in ('entrada', 'salida')),
    cantidad int not null,
    fecha_movimiento datetime ,
    id_auditoria int,
    foreign key (id_producto) references productos(id_producto),
    foreign key(id_auditoria) references auditoria(id_auditoria)
);

-- Tabla de auditoría
create table auditoria (
    id_auditoria int primary key auto_increment,
    operacion varchar(20),
    tabla_afectada varchar(50),
    descripcion varchar(255),
    fecha datetime 
);
	