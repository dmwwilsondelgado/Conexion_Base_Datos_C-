use base_datos_solution004;


-- Tabla de productos
create table productos (
    id_producto int primary key auto_increment,
    nombre varchar(100),
    categoria varchar(50),
    precio decimal(10,2),
    stock int,
    descuento decimal(5,2) default 0 -- % de descuento
);

-- Tabla de clientes
create table clientes (
    id_cliente int primary key auto_increment,
    nombre varchar(100),
    documento varchar(20) unique,
    telefono varchar(20),
    correo varchar(100)
);

-- Tabla de empleados
create table empleados (
    id_empleado int primary key auto_increment,
    nombre varchar(100),
    cargo varchar(50),
    documento varchar(20) unique,
    correo varchar(100)
);

-- Tabla de ventas
create table ventas (
    id_venta int primary key auto_increment,
    id_cliente int,
    id_empleado int,
    fecha datetime default current_timestamp,
    total decimal(10,2),
    foreign key (id_cliente) references clientes(id_cliente),
    foreign key (id_empleado) references empleados(id_empleado)
);

-- Detalle de ventas
create table detalle_venta (
    id_detalle int primary key auto_increment,
    id_venta int,
    id_producto int,
    cantidad int,
    precio_unitario decimal(10,2),
    descuento_aplicado decimal(5,2),
    subtotal decimal(10,2),
    foreign key (id_venta) references ventas(id_venta),
    foreign key (id_producto) references productos(id_producto)
);
