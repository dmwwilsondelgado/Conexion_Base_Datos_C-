
use base_datos_solution003;

-- Tabla de productos
create table productos (
    id_producto int primary key auto_increment,
    nombre varchar(100),
    marca varchar(50),
    tipo varchar(50),
    precio decimal(10,2),
    stock int,
    garantia varchar(50)
);

-- Tabla de clientes
create table clientes (
    id_cliente int primary key auto_increment,
    nombre varchar(100),
    identificacion varchar(20) unique,
    telefono varchar(20),
    correo varchar(100)
);

-- Tabla de facturas
create table facturas (
    id_factura int primary key auto_increment,
    id_cliente int,
    fecha datetime default current_timestamp,
    total decimal(10,2),
    foreign key (id_cliente) references clientes(id_cliente)
);

-- Tabla de detalles de factura
create table detalle_factura (
    id_detalle int primary key auto_increment,
    id_factura int,
    id_producto int,
    cantidad int,
    precio_unitario decimal(10,2),
    subtotal decimal(10,2),
    foreign key (id_factura) references facturas(id_factura),
    foreign key (id_producto) references productos(id_producto)
);


