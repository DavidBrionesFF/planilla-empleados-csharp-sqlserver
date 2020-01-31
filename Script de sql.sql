use Clientes;

create table cliente(
	id_cliente int primary key not null identity(1,1),
	nombre varchar(50),
	apellido varchar(50),
	direccion varchar(50),
	correo varchar(50),
	telefono varchar(50),
	
);

create table pagos(
	id_pago int primary key not null identity(1,1),
	cliente int ,
	abono decimal,
	fecha_abono datetime default sysdatetime(),
	observaciones varchar(200),
	foreign key(cliente) references cliente(id_cliente)
);