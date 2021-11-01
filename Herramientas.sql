CREATE DATABASE Herramientas
go
use Herramientas
go
create table Marcas(
id bigint not null primary key identity(1,1),
nombre varchar(50) not null,
)
go
create table Categorias(
id bigint not null primary key identity(1,1),
nombre varchar(50) not null,
)

go
create table Usuario(
dni bigint not null primary key,
nombre varchar(50) not null,
apellido varchar(50) not null,
nacimiento date not null,
mail varchar(50) not null,
nombreusuario varchar(50) not null,
contraseña varchar(50) not null,
telefono varchar(50) not null,
)
go
create table Articulo(
id bigint not null primary key identity(1,1),
nombre varchar(50) not null,
idMarca	bigint foreign key references Marcas(id) not null,
idCategoria bigint foreign key references Categorias(id) not null,
descripcion varchar(200) not null,
precio money not null,
peso_kg decimal null,
largo_cm decimal null,
imagenURL varchar(200) not null,
stock bigint not null,
Estado bit null,
)
go
create table Carrito(
id bigint not null primary key identity(1,1),
idusuario bigint not null references Usuario(dni), 
precioTotal money not null,
)
go
create table ArticuloCarrito(
id bigint not null foreign key references Carrito(id),
idarticulo bigint not null references Articulo(id),
cantidad bigint not null,
)

