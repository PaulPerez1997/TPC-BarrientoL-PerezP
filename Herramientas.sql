CREATE DATABASE Herramientas
go
use Herramientas
go
create table Marcas(
id int not null primary key identity(1,1),
nombre varchar(50) null,
)
go
create table Categorias(
id int not null primary key identity(1,1),
nombre varchar(50)  null,
)

go
create table Usuario(
dni int not null primary key,
nombre varchar(50) not null,
apellido varchar(50) not null,
nacimiento date not null,
mail varchar(50) not null,
nombreusuario varchar(50) not null,
contraseña varchar(50) not null,
telefono varchar(50) not null,
tipousuario int not null
)
go
create table Articulo(
id int not null primary key identity(1,1),
nombre varchar(50) null,
idMarca	int foreign key references Marcas(id) not null,
idCategoria int foreign key references Categorias(id) not null,
descripcion varchar(200)  null,
precio money  null,
peso_kg decimal null,
largo_cm decimal null,
imagenURL varchar(200) not null,
stock bigint not null,
Estado bit null,
)
go
create table Carrito(
id int not null primary key identity(1,1),
idusuario int not null references Usuario(dni), 
precioTotal money not null,
)
go
create table ArticuloCarrito(
id int not null foreign key references Carrito(id),
idarticulo int not null references Articulo(id),
cantidad int  null,
)



