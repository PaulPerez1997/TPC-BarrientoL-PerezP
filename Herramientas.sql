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
nombre varchar(50)  null,
apellido varchar(50)  null,
nacimiento date  null,
mail varchar(50)  null,
nombreusuario varchar(50) null,
contraseña varchar(50)  null,
telefono varchar(50) null,
administrador bit null,
)
go
create table Articulo(
id int not null primary key identity(1,1),
dniUsuario int not null foreign key references Usuario(dni),
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

create table EnVenta(
id int not null primary key identity(1,1),
Dniusuario int not null references Usuario(dni), 
IdArticulo int not null references Articulo(id),
Estado bit not null
)
create table Compra(
id int not null primary key identity(1,1),
Dniusuario int not null references Usuario(dni), 
IdArticulo int not null references Articulo(id)
)

create table CompraRealizada(
id int not null primary key identity(1,1),
Dniusuario int not null references Usuario(dni), 
IdArticulo int not null references Articulo(id),
Fecha datetime not null 
)

go
create table DetalleCompra(
id int not null primary key identity(1,1),
IDCompraRealizada int not null foreign key references CompraRealizada(id),
IDArticulo int not null,
NombreArticulo varchar(50) null,
PrecioTotal money not null,
imagenURL varchar(200) not null,
DNIComprador int not null, 
NombreUsuarioComprador varchar(50) null,
NombreComprador varchar(50) null,
ApellidoComprador varchar(50) null,
DireccionAEnviar varchar(50) null,
TelefonoComprador varchar(50) null,
DNIVendedor int not null, 
NombreUsuarioVendedor varchar(50) null,
NombreVendedor varchar(50) null,
ApellidoVendedor varchar(50) null,
TelefonoVendedor varchar(50) null
)
