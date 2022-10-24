create database CarritoBD
go
use CarritoBD
go
create table Categoria
(
Id int primary key identity,
Nombre varchar(50)
)
go
create table Producto
(
Id int primary key identity,
Nombre varchar(50),
Precio float,
FechaCreacion datetime,
Foto varchar(200),
CategoriaId int,
foreign key(CategoriaId) references Categoria)
go
insert into categoria(Nombre) values
('Aves y Cárnicos'),
('Comestible/Abarrotes'),
('Frutas')
go
insert into Producto(Nombre,Precio,FechaCreacion,CategoriaId) values 
('Aceite',20.64,getdate(),2),
('Atùn Nair en Aceite',11.91,getdate(),2),
('Azucar',18.12,getdate(),2),
('Bolillo',1.47,getdate(),2),
('Café de Grano 908 Gr',148.85,getdate(),2),
('Cafe Soluble 95 Gr',42.97,getdate(),2),
('Cajeta Coronado 550 Gr',56.08,getdate(),2),
('Chiles Jalapeños 220 Gr',7.57,getdate(),2),
('Chocolate Choco Milk 800 Gr',57.28,getdate(),2),
('Galletas Maria 850 Gr',34.80,getdate(),2),
('Aguacate Hass 1Kg',31.48,getdate(),3),
('Guayaba 1Kg',20.97,getdate(),3),
('Jicama 1Kg',13.33,getdate(),3),
('Limón con semilla 1Kg',36.07,getdate(),3),
('Manzana Amarilla 1Kg',32.84,getdate(),3),
('Manzana Roja Starking 1Kg',36.68,getdate(),3),
('Naranja 1Kg',8.30,getdate(),3),
('Papaya 1Kg',20.24,getdate(),3),
('Plátano Tabasco 1Kg',15,getdate(),3),
('Toronja 1Kg',10.46,getdate(),3)

go
create table Venta
(
Id int primary key identity,
DiaVenta datetime,
Subtotal float,
Iva float,
Total float)
go
create table ListaVenta
(
Id int primary key identity,
VentaId int,
ProductoId int,
Cantidad int,
Total float,
foreign key(VentaId) references Venta,
foreign key(ProductoId) references Producto
)


