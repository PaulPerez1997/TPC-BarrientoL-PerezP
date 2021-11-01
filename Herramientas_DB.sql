use Herramientas
go
set identity_insert [dbo].[Articulo] ON
insert [dbo].[Articulo] ([id],[nombre],[idMarca],[idCategoria],[descripcion],[precio],[peso_kg],[largo_cm],[imagenURL],[stock],[Estado]) 
values('1','Martillo mecanico','7','1','Martillo de acero con cabeza de acero y mango de fibra de vidrio','750,00','0,3','30','https://http2.mlstatic.com/D_NQ_NP_658751-MLA45542364341_042021-O.webp','100','1')
go
insert [dbo].[Articulo] ([id],[nombre],[idMarca],[idCategoria],[descripcion],[precio],[peso_kg],[largo_cm],[imagenURL],[stock],[Estado]) 
values('2','Serrucho','1','1','Serrucho costilla mango anatómico profesional dientes doble filo, 10 dientes por pulgada','1110,00','0,35','30','https://http2.mlstatic.com/D_NQ_NP_669985-MLA45874217541_052021-O.webp','50','1')
go
insert [dbo].[Articulo] ([id],[nombre],[idMarca],[idCategoria],[descripcion],[precio],[peso_kg],[largo_cm],[imagenURL],[stock],[Estado])
values('3','Pinza Universal','1','1','Pinza universal Bremen 6 pulgadas de acero','1040,00','0,2','15','https://http2.mlstatic.com/D_NQ_NP_905397-MLA46115630491_052021-O.webp','25','1')
go
insert [dbo].[Articulo] ([id],[nombre],[idMarca],[idCategoria],[descripcion],[precio],[peso_kg],[largo_cm],[imagenURL],[stock],[Estado])
values('4','Multimetro Digital','3','1','Tester multimetro digital 830D compacto con buzzer HFE 10A','470,00','0,1','6,8','https://http2.mlstatic.com/D_NQ_NP_662804-MLA31093231042_062019-O.webp','10','1')
go
insert [dbo].[Articulo] ([id],[nombre],[idMarca],[idCategoria],[descripcion],[precio],[peso_kg],[largo_cm],[imagenURL],[stock],[Estado])
values('5','Amoladora angular Bosch','4','1','Amoladora angular Bosch professional GWS 670 azul 670 W 220 V,Apta para un disco de 115 mm de diámetro, tiene mango anti vibración','8151,00','1,5',null,'https://http2.mlstatic.com/D_NQ_NP_745215-MLA47660403251_092021-O.webp','228','1')
go
insert [dbo].[Articulo] ([id],[nombre],[idMarca],[idCategoria],[descripcion],[precio],[peso_kg],[largo_cm],[imagenURL],[stock],[Estado])
values('6','Motosierra a nafta','8','1','Motosierra a nafta Daewoo,Cilindrada: 45cc, Largo de barra: 16", Capacidad del tanque de 550ml, Incluye accesorios.','15499,00','5,9',null,'https://http2.mlstatic.com/D_NQ_NP_887080-MLA43138730558_082020-O.webp','7','1')
go
set identity_insert [dbo].[Articulo] OFF
set identity_insert [dbo].[Marcas] ON
go
insert [dbo].[Marcas] ([id],[nombre]) values ('1','Bremen')
go
insert [dbo].[Marcas] ([id],[nombre]) values ('2','Stanley')
go
insert [dbo].[Marcas] ([id],[nombre]) values ('3','Black Decker')
go
insert [dbo].[Marcas] ([id],[nombre]) values ('4','Bosch')
go
insert [dbo].[Marcas] ([id],[nombre]) values ('5','Dewalt')
go
insert [dbo].[Marcas] ([id],[nombre]) values ('6','Stihl')
go
insert [dbo].[Marcas] ([id],[nombre]) values ('7','Tolsen')
go
insert [dbo].[Marcas] ([id],[nombre]) values ('8','Daewoo')
go
set identity_insert [dbo].[Marcas] OFF