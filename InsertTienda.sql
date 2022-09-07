--------------------------------------------------------------------
--------------------INSERTAR DATOS DE PROVEEDOR--------------------
-------------------------------------------------------------------
INSERT into proveedor (NITPROVEEDOR,NOMBREPROVEDOR,TELEFONOPROVEDOR,CORREOPROVEDOR) 
values (1111,'Nabor Rengifo',8249754,'empaquesc@gmail.com');
INSERT into proveedor (NITPROVEEDOR,NOMBREPROVEDOR,TELEFONOPROVEDOR,CORREOPROVEDOR) 
values (2222,'Frito-Lay',8246478,'fritolay@gmail.com');
INSERT into proveedor (NITPROVEEDOR,NOMBREPROVEDOR,TELEFONOPROVEDOR,CORREOPROVEDOR) 
values (3333,'Aitana la Grande',82354666,'AitanaLagrande@gmail.com');
--------------------------------------------------------------------
--------------------INSERTAR DATOS TIPOPRODUCTO--------------------
-------------------------------------------------------------------
Insert into TIPOPRODUCTO (IDTIPOPRODUCTO,NOMBRETIPOPRODUCTO) values (1010,'Productos de Aseo');
Insert into TIPOPRODUCTO (IDTIPOPRODUCTO,NOMBRETIPOPRODUCTO) values (1020,'Granos');
Insert into TIPOPRODUCTO (IDTIPOPRODUCTO,NOMBRETIPOPRODUCTO) values (1030,'Dulceria');
Insert into TIPOPRODUCTO (IDTIPOPRODUCTO,NOMBRETIPOPRODUCTO) values (1040,'Prendas de vestir');
--------------------------------------------------------------------
--------------------INSERTAR DATOS LOTE--------------------
-------------------------------------------------------------------
Insert into LOTE (IDLOTE,PRECIOLOTE,CANTIDAD,IDTIPOPRODUCTO,NITPROVEEDOR) values ('A100',200000,50,1010,1111);
Insert into LOTE (IDLOTE,PRECIOLOTE,CANTIDAD,IDTIPOPRODUCTO,NITPROVEEDOR) values ('A200',500000,10,1020,1111);
Insert into LOTE (IDLOTE,PRECIOLOTE,CANTIDAD,IDTIPOPRODUCTO,NITPROVEEDOR) values ('A210',450000,10,1030,2222);
Insert into LOTE (IDLOTE,PRECIOLOTE,CANTIDAD,IDTIPOPRODUCTO,NITPROVEEDOR) values ('A300',20000,100,1040,3333);
Insert into LOTE (IDLOTE,PRECIOLOTE,CANTIDAD,IDTIPOPRODUCTO,NITPROVEEDOR) values ('A400',20000,100,1040,3333);
--------------------------------------------------------------------
--------------------INSERTAR DATOS DESCUENTO --------------------
-------------------------------------------------------------------
INSERT INTO DESCUENTO(CODIGODESCUENTO,PORCENTAJE)VALUES(1000,0); 
INSERT INTO DESCUENTO(CODIGODESCUENTO,PORCENTAJE)VALUES(1030,30);
INSERT INTO DESCUENTO(CODIGODESCUENTO,PORCENTAJE)VALUES(1040,40);  

--------------------------------------------------------------------
--------------------INSERTAR DATOS EMPLEADO --------------------
-------------------------------------------------------------------
INSERT INTO EMPLEADO(IDEMPLEADO,NOMBREEMPLEADO, PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOEMPLEADO,CORREOEMPLEADO,SUELDOEMPLEADO,TIPOEMPLEADO)
VALUES(1111,'Luis','Perez','Galindez',8899435,'luisperez@gmail.com',3000,'ADMINISTRATIVO');
INSERT INTO EMPLEADO(IDEMPLEADO,NOMBREEMPLEADO, PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOEMPLEADO,CORREOEMPLEADO,SUELDOEMPLEADO,TIPOEMPLEADO)
VALUES(2222,'Maria','Galindez','Perafan',8564758,'mariagalindez@gmail.com',2000,'CAJERO');
INSERT INTO EMPLEADO(IDEMPLEADO,NOMBREEMPLEADO, PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOEMPLEADO,CORREOEMPLEADO,SUELDOEMPLEADO,TIPOEMPLEADO)
VALUES(3333,'Angie','Sanchez','Munoz',8769679,'angiesanchez@gmail.com',1000,'AYUDANTE');
INSERT INTO EMPLEADO(IDEMPLEADO,NOMBREEMPLEADO, PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOEMPLEADO,CORREOEMPLEADO,SUELDOEMPLEADO,TIPOEMPLEADO)
VALUES(4444,'Andres','Ruano','Majin',863777,'andresruano@gmail.com',2000,'CAJERO');
INSERT INTO EMPLEADO(IDEMPLEADO,NOMBREEMPLEADO, PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOEMPLEADO,CORREOEMPLEADO,SUELDOEMPLEADO,TIPOEMPLEADO)
VALUES(5555,'Felipe','Mosquera','Gomez',8335546,'felipemosquera@gmail.com',1000,'AYUDANTE');

--------------------------------------------------------------------
--------------------INSERTAR DATOS SUCURSAL  --------------------
-------------------------------------------------------------------
INSERT INTO SUCURSAL(CODIGOSUCURSAL,NOMBRESUCURSAL,DIRECCIONSUCURSAL,TELEFONOSUCURSAL,IDEMPLEADO)
VALUES(9100,'Jumbo','carrera 35 #7-22',8439785,1111);
INSERT INTO SUCURSAL(CODIGOSUCURSAL,NOMBRESUCURSAL,DIRECCIONSUCURSAL,TELEFONOSUCURSAL,IDEMPLEADO)
VALUES(9101,'Exito','calle 5 #124 AV',85434690,1111);
INSERT INTO SUCURSAL(CODIGOSUCURSAL,NOMBRESUCURSAL,DIRECCIONSUCURSAL,TELEFONOSUCURSAL,IDEMPLEADO)
VALUES(9102,'Metropolis','carrera 26#7-36',8956764,1111);
INSERT INTO SUCURSAL(CODIGOSUCURSAL,NOMBRESUCURSAL,DIRECCIONSUCURSAL,TELEFONOSUCURSAL,IDEMPLEADO)
VALUES(9103,'Merca Super','carrera 7#12-15',8947994,1111);
INSERT INTO SUCURSAL(CODIGOSUCURSAL,NOMBRESUCURSAL,DIRECCIONSUCURSAL,TELEFONOSUCURSAL,IDEMPLEADO)
VALUES(9104,'Olimpica','calle 2 #19-45',8946294,1111);
--------------------------------------------------------------------
--------------------INSERTAR DATOS PRODUCTO  --------------------
-------------------------------------------------------------------
INSERT into producto (nitproducto,idlote,nombreproducto,pesoproducto,precioproducto,estadoproducto ,nitproveedor,codigosucursal)
VALUES (100,'A100','Jabon',500,2000,'BUENO',1111,9100);
INSERT into producto (nitproducto,idlote,nombreproducto,pesoproducto,precioproducto,estadoproducto,nitproveedor, codigosucursal)
VALUES (200,'A100','Limpido',500,2500,'BUENO',3333,9100);
INSERT into producto (nitproducto,idlote,nombreproducto,pesoproducto,precioproducto,estadoproducto ,nitproveedor,codigosucursal)
VALUES (300,'A200','Frijol',450,4000,'BUENO',1111,9101);
INSERT into producto (nitproducto,idlote,nombreproducto,pesoproducto,precioproducto,estadoproducto,nitproveedor, codigosucursal)
VALUES (400,'A200','Lenteja',450,3600,'BUENO',2222,9101);
INSERT into producto (nitproducto,idlote,nombreproducto,pesoproducto,precioproducto,estadoproducto ,nitproveedor,codigosucursal)
VALUES (500,'A210','Pirulitos',20,100,'BUENO',3333,9101);
INSERT into producto (nitproducto,idlote,nombreproducto,pesoproducto,precioproducto,estadoproducto,nitproveedor, codigosucursal)
VALUES (600,'A210','Cochocarramos',30,900,'BUENO',3333,9102);
INSERT into producto (nitproducto,idlote,nombreproducto,pesoproducto,precioproducto,estadoproducto ,nitproveedor,codigosucursal)
VALUES (700,'A300','Buso',15,3800,'BUENO',1111,9104);
INSERT into producto (nitproducto,idlote,nombreproducto,pesoproducto,precioproducto,estadoproducto,nitproveedor, codigosucursal)
VALUES (800,'A300','Pantalon',25,6000,'BUENO',2222,9104);
INSERT into producto (nitproducto,idlote,nombreproducto,pesoproducto,precioproducto,estadoproducto,nitproveedor, codigosucursal)
VALUES (900,'A400','Camiseta',20,5800,'MALO',2222,9104);
--------------------------------------------------------------------
-----------INSERTAR DATOS DE DEPOSITOBASURA  ---------------
-----------------------------------------------------------------
INSERT INTO DEPOSITOBASURA(codigodeposito,TIPOBASURA,NITPRODUCTO) VALUES(141,'ORGANICA',900);

--------------------------------------------------------------------
-----------INSERTAR DATOS DE CLIENTE ---------------
-----------------------------------------------------------------
INSERT INTO CLIENTE(CODIGOCLIENTE,NOMBRECLIENTE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOCLIENTE,CORREOCLIENTE,DIRECCION)
VALUES(380,'Arturo','Gaviria','Gaviria',3214563245,'arturo@gmail.com','calle 3 #4-11');
INSERT INTO CLIENTE(CODIGOCLIENTE,NOMBRECLIENTE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOCLIENTE,CORREOCLIENTE,DIRECCION)
VALUES(381,'Felipe','Papamija','IJaji',3213563645,'Felipe@gmail.com','calle 6 #7-21');
INSERT INTO CLIENTE(CODIGOCLIENTE,NOMBRECLIENTE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOCLIENTE,CORREOCLIENTE,DIRECCION)
VALUES(382,'Samuel','Gaviria','Munoz',3214463265,'Samuel@gmail.com','calle 6 #7-13');
INSERT INTO CLIENTE(CODIGOCLIENTE,NOMBRECLIENTE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOCLIENTE,CORREOCLIENTE,DIRECCION)
VALUES(383,'Cristian','Melo','Restrepo',32445432445,'cristian@gmail.com','calle 8 #9-23');
INSERT INTO CLIENTE(CODIGOCLIENTE,NOMBRECLIENTE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOCLIENTE,CORREOCLIENTE,DIRECCION)
VALUES(384,'David','Alegria','Cajas',3114565245,'david@gmail.com','calle 1 #11-23');
INSERT INtO CLIENTE(CODIGOCLIENTE,NOMBRECLIENTE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOCLIENTE,CORREOCLIENTE,DIRECCION)
VALUES(385,'Dana','Gaviria','Toro',316653322,'dana@gmail.com','calle 4 #6-17');
INSERT INTO CLIENTE(CODIGOCLIENTE,NOMBRECLIENTE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOCLIENTE,CORREOCLIENTE,DIRECCION)
VALUES(386,'Daniela','Perez','Cardona',3184553645,'daniela@gmail.com','calle 8 #8-19');
INSERT INTO CLIENTE(CODIGOCLIENTE,NOMBRECLIENTE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOCLIENTE,CORREOCLIENTE,DIRECCION)
VALUES(387,'Karen','Sanchez','zuniga',3204667245,'karen@gmail.com','calle 3 #3-9');
INSERT INTO CLIENTE(CODIGOCLIENTE,NOMBRECLIENTE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOCLIENTE,CORREOCLIENTE,DIRECCION)
VALUES(388,'Lisbeth','Galindez','Perafan',3114363849,'lisbet@gmail.com','calle 1 #11-17');

--------------------------------------------------------------------
-----------INSERTAR DATOS DE COMPRA -------------------------------
--------------------------------------------------------------------
INSERT INTO COMPRA(CODIGOCLIENTE,NITPRODUCTO,FECHA,TIPOPAGO,CODIGODESCUENTO,IDEMPLEADO) 
VALUES(381,600,TO_DATE('12/07/2020','DD/MM/YYYY'),'EFECTIVO',1000,2222);
INSERT INTO COMPRA(CODIGOCLIENTE,NITPRODUCTO,FECHA,TIPOPAGO,CODIGODESCUENTO,IDEMPLEADO) 
VALUES(380,300,TO_DATE('01/07/2021','DD/MM/YYYY'),'TARJETA',1000,2222);
INSERT INTO COMPRA(CODIGOCLIENTE,NITPRODUCTO,FECHA,TIPOPAGO,CODIGODESCUENTO,IDEMPLEADO) 
VALUES(382,300,TO_DATE('13/04/2019','DD/MM/YYYY'),'EFECTIVO',1000,2222);
INSERT INTO COMPRA(CODIGOCLIENTE,NITPRODUCTO,FECHA,TIPOPAGO,CODIGODESCUENTO,IDEMPLEADO) 
VALUES(383,300,TO_DATE('08/07/2022','DD/MM/YYYY'),'TARJETA',1030,2222);
INSERT INTO COMPRA(CODIGOCLIENTE,NITPRODUCTO,FECHA,TIPOPAGO,CODIGODESCUENTO,IDEMPLEADO) 
VALUES(384,600,TO_DATE('15/08/2022','DD/MM/YYYY'),'EFECTIVO',1040,2222);
INSERT INTO COMPRA(CODIGOCLIENTE,NITPRODUCTO,FECHA,TIPOPAGO,CODIGODESCUENTO,IDEMPLEADO) 
VALUES(385,600,TO_DATE('12/11/2021','DD/MM/YYYY'),'TARJETA',1030,2222);
INSERT INTO COMPRA(CODIGOCLIENTE,NITPRODUCTO,FECHA,TIPOPAGO,CODIGODESCUENTO,IDEMPLEADO) 
VALUES(386,600,TO_DATE('22/03/2022','DD/MM/YYYY'),'EFECTIVO',1000,2222);
INSERT INTO COMPRA(CODIGOCLIENTE,NITPRODUCTO,FECHA,TIPOPAGO,CODIGODESCUENTO,IDEMPLEADO) 
VALUES(387,700,TO_DATE('26/08/2021','DD/MM/YYYY'),'EFECTIVO',1000,2222);
--------------------------------------------------------------------
-----------INSERTAR DATOS DE BODEGA -------------------------------
--------------------------------------------------------------------
INSERT INTO BODEGA(CODIGOBODEGA,NOMBREBODEGA,IDEMPLEADO)VALUES(3423,'La Maria',3333);
INSERT INTO BODEGA(CODIGOBODEGA,NOMBREBODEGA,IDEMPLEADO)VALUES(3424,'Deposto la quinta',5555);
--------------------------------------------------------------------
-----------INSERTAR DATOS DE SE_ALMACENA -------------------------------
--------------------------------------------------------------------
INSERT INTO SE_ALMACENA(CODIGOBODEGA,NITPRODUCTO,FECHA)VALUES(3423,100,TO_DATE('20/11/2019','DD/MM/YYYY'));
INSERT INTO SE_ALMACENA(CODIGOBODEGA,NITPRODUCTO,FECHA)VALUES(3424,200,TO_DATE('16/09/2020','DD/MM/YYYY'));
INSERT INTO SE_ALMACENA(CODIGOBODEGA,NITPRODUCTO,FECHA)VALUES(3424,400,TO_DATE('14/03/2021','DD/MM/YYYY'));

COMMIT;