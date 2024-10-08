--COMENTARIOS
/*
	mas de una l�nea de comentario
*/
--ESTO SON CONSULTAS BASICAS
--DEVUELVEN TODAS LAS COLUMNAS Y TODAS LAS FILAS DE UNA TABLA
select * from emp
select * from dept
--TAMBIEN PODEMOS ESCRIBIR CONSULTAS INDICANDO LAS COLUMNAS
--QUE DESEAMOS RECUPERAR DE LA TABLA
select apellido, oficio, salario from emp
--ORDENACION DE DATOS.  ESTO SIEMPRE IRA AL FINAL DE LAS CONSULTAS
--order by columna ASC/DESC
--ORDENAMOS LOS EMPLEADOS POR SU APELLIDO DE FORMA ASCENDENTE
select * from EMP order by apellido asc
--ORDENAMOS LOS EMPLEADOS POR SU APELLIDO DE FORMA DESCENDENTE
select * from EMP order by apellido desc
--FILTRADO DE DATOS: where
--SOLAMENTE TENDREMOS UN where EN LA CONSULTA Y SE UTILIZAN 
--OPERADORES DE COMPARACION PARA COMPARAR CON LOS DATOS.
/*
OPERADORES DE COMPARACION
	> mayor
	>= mayor o igual
	< menor
	<= menor o igual 
	= igual
	<> distinto
*/
--TODO LO QUE NO SEA UN NUMERO SE COMPARA CON COMILLAS SIMPLES
--MOSTRAR TODOS LOS EMPLEADOS DEL DEPARTAMENTO 20
select * from emp where dept_no = 20
--MOSTRAR TODOS LOS EMPLEADOS QUE TENGAN OFICIO ANALISTA
select * from emp where oficio = 'analista'
--SI NECESITAMOS MAS DE UN FILTRO SE UTILIZAN LOS OPERADORES RELACIONALES
/*
OPERADORES RELACIONALES
	AND: TODOS LOS FILTROS DEBEN CUMPLIRSE 
	OR: MUESTRA DATOS DE CADA FILTRO
	NOT: NEGACION DE UNA CONSULTA
*/
--MOSTRAR LOS EMPLEADOS QUE TENGAN OFICIO ANALISTA Y QUE 
--COBREN MAS DE 300000
select * from emp where oficio = 'ANALISTA' and salario > 300000
--MOSTRAR TODOS LOS EMPLEADOS QUE SEAN DEL DEPARTAMENTO 10 Y DEL DEPARTAMENTO 30
select * from emp where dept_no = 10 or dept_no = 30
--EL NOT NUNCA LO VAMOS A UTILIZAR, RALENTIZA UNA CONSULTA
--MOSTRAR TODOS LOS EMPLEADOS QUE NO SEAN DIRECTOR
select * from emp where NOT oficio = 'DIRECTOR'
--SIEMPRE UTILIZAREMOS OPERADORES PARA LAS CONSULTAS
select * from emp where oficio <> 'DIRECTOR'
--OTROS OPERADORES DE COMPARACION
--between: BUSCA ENTRE DOS DATOS INCLUYENDO LA BUSQUEDA
--MOSTRAR TODOS LOS EMPLEADOS CUYO SALARIO SEA ENTRE 208.000 y 300.000
select * from emp where salario between 208000 and 300000
--TAMBIEN PODEMOS UTILIZAR LA CONSULTA CON OPERADORES TRADICIONALES
select * from emp where salario >= 208000 and salario <= 300000
--OPERADOR IN: BUSCA COINCIDENCIAS CON IGUALDAD DENTRO DE UN MISMO CAMPO
--MOSTRAR TODOS LOS EMPLEADOS DEL DEPARTAMENTO 10 y DEL 20 y DEL 30, 80, 90, 120
select * from emp where dept_no = 10 or dept_no = 20 or dept_no = 30
or dept_no = 80 or dept_no = 90 or dept_no = 120
--operador in (valor1, valor2, valor3)
select * from emp where dept_no in (10, 20, 30, 80, 90, 120)
--OPERADOR NOT IN: RECUPERA LOS DATOS CONTRARIOS A LA COMPARACION DE UN
--MISMO CAMPO
--MOSTRAR TODOS LOS EMPLEADOS QUE NO SEAN DEL DEPARTAMENTO 10 Y DEL 20
select * from emp where dept_no not in (10, 20)
--ESTO ES UNA NEGACION, NUNCA UTILIZAR
select * from emp where not dept_no  in (10, 20)
