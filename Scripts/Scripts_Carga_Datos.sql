INSERT INTO ESTADO 
(Estado) VALUES
    ('Nueva'),
    ('En proceso'),
    ('Resuelta'),
    ('Cerrada'),
    ('Cancelada');



INSERT INTO PRIORIDAD 
(Prioridad) VALUES
    ('Baja'),
    ('Media'),
    ('Alta'),
    ('Crítica');



INSERT INTO DESARROLLADORES 
(Nombre,APaterno,AMaterno) 
VALUES 
    ('Developer 1','Uno','Dos'),
    ('Developer 2','Uno','Dos'),
    ('Developer 3','Uno','Dos');



INSERT INTO ACCIONES_TRAZABILIDAD 
(Accion,Detalle) 
VALUES 
    ('Creación','Creación de la solicitud.'),
    ('Asignación','La solicitud ha sido asignada a un desarrollador.'),
    ('Reasignación','Solicitud asignada a otro desarrollador.'),
    ('Cambio de estado','El estado de la solicitud ha cambiado.'),
    ('Cancelada','La solicitd ha sido cancelada.'),
    ('Cerrada','La solicitd a sido finalizada con exito.'),
    ('Resolución','La solicitud se ha resulto.');


INSERT INTO TIPO_SOLICITUD 
(Clave,Tipo,Detalle) 
VALUES 
    (001,'No abre','La plataforma no se abre.'),
    (002,'Falla','Pagina o modulo con un malfuncionamiento.'),
    (003,'Datos erroneos','Datos presentes en la plataforma son erroneos.'),
    (004,'No puedo iniciar sesión','No es posible entrar a la plataforma.'),
    (005,'Retraso o tarda en cargar','La plataforma tarda en cargar.');



INSERT INTO USUARIOS 
(Nombre,APaterno,AMaterno,Usuario,Correo) 
VALUES 
    ('Usuario 1','Uno','Dos','Usuario_1','usuario1@gmail.com'),
    ('Usuario 2','Uno','Dos','Usuario_2','usuario2@gmail.com'),
    ('Usuario 3','Uno','Dos','Usuario_3','usuario3@gmail.com');






