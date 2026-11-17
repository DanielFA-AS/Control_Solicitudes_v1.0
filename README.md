Control\_Solicitudes\_v1.0
==========================================================================
\*Descripción del proyecto:
===

# El proyecto consta de las fases iniciales de un sistema de control de solicitudes. Que no solo permita la creación de solicitudes, sino también de su control: asignando programadores, cambiando estados y finalizándolos.

# 

# 

# \*Tecnologías utilizadas: .NET 10, C#, SQL Server, Entity Framework Core.

\*Requisitos de instalación:
-.NET SDK 10.0 (LTS).
===

# \-SQL Server 2025 Express o una edición compatible con los scripts.

# \-Git, para la clonación del repositorio.

# \-Instancia de SQL Server configurada y accesible.

# \-Restaurar las dependencias NuGet del proyecto mediante dotnet restore.

# 

# 

# \*Configuración y creación de la base de datos.

# \-Abrir SQL Server Management Studio.

# \-Ejecutar el script 01\_CrearBaseDatos.sql.

# \-Ejecutar los scripts de creación de tablas. La tabla de historial debe crearse después de  SOLICITUD y ACCIONES\_TRAZABILIDAD.

# \-Ejecutar Scripts\_Carga\_Datos.sql.

# \-Ejecutar los procedimientos almacenados del 10 al 15.

# 

# 

# \*Configuración de la cadena de conexión.

# Modificar el apartado ConnectionStrings, propiedad DefaultConnection, del archivo appsettings.json. Utilicé autenticación de Windows.

# 

# \*Compilación y ejecución de la API.

# Abrir Control\_Solicitudes\_v1.0.slnx mediante Visual Studio, compilar la solución y ejecutar el proyecto API\_ControlSolicitudes.

# 

# \*Endpoints implementados.

# /api/Solicitudes	         (GET) Consultar todas las solicitudes.

# /api/Solicitudes/{id}	         (GET) Consultar por identificador.

# /api/Solicitudes/estado/{id}	 (GET) Filtrar por estado.

# 

# 

\*Funcionalidades pendientes.
-Consulta de historial.
===

# \-Registro de solicitudes.

# \-Asignación de responsables.

# \-Cambios de estado y validación de transiciones.

# \-Trazabilidad completa.

# \-DTOs y capas de negocio.

# \-Interfaz gráfica MVC.

# 

