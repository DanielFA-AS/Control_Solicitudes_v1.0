
    CREATE OR ALTER PROCEDURE dbo.RegistroSolicitud
        @FK_Solicitante INT,
        @FK_Tipo INT,
        @Titulo NVARCHAR(150),
        @Descripcion NVARCHAR(150),
        @FK_Prioridad INT,
        @FK_Responsable INT = NULL
    AS
    BEGIN
        SET NOCOUNT ON;
        SET XACT_ABORT ON;

        BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO SOLICITUD
        (
            FK_Solicitante,
            FK_Tipo,
            Titulo,
            FeCreacion,
            Descripcion,
            FK_Prioridad,
            FK_Responsable,
            FK_Estado
        )
        VALUES
        (
            @FK_Solicitante,
            @FK_Tipo,
            @Titulo,
            SYSDATETIME(),
            @Descripcion,
            @FK_Prioridad,
            @FK_Responsable,
            1
        )

        DECLARE @NuevoId INT;
        SET @NuevoId = SCOPE_IDENTITY();

        INSERT INTO HISTORIAL_TRAZABILIDAD
        (
            FK_Solicitud,
            FechaHora,
            FK_Accion,
            Detalle,
            ComResolu
        )
        VALUES
        (
            @NuevoId,
            SYSDATETIME(),
            1,
            'Solicitud creada con exito',
            NULL
        )

        COMMIT TRANSACTION;

        SELECT @NuevoId AS Id;
        END TRY 
        BEGIN CATCH

        IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;
        THROW;
        END CATCH;

    END;
    GO