
CREATE OR ALTER PROCEDURE dbo.AsignarResponsable
    @Responsable INT,
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE SOLICITUD
    SET FK_Responsable = @Responsable
    WHERE Id = @Id;

    /*TERMINAR EL RASTREO Y TRAZABILIDAD*/
END;
GO