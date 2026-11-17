
CREATE OR ALTER PROCEDURE dbo.ConsultaPorEstado
    @Estado INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM SOLICITUD
    WHERE FK_Estado = @Estado;
END;
GO