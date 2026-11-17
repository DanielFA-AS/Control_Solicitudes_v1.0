using System;
using System.Collections.Generic;

namespace API_ControlSolicitudes.Entities;

public partial class HistorialTrazabilidad
{
    public int Id { get; set; }

    public int FkSolicitud { get; set; }

    public string FechaHora { get; set; } = null!;

    public int FkAccion { get; set; }

    public string Detalle { get; set; } = null!;

    public string ComResolu { get; set; } = null!;

    public virtual AccionesTrazabilidad FkAccionNavigation { get; set; } = null!;

    public virtual Solicitud FkSolicitudNavigation { get; set; } = null!;
}
