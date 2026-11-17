using System;
using System.Collections.Generic;

namespace API_ControlSolicitudes.Entities;

public partial class TipoSolicitud
{
    public int Id { get; set; }

    public string Clave { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string? Detalle { get; set; }

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();
}
