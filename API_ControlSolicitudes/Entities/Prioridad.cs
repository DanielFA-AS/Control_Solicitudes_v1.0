using System;
using System.Collections.Generic;

namespace API_ControlSolicitudes.Entities;

public partial class Prioridad
{
    public int Id { get; set; }

    public string Prioridad1 { get; set; } = null!;

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();
}
