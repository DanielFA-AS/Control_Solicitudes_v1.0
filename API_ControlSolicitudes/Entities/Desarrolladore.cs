using System;
using System.Collections.Generic;

namespace API_ControlSolicitudes.Entities;

public partial class Desarrolladore
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apaterno { get; set; } = null!;

    public string Amaterno { get; set; } = null!;

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();
}
