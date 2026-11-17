using System;
using System.Collections.Generic;

namespace API_ControlSolicitudes.Entities;

public partial class AccionesTrazabilidad
{
    public int Id { get; set; }

    public string Accion { get; set; } = null!;

    public string Detalle { get; set; } = null!;

    public virtual ICollection<HistorialTrazabilidad> HistorialTrazabilidads { get; set; } = new List<HistorialTrazabilidad>();
}
