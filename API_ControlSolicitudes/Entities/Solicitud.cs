using System;
using System.Collections.Generic;

namespace API_ControlSolicitudes.Entities;

public partial class Solicitud
{
    public int Id { get; set; }

    public int FkSolicitante { get; set; }

    public int FkTipo { get; set; }

    public int Titulo { get; set; }

    public DateTime FeCreacion { get; set; }

    public string Descripcion { get; set; } = null!;

    public int FkPrioridad { get; set; }

    public int FkResponsable { get; set; }

    public int FkEstado { get; set; }

    public virtual Estado FkEstadoNavigation { get; set; } = null!;

    public virtual Prioridad FkPrioridadNavigation { get; set; } = null!;

    public virtual Desarrolladore FkResponsableNavigation { get; set; } = null!;

    public virtual Usuario FkSolicitanteNavigation { get; set; } = null!;

    public virtual TipoSolicitud FkTipoNavigation { get; set; } = null!;

    public virtual ICollection<HistorialTrazabilidad> HistorialTrazabilidads { get; set; } = new List<HistorialTrazabilidad>();
}
