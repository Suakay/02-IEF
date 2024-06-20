using System;
using System.Collections.Generic;

namespace _02_DataFirstWA.Models;

public partial class KasaTipleri
{
    public int KasaId { get; set; }

    public string? KasaTipiAdı { get; set; }

    public virtual ICollection<Araçlar> Araçlars { get; set; } = new List<Araçlar>();
}
