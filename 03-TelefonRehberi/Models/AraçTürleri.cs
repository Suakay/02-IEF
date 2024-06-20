using System;
using System.Collections.Generic;

namespace _03_TelefonRehberi.Models;

public partial class AraçTürleri
{
    public int AraçTürId { get; set; }

    public string? AraçTürAdı { get; set; }

    public virtual ICollection<Araçlar> Araçlars { get; set; } = new List<Araçlar>();
}
