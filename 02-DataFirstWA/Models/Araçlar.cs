using System;
using System.Collections.Generic;

namespace _02_DataFirstWA.Models;

public partial class Araçlar
{
    public int ArabaId { get; set; }

    public string Marka { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int? Yil { get; set; }

    public string? YakitTipi { get; set; }

    public int? MotorHacmi { get; set; }

    public decimal? MotorGüç { get; set; }

    public decimal? AzamiSurat { get; set; }

    public int? KoltukSayısı { get; set; }

    public int? Uzunluk { get; set; }

    public int? Genişlik { get; set; }

    public decimal? Şehiriçi { get; set; }

    public decimal? ŞehirDışı { get; set; }

    public decimal? YakıtDepoHacmi { get; set; }

    public int? AraçTürId { get; set; }

    public int? KasaId { get; set; }

    public virtual AraçTürleri? AraçTür { get; set; }

    public virtual KasaTipleri? Kasa { get; set; }
}
