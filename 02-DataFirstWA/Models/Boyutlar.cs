using System;
using System.Collections.Generic;

namespace _02_DataFirstWA.Models;

public partial class Boyutlar
{
    public int BoyutId { get; set; }

    public int? KoltukSayısı { get; set; }

    public int? Uzunluk { get; set; }

    public int? Genişlik { get; set; }
}
