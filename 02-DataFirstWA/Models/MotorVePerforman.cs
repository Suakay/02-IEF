using System;
using System.Collections.Generic;

namespace _02_DataFirstWA.Models;

public partial class MotorVePerforman
{
    public int MotorId { get; set; }

    public int? MotorHacmi { get; set; }

    public decimal? MotorGüç { get; set; }

    public decimal? MaksimumTork { get; set; }

    public decimal? AzamiSurat { get; set; }
}
