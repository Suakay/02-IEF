using System;
using System.Collections.Generic;

namespace _02_DataFirstWA.Models;

public partial class Territory
{
    public string TerritoryId { get; set; } = null!;

    public string TerritoryDescription { get; set; } = null!;

    public int RegionId { get; set; }

    public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; set; } = new List<EmployeeTerritory>();

    public virtual Region Region { get; set; } = null!;
}
