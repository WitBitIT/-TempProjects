using System;
using System.Collections.Generic;

namespace TempProject.Service.Controling.Infrastructure.DataBase.Server.Table;

public partial class Status
{
    public int IdStatus { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
