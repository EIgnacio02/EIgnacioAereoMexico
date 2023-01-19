using System;
using System.Collections.Generic;

namespace DL;

public partial class Vuelo
{
    public int IdVuelo { get; set; }

    public string? NumeroVuelo { get; set; }

    public string? Origen { get; set; }

    public string? Destino { get; set; }

    public DateTime? FechaSalida { get; set; }
}
