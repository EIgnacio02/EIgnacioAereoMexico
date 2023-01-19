using System;
using System.Collections.Generic;

namespace DL;

public partial class Pasajero
{
    public int IdPasajero { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoParteno { get; set; } = null!;

    public string ApellidoMarteno { get; set; } = null!;
}
