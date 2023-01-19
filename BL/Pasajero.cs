using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Pasajero
    {
        public static ML.Result Add(ML.Pasajero pasajero)
        {
            ML.Result result = new ML.Result();

            try
            {
                using(DL.EignacioAeroMexicoContext context = new DL.EignacioAeroMexicoContext())
                {
                    var query = context.Database.ExecuteSqlRaw($"PasajerosAdd '{pasajero.Nombre}','{pasajero.ApellidoPaterno}','{pasajero.ApellidoMaterno}'");
                    result.Objects=new List<object>();

                    if (query >0)
                    {
                        result.Message = "Se registraron los datos correctamente";
                    }
                }
                result.Correct=true;
            }
            catch(Exception ex)
            {

            }

            return result;
        }
    }
}
