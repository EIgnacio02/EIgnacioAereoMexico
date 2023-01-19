using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Vuelo
    {
        public static ML.Result GetAll(ML.Vuelo vuelo)
        {
            ML.Result result= new ML.Result();

            try
            {
                using (DL.EignacioAeroMexicoContext context=new DL.EignacioAeroMexicoContext())
                {
                    var query=context.Vuelos.FromSqlRaw($"VuelosGetAll '{vuelo.FechaInicio}','{vuelo.FechaFin}'").ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Vuelo vuelos = new ML.Vuelo();

                            vuelos.IdVuelo = obj.IdVuelo;
                            vuelos.NumeroVuelo = obj.NumeroVuelo;
                            vuelos.Origen = obj.Origen;
                            vuelos.Destino = obj.Destino;
                            vuelos.FechaSalida = (DateTime)obj.FechaSalida;

                            result.Objects.Add(vuelos);
                        }
                    }
                }
                result.Correct=true;
            }
            catch (Exception e)
            {

            }

            return result;
        }
    }
}
