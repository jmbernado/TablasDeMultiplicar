using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TablasDeMultiplicar.Models;

namespace TablasDeMultiplicar.Services
{
    public class MultiplicacionesService
    {
        public List<List<Tablas>> GetTablas()
        {
            List<List<Tablas>> ret = new List<List<Tablas>>();

            for (int i = 1; i < 11; i++)
            {
                var tbl = new List<Tablas>();

                for (int j = 0; j < 11; j++)
                {
                    tbl.Add(new Tablas() { M1 = i, M2 = j, Result = i * j });
                }

                ret.Add(tbl);
            }
            return ret;
        }


        public List<EjerciciosModel> GetEjercicios(int tabla, int limit)
        {
            List<EjerciciosModel> ret = new List<EjerciciosModel>();
            var rnd = new Random();

            for (int i = 0; i < limit; i++)
            {
                var item = new EjerciciosModel();
                var resultoptions = new List<int>();

                do
                {
                    if (tabla == 99)
                    {
                        item.M1 = rnd.Next(0, 11);
                    }
                    else
                    {
                        item.M1 = tabla;
                    }
                    item.M2 = rnd.Next(0, 11);
                } while (ret.Any(x => x.M1 == item.M1 && x.M2 == item.M2));


                item.Result = item.M1 * item.M2;

                resultoptions.Add(item.Result);

                for (int j = 0; j < 3; j++)
                {
                    int a = rnd.Next(0, Math.Max(1,item.M1) * 10); 
                    
                    do{
                        a = rnd.Next(0, Math.Max(1, item.M1) * 10);
                        Console.WriteLine("bucleeeee");
                    } while (resultoptions.Any(x => x == a)) ;
                    resultoptions.Add(a);
                }

                item.Options = resultoptions.OrderBy(a => Guid.NewGuid()).ToList();
                ret.Add(item);
            }
            return ret;
        }
    }
}
