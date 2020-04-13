using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TablasDeMultiplicar.Models
{
    public class EjerciciosModel
    {
        public int M1 { get; set; }
        public int M2 { get; set; }
        public int Result { get; set; }
        public List<int> Options { get; set; }

        public EjerciciosModel()
        {
            Options = new List<int>();
        }
    }
}
