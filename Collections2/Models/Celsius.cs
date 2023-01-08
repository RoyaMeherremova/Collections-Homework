using Collections2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.Models
{
    internal class Celsius
    {
     public int Degree { get; set; }

        public Celsius(int degree)
        {
            Degree= degree;
        }

        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree + 273);
        }
    }
    
    
    
    
}
