using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDioCelular.Models
{
    public class Motorola: Smartphone
    {
    //sobreescreve o metodo "InstalarAplicativo"
         public Motorola(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
         {
            
         }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Motorola");
        }
    }
}