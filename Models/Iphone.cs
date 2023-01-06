using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDioCelular.Models
{
    //herda da classe smartphone
    public class Iphone: Smartphone
    {
         //sobreescreve o metodo "InstalarAplicativo"
         public Iphone(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
         {
            
         }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Iphone");
        }
    }
}