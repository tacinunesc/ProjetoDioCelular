using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDioCelular.Models
{
   
    public abstract class Smartphone
    {
        
        public string Numero { get; set; }
       private string Modelo{get;}
       public int Imei { get; }
       public int Memoria { get; }

        public  Smartphone(string numero, string modelo, int imei, int memoria)
       {
        Numero = numero;
        Modelo = modelo;
        Imei = imei;
        Memoria = memoria;

        //passa os parametros do construtir para as propriedades
       }
       public void Ligar()
        {
            Console.WriteLine("Ligando....");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação....");
        }
        public void MostrarNumero()
        {
          Console.WriteLine(this.Numero);  
        }
        public void MostrarModelo()
        {
            Console.WriteLine(this.Modelo);
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}