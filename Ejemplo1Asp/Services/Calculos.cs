using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo1Asp.Services
{
    public class Calculos
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public int Resultado { get; set; }
        public string r1 { get; set; }




        //METODO DE BERNA PARA EL IF DE SUMAR Y RESTAR

        //public void Elegir()
        //{
        //    if (this.r1 == "sumar")
        //    {
        //        Suma();
        //    }
        //    if (this.r1 == "restar")
        //    {
        //        Resta();
        //    }

        //}



        public void Suma()
        {
            this.Resultado = this.Numero1 + this.Numero2;
        }
        public void Resta()
        {
            this.Resultado = this.Numero1 - this.Numero2;
        }
    }
}