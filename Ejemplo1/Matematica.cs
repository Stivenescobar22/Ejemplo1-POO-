using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{

    //primero defino el acceso a la clase
    class Matematica
    {
        //se definen los atributos o variables de la clase
        //por recomendacion se crean de manera privada

        private double numero1;
        private double numero2;

     //se realiza get y set para numero1
      public void setNumero1(double valor){
          this.numero1 = valor;
      }

      public double getNumero1(){
            return this.numero1;
      }

     //se realiza get y set para numero2
     public void setNumero2(double valor){
         this.numero2 = valor;
     }

     public double getNumero2(){
          return this.numero2;
     }

        //se crea el metodo sumar
        public double Sumar(){

            return (this.getNumero1() + this.getNumero2());
        }

        public double Restar(){

            return (this.getNumero1() - this.getNumero2());
        }

        public double Multiplicar()
        {

            return (this.getNumero1() * this.getNumero2());
        }

        public double Dividir()
        {

            return (this.getNumero1() / this.getNumero2());
        }
    }
}
