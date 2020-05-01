using System;
using System.Collections.Generic;

namespace Examen2_camiones
{ 
    public class Camion
    {
        public string name {get; set;}
        public string ruta {get; set;}

    public Camion(string name, string ruta) {
            this.name = name;
            this.ruta = ruta; //tiene que ser mayuscula
        } 

    //sobreescribir el metodo ToString para que los pokemon se impriman correctamente
        public override string ToString() {
            //return this.name;
            
            return $"nombre: {this.name} , Ruta: {this.ruta}";
        }

    }
}


// https://pgramadores.blogspot.com/2012/10/queue-cola-en-c.html