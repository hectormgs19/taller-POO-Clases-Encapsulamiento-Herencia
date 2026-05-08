using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_POO__Calse_Encapsulamiento_Herencia_.Clases
{
    //Definición de la clase Padre (abstract)
    public abstract class DispositivoElectronico
    {

        //Definición de Atributos
        public string Marca { get; protected set;}
        public string Modelo { get; protected set;}
        public double Precio { get; protected set;}

        //Constructor

        //public DispositivoElectronico(string marca, string modelo, double precio)
        //{
        //    Marca = marca;
        //    Modelo = modelo;
        //    Precio = precio;
        //}

        public DispositivoElectronico(string marca, string modelo, double precio)
        {
            if (marca.Trim() == "")
            {
                Console.WriteLine("Error: la marca no puede estar vacía.");
                Marca = "Sin marca";
            }
            else
            {
                Marca = marca;
            }

            if (modelo.Trim() == "")
            {
                Console.WriteLine("Error: el modelo no puede estar vacío.");
                Modelo = "Sin modelo";
            }
            else
            {
                Modelo = modelo;
            }

            if (precio <= 0)
            {
                Console.WriteLine("Error: el precio debe ser mayor a 0.");
                Precio = 1;
            }
            else if (precio > 50000000)
            {
                Console.WriteLine("Error: el precio no puede superar los 50.000.000.");
                Precio = 1;
            }
            else
            {
                Precio = precio;
            }
        }


        //Métodos
        public abstract void Encender();
        public abstract void MostrarInformacion();

    }
}
