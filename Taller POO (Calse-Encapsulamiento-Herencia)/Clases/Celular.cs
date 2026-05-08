using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_POO__Calse_Encapsulamiento_Herencia_.Clases
{
    public class Celular : DispositivoElectronico
    {
        //Def. Atributos
        public int NumeroSim { get; private set; }
        public int Bateria { get; private set; }

        //Constructor
        public Celular(string marca, string modelo, double precio, int numeroSim, int bateria) : base(marca, modelo, precio)
        {
            NumeroSim = numeroSim;
            Bateria = bateria;
        }

        //Metodos heredados

        public override void Encender()
        {
            Console.WriteLine($"El dispositivo {Modelo} - {Marca} está encendido");
        }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Información del dispositivo: {Modelo}, {Marca}, {Precio}, {NumeroSim}, {Bateria}");
        }

        //Metodos propios

        public void HacerLlamada()
        {
            Console.WriteLine("llamando");
        }

        public void TomarFoto()
        {
            Console.WriteLine("Foto capturada");
        }


    }
}
