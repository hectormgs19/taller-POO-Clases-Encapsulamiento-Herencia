using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_POO__Calse_Encapsulamiento_Herencia_.Clases
{
    //Definición de la clase Hija
    public class Portatil : DispositivoElectronico
    {
        //Def. Atributos
        public double TamanoPantalla { get; private set; }
        public int MemoriaRam { get; private set; }

        //Constructor
        public Portatil(string marca, string modelo, double precio, double tamanoPantalla, int memoriaRam) : base(marca, modelo, precio)
        {
            TamanoPantalla = tamanoPantalla;
            MemoriaRam = memoriaRam;
        }

        //Metodos heredados

        public override void Encender()
        {
            Console.WriteLine($"El dispositivo {Modelo} - {Marca} está encendido");
        }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Información del dispositivo: {Modelo}, {Marca}, {Precio}, {TamanoPantalla}, {MemoriaRam}");
        }

        //Metodos propios

        public void AbrirTapa()
        {
            Console.WriteLine("La tapa se abrió");
        }

        public void ConectarCargador()
        {
            Console.WriteLine("Cargando");
        }
    }
}
