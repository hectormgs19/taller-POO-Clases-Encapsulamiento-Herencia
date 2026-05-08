using Taller_POO__Calse_Encapsulamiento_Herencia_.Clases;

//Constructores

//Portatil
Portatil laptop = new Portatil("", "", 3000000, 30, 32);

//Celular

Celular laFlecha = new Celular("Nokia", "flecha", 0, 300123684, 80);

//Llamar metodos Portatil
laptop.MostrarInformacion();
Console.Write("\n");
Console.WriteLine("-----Métodos-----");
laptop.Encender();
laptop.MostrarInformacion();
laptop.AbrirTapa();
laptop.ConectarCargador();

Console.Write("\n");


//Llamar metodos Celular
laFlecha.MostrarInformacion();
Console.Write("\n");
Console.WriteLine("-----Métodos-----");
laFlecha.Encender();
laFlecha.HacerLlamada();
laFlecha.TomarFoto();
