# Taller POO - Encapsulamiento y Herencia

## Integrantes

- Luis Silva Fuentes
- Hector González

## Descripción

Este proyecto corresponde a un taller de Programación Orientada a Objetos en C#, donde se aplican conceptos como diseño de clases, encapsulamiento, herencia, constructores, métodos y validaciones.

El sistema permite gestionar diferentes tipos de dispositivos electrónicos, como portátiles y celulares, heredando atributos y métodos desde una clase padre llamada `DispositivoElectronico`.

## Clases del proyecto

### DispositivoElectronico

Clase padre abstracta que contiene los atributos generales de un dispositivo:

- Marca
- Modelo
- Precio

También contiene los métodos obligatorios:

- Encender()
- MostrarInformacion()

### Portatil

Clase hija que hereda de `DispositivoElectronico`.

Atributos propios:

- TamanoPantalla
- MemoriaRam

Métodos propios:

- AbrirTapa()
- ConectarCargador()

### Celular

Clase hija que hereda de `DispositivoElectronico`.

Atributos propios:

- NumeroSim
- Bateria

Métodos propios:

- HacerLlamada()
- TomarFoto()

## Validaciones implementadas

El sistema valida las siguientes reglas:

- La marca no puede estar vacía.
- El modelo no puede estar vacío.
- El precio debe ser mayor a 0.
- El precio no puede superar los 50.000.000.

## Tecnologías usadas

- C#
- .NET
- Visual Studio / Visual Studio Code
- GitHub

