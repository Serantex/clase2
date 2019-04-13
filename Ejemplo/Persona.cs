using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo
{
    public class Persona
    {

        public string nombre;
        public int edad;

        public float saldo = 0;

        public int energia = 100;


        public Persona(string unNombre, int unaEdad)
        {
            this.nombre = unNombre;
            this.edad = unaEdad;
        }


        public void cobrar(float dinero)
        {
            saldo = saldo + dinero;
        }

        public void pagar(float dinero)
        {
            saldo = saldo - dinero;
        }

        public void verSaldo()
        {
            Console.WriteLine("Saldo: " + this.saldo);

        public void dormir(int energiaGanada)
        {
            energia = Math.Min(100, energia + energiaGanada);
        }

        public void hacerEjercicio(int energiaGastada)
        {
            energia = Math.Max(0, energia - energiaGastada);
        }

        public void verEnergia()
        {
            Console.WriteLine("Energia: " + this.energia);

        }

    }
}
