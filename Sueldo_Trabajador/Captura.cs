using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo_Trabajador
{
    class Captura
    {
        public static double CapturaHorasTrabajasSemana()
        {
            int HorasSemana;
            HorasSemana = Convert.ToInt32(Console.ReadLine());
            return HorasSemana;
        }

        public static double CapturarHorasTrabajasFindeSemana()
        {
            int HorasFinSemana;
            HorasFinSemana = Convert.ToInt32(Console.ReadLine());
            return HorasFinSemana;
        }

        public static double CapturaValorHora()
        {
            int ValorHora;
            ValorHora = Convert.ToInt32(Console.ReadLine());
            return ValorHora;
        }

        public static double Capturames()
        {
            int mes;
            mes = Convert.ToInt32(Console.ReadLine());
            return mes;
        }

        public static double CapturaAño()
        {
            int Año;
            Año = Convert.ToInt32(Console.ReadLine());
            return Año;
        }

        public static double CapturaRut()
        {
            double rut;
            rut = Convert.ToInt32(Console.ReadLine());
            return rut;
        }

        public static string CapturarNombres()
        {
            string nombre;
            nombre = Console.ReadLine();
            return nombre;
        }

        public static string CapturarApellidos()
        {
            string apellido;
            apellido = Console.ReadLine();
            return apellido;
        }

        public static double CapturaAnticipos()
        {
            int anticipos;
            anticipos = Convert.ToInt32(Console.ReadLine());
            return anticipos;
        }

        public static double CapturaDescuentos()
        {
            int descuentos;
            descuentos = Convert.ToInt32(Console.ReadLine());
            return descuentos;
        }
        public static double CapturaBonos()
        {
            int bonos;
            bonos = Convert.ToInt32(Console.ReadLine());
            return bonos;
        }

        public static int seleccion_Prevision()
        {
            //int  provida, cuprum;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("Ingrese su opcion: ");
            int prevision = Convert.ToInt32(Console.ReadLine());
            switch (prevision)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
            return prevision;
        }

        public static int seleccionSalud()
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("Ingrese su opcion: ");
            int salud = Convert.ToInt32(Console.ReadLine());
            switch (salud)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Digito invalido porfavor seleccione de 1-2!");
                    break;
            }
            return salud;
        }
    }
}
