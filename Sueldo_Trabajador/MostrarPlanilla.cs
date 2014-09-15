using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo_Trabajador
{
    class MostrarPlanilla
    {
        public static void mostrar(string apellido, string nombre, int prevision, double rut, double mes, double año, double horasTrabajadasSemana,
                                   double horasFindeSemana, double valorHora, double anticipos, double descuentos, double bonos, double totalSemana,
                                   double totalFindeSemana, double restaTotalSueldo, double totalSueldoNeto, int salud, double sueldoTotal)
        {
            Console.WriteLine("Nombre                         :" + nombre);
            Console.WriteLine("Apellido                       :" + apellido);
            Console.WriteLine("Rut                            :" + rut);
            Console.WriteLine("Mes                            :" + mes);
            Console.WriteLine("Año                            :" + año);
            Console.WriteLine("Horas trabajadas en la semana  :" + horasTrabajadasSemana);
            Console.WriteLine("Horas trabajadas fin de semana :" + horasFindeSemana);
            Console.WriteLine("Valor hora                     :" + valorHora);
            if (prevision == 1)
            {
                Console.WriteLine("Prevision                      :" + "Capital");
            }
            else if (prevision == 2)
            {
                Console.WriteLine("Prevision                      :" + "Cuprum");
            }
            else
            {
                Console.WriteLine("Prevision                      :" + "No esta en la lista");
            }
            if (salud == 1)
            {
                Console.WriteLine("Prevision                      :" + "Fonasa");
            }
            else if (salud == 2)
            {
                Console.WriteLine("Prevision                      :" + "Isapre");
            }
            else
            {
                Console.WriteLine("Prevision                      :" + "No esta en la lista");
            }
            Console.WriteLine("Total anticipos                :$" + anticipos);
            Console.WriteLine("Total descuentos               :$" + descuentos);
            Console.WriteLine("Total bonos                    :$" + bonos);
            Console.WriteLine("El sueldo de la semana es      :$" + totalSemana);
            Console.WriteLine("Total horas fin de semana      :$" + totalFindeSemana);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("El Sueldo Total es             :$" + sueldoTotal);
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
