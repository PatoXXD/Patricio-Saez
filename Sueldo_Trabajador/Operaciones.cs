using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo_Trabajador
{
    class Operaciones
    {
        public static double calcularTotalSueldoSemana(double horasTrabajadasSemana, double valorHora)
        {
            double totalSemana;
            totalSemana = horasTrabajadasSemana * valorHora;
            return totalSemana;
        }

        public static double calcularSueldoFindeSemana(double horasFindeSemana, double valorHora)
        {
            double valorHoraFindeSemana, totalFindeSemana;
            valorHoraFindeSemana = valorHora * 1.5;
            totalFindeSemana = valorHoraFindeSemana * horasFindeSemana;
            return totalFindeSemana;
        }

        public static double totalSueldo(double totalSemana, double totalFindeSemana, double bonos)
        {
            double sueldoTotal;
            sueldoTotal = (totalSemana + totalFindeSemana + bonos);
            return sueldoTotal;
        }

        public static double totalDescuentos(double descuentos, double anticipos)
        {
            double restaTotalSueldo;
            restaTotalSueldo = descuentos + anticipos;
            return restaTotalSueldo;
        }

        public static double descuentos_Prevision(int prevision, double sueldototal1)
        {
            if (prevision == 1)
            {
                double sueldoTotalCapital;
                double descuentoCapital = 11.44;
                sueldoTotalCapital = (sueldototal1 * Convert.ToInt32(descuentoCapital)) / 100;
                sueldototal1 = sueldototal1 - sueldoTotalCapital;
            }
            else if (prevision == 2)
            {
                double sueldoTotalCuprum;
                double descuentoCuprum = 11.48;
                sueldoTotalCuprum = (sueldototal1 * descuentoCuprum) / 100;
                sueldototal1 = sueldototal1 - sueldoTotalCuprum;
            }
            return sueldototal1;
        }

        public static double descuentos_Salud(double sueldoTotalPrevision, double restaTotalSueldo, int salud)
        {
            double sueldoTotal;
            if (salud == 1)
            {
                double sueldoTotalt;
                double descuentoFonasa = 7;
                sueldoTotalt = (sueldoTotalPrevision * descuentoFonasa) / 100;
                sueldoTotalPrevision = sueldoTotalPrevision - sueldoTotalt;

            }
            else if (salud == 2)
            {
                double monto;
                Console.Write("Ingrese el monto a descontar por isapre:$ ");
                monto = Convert.ToDouble(Console.ReadLine());
                sueldoTotalPrevision = sueldoTotalPrevision - monto;
            }

            sueldoTotalPrevision = sueldoTotalPrevision - restaTotalSueldo;
            return sueldoTotalPrevision;
        }
    }
}
