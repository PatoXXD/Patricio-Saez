using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo_Trabajador
{
    class MostrarMetodos
    {
        public static void mMetodos()
        {
            string apellido, nombre;
            int prevision, salud;
            double mes, año, horasTrabajadasSemana, horasFindeSemana, valorHora,
                anticipos, descuentos, bonos, totalSemana, totalFindeSemana, restaTotalSueldo;
            double rut, sueldoTotalPrevision, sueldoTotalNeto, sueldoTotal;
            //
            Consultas.ConsultaNombres();
            nombre = Captura.CapturarNombres();
            Consultas.ConsultaApellidos();
            apellido = Captura.CapturarApellidos();
            Consultas.ConsultaRut();
            rut = Captura.CapturaRut();
            Consultas.Consultames();
            mes = Captura.Capturames();
            Consultas.ConsultaAño();
            año = Captura.CapturaAño();
            Consultas.ConsultaHorasTrabajasSemana();
            horasTrabajadasSemana = Captura.CapturaHorasTrabajasSemana();
            Consultas.ConsultaHorasTrabajasFindeSemana();
            horasFindeSemana = Captura.CapturarHorasTrabajasFindeSemana();
            Consultas.ConsultaValorHora();
            valorHora = Captura.CapturaValorHora();

            //-----------------------------------------------------------------------------




            Consultas.ConsultaPrevision();
            prevision = Captura.seleccion_Prevision();
            Consultas.ConsultaSalud();
            salud = Captura.seleccionSalud();
            Consultas.ConsultaAnticipos();
            anticipos = Captura.CapturaAnticipos();
            Consultas.ConsultaDescuentos();
            descuentos = Captura.CapturaDescuentos();
            Consultas.ConsultaBonos();
            bonos = Captura.CapturaBonos();
            totalSemana = Operaciones.calcularTotalSueldoSemana(horasTrabajadasSemana, valorHora);
            totalFindeSemana = Operaciones.calcularSueldoFindeSemana(horasFindeSemana, valorHora);
            ///---------------------------------------------------------------------------------------------------------
            ///

            sueldoTotalNeto = Operaciones.totalSueldo(totalSemana, totalFindeSemana, bonos);
            sueldoTotalPrevision = Operaciones.descuentos_Prevision(prevision, sueldoTotalNeto);
            restaTotalSueldo = Operaciones.totalDescuentos(descuentos, anticipos);
            sueldoTotal = Operaciones.descuentos_Salud(sueldoTotalPrevision, restaTotalSueldo, salud);

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            MostrarPlanilla.mostrar(apellido, nombre, prevision, rut, mes, año, horasTrabajadasSemana,
                            horasFindeSemana, valorHora, anticipos, descuentos, bonos, totalSemana,
                            totalFindeSemana, restaTotalSueldo, sueldoTotalNeto, salud, sueldoTotal);
            Console.ReadKey();

        }
    }
}
