using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosFinal
{
    class Planilla
    {

        public string empleado { get; set; }
        public string cargo { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int anios { get; set; }


        public int anioServicio()
        {
            return DateTime.Now.Year - fechaIngreso.Year;
        }

        public string mesConsultado()
        {
            int mes = DateTime.Now.Month;
            switch (mes)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
            }
            return "";
        }


        public double determinaSueldoBasico()
        {
            switch (cargo)
            {
                case "Coordinador": return 2000;
                case "Jefe": return 4000;
                case "Capacitador": return 2500;
                case "Asistente": return 1200;
            }

            return 0;
        }


        public double determinaGratificacion()
        {
            if(mesConsultado() == "Abril")
            {
                return 400;
            }else if(mesConsultado() == "Julio")
            {
                return 450;
            }else if(mesConsultado() == "Diciembre")
            {
                return determinaSueldoBasico() * 2;
            }

            return 0;
        }


        public double determinaComision()
        {
            if(cargo == "Asistente")
            {
                return 100;
            }else if(cargo == "Coordinador")
            {
                return 250;
            }

            return 0;
        }


        //Descuento AFP
        public double determinaAFP()
        {
            return 0.12 * determinaSueldoBasico();
        }


        //Descuento de cooperativa
        public double determinaDescuentoCooperativa()
        {
            if(cargo == "Jefe")
            {
                return 5.0 / 100 * determinaSueldoBasico();
            }else if(cargo == "Capacitador")
            {
                return 2.0 / 100 * determinaSueldoBasico();
            }

            return 0;
        }

        //aportaciones
        public double determinaSeguro()
        {
            return 0.05 * determinaSueldoBasico();
        }




        //CALCULOS DE TOTALES--------------------------------------------
        public double calculaTotalIngresos()
        {
            return determinaSueldoBasico() + determinaGratificacion()
                + determinaComision();
        }

        public double calculaTotalDescuentos()
        {
            return determinaAFP() + determinaDescuentoCooperativa();
        }


        public double calculaTotalAportaciones()
        {
            return determinaSeguro();
        }

        public double determinaNeto()
        {
            return calculaTotalIngresos() - calculaTotalDescuentos()
                - calculaTotalAportaciones();
        }
    }
}
