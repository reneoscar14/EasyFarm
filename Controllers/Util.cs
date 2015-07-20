using EasyFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyFarm.Controllers
{
    public class Util
    {

        public Invernadero getInvernadero(string TipoCultivo, string Modo, double Temperatura, double HumedadRelativa, double HumedadSuelo, string parametros, string Riego, int TemporizadorRiego, int Flujo)
        {
            var invernadero = new Invernadero();
            invernadero.TipoCultivo = formatCultivo(TipoCultivo);
            invernadero.Modo = Modo;
            invernadero.Temperatura = Temperatura;
            invernadero.HumedadRelativa = HumedadRelativa;
            invernadero.HumedadSuelo = HumedadSuelo;
            invernadero.Riego = formatRiego(Riego);
            invernadero.CondicionRiego = "";
            invernadero.TemporizadorRiego = TemporizadorRiego;
            invernadero.Flujo = Flujo;
            invernadero.date = DateTime.Now;

            for (int i = 0; i < 4; i++) 
            {
                switch (i) 
                {
                    case 0: invernadero.Calefaccion = format(parametros.Substring(i, 1));
                    break;
                    case 1: invernadero.Ventilador = format(parametros.Substring(i , 1));
                    break;
                    case 2: invernadero.Extractor = format(parametros.Substring(i , 1));
                    break;
                    case 3: invernadero.Iluminacion = format(parametros.Substring(i, 1));
                    break;
                }
            }

                    return invernadero;
        }

        public string format(string entered) 
        {
            if (entered == "O")
                return "ON";
            else
                return "OFF";
        }
        public string formatRiego(string entered) 
        {
            switch (entered) 
            {
                case "R":
                    return "Riego0";
                case "E":
                    return "Espera";
                case "F":
                    return "OFF";
                default:
                    return "";
            }
        }
        public string formatCultivo(string entered) 
        {
            switch (entered)
            {
                case "A":
                    return "Aji";
                case "T":
                    return "Tomate";
                case "P":
                    return "Pepino";
                default:
                    return "";
            }
        
        
        }
    }
}
