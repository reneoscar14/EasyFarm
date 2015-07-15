using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyFarm.Models
{
    public class Invernadero
    {
        public int InvernaderoId { get; set; }
        public double Temperatura { get; set; }
        [Display(Name="Humedad Relativa")]
        public double HumedadRelativa { get; set; }
        [Display(Name = "Humedad del Suelo")]
        public double HumedadSuelo { get; set; }
        [Display(Name = "Tipo de Cultivo")]
        public int TipoCultivo { get; set; }
        public int Calefaccion { get; set; }
        public int Ventilador { get; set; }
        public int Extractor { get; set; }
        public double Flujo { get; set; }
        public int Modo { get; set; }
        public int Iluminacion { get; set; }
        public int Riego { get; set; }
        [Display(Name = "Etapa de Riego")]
        public int EtapaRiego { get; set; }

    }
}