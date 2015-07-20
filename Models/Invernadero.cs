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
        [Display(Name = "Cultivo")]
        public string TipoCultivo { get; set; }
        public string Modo { get; set; }
        public double Temperatura { get; set; }
        [Display(Name="HR")]
        public double HumedadRelativa { get; set; }
        [Display(Name = "HS")]
        public double HumedadSuelo { get; set; }
        public string Calefaccion { get; set; }
        public string Ventilador { get; set; }
        public string Extractor { get; set; }
        public string Iluminacion { get; set; }
        public string Riego { get; set; }
        [Display(Name = "CR")]
        public string CondicionRiego { get; set; }
        [Display(Name = "TR")]
        public int TemporizadorRiego { get; set; }
        public double Flujo { get; set; }
        [Display(Name = "Actualizado")]
        public DateTime date { get; set; }

    }
}