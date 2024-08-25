using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROGRA3.Models
{
    public class Bolsa
    {
        public string? Nombres {get;set;}
        public string? Correo {get;set;}
        public DateOnly FecOpe {get;set;}
        public bool Sp {get;set;}
        public bool Dj {get;set;}
        public bool Bu {get;set;}
        public decimal MontoAbonar {get;set;}
        public decimal Cobro{get;}
        public decimal Igv {get;}
        public decimal Total {get;}
        public Bolsa() { }
        public Bolsa(string _nombre, string _correo, DateOnly _fecope, bool _sp, bool _dj, bool _bu, decimal _montoabonar){
                Nombres = _nombre;
                Correo = _correo;
                FecOpe = _fecope;
                Sp = _sp;
                Dj = _dj;
                Bu = _bu;
                MontoAbonar = _montoabonar;
                // Cálculo de la comisión
             Cobro = MontoAbonar > 300 ? 1 : 3;

                // Cálculo del total incluyendo IGV
                Total = MontoAbonar + Cobro;
                Igv = 0.18m * Total;
                Total = MontoAbonar + Igv;
        }

    }
}