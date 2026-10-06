using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Ragadozo : Allat
    {
        private int taplalekMennyiseg;

        public int TaplalekMennyiseg { get => taplalekMennyiseg; set {if (value <= 0) taplalekMennyiseg = 0; else if (value >= 10) taplalekMennyiseg = 10; else taplalekMennyiseg = value;} }

        public Ragadozo(string nev, int kor, int testsuly, int egeszseg, int taplalekMennyiseg) : base(nev, kor, testsuly, egeszseg)
        {
            this.taplalekMennyiseg = taplalekMennyiseg <= 0 ? 0 : (taplalekMennyiseg >= 10 ? 10 : taplalekMennyiseg);
        }


        public override string InformaciotAd()
        {
            return $"{this.Nev}- {this.Kor} éves ragadozó, {this.Testsuly} kg súllyal, táplálék: {this.TaplalekMennyiseg} kg";
        }

        public override string Gondoz(int ido)
        {
            this.TaplalekMennyiseg -= 5;
            if (this.TaplalekMennyiseg < 0)
            {
                this.TaplalekMennyiseg = 0;
            }

            return base.Gondoz(ido);
        }


    }
}
