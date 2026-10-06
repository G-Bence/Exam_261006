using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Madar : Allat
    {
       private int repulesiMagassag;
       public int RepulesiMagassag { get => repulesiMagassag; set { if(value <= 5) repulesiMagassag = 5; else if (value >= 500) repulesiMagassag = 500; else repulesiMagassag = value; } }

        public Madar(string nev, int kor, int testsuly, int egeszseg, int repulesiMagassag) : base(nev, kor, testsuly, egeszseg)
        {
            this.RepulesiMagassag = repulesiMagassag <= 5 ? 5 : (repulesiMagassag >= 500 ? 500 : repulesiMagassag);
        }

        public override string InformaciotAd()
        {
            return $"{this.Nev}- {this.Kor} éves madár, {this.Testsuly} kg súllyal, maximális repülési magassággal: {this.RepulesiMagassag} méter   ";
        }

        public override string Gondoz(int ido)
        {
            this.RepulesiMagassag += 100;
            return base.Gondoz(ido);
        }

    }
}
