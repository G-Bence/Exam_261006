using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Allat
    {
        private string nev;
        private int kor;
        private int testsuly;
        private int egeszseg;
        private bool gondozasSzukseges;

        public string Nev { get => nev; set {if (value == null || value.Length <= 0) nev = "NÉVTELEN"; else nev = value; } }
        public int Kor { get => kor; set { if (value <= 0) kor = 0; else if (value >= 80) kor = 80; else kor = value; } }
        public int Testsuly { get => testsuly; set { if (value <= 0) testsuly = 0; else testsuly = value; } }
        public int Egeszseg { get => egeszseg; set { if (value <= 0) egeszseg = 0; else if (value >= 100) egeszseg = 100; else egeszseg = value; } }
        public bool GondozasSzukseges { get => gondozasSzukseges; set {if (this.egeszseg <= 50) gondozasSzukseges = true; else gondozasSzukseges = false; } }

        public Allat(string nev, int kor, int testsuly, int egeszseg)
        {
            this.Nev = nev;
            this.Kor = kor;
            this.Testsuly = testsuly;
            this.Egeszseg = egeszseg;
            this.gondozasSzukseges = egeszseg <= 50 ? true : false;

            //Maybe you need to set the defaults manually
        }


        public virtual string InformaciotAd()
        {
            return $"{this.nev}- {this.kor} éves állat, {this.testsuly} kg súllyal";
        }

        public virtual string Gondoz(int ido)
        {
            if (ido > 30)
            {
                this.testsuly += 2;
            }

            this.egeszseg += 15;

            if (this.egeszseg < 50)
            {
                this.egeszseg = 50;
            }

            return "állat gondozása megtörtént";
        }
    }
}
