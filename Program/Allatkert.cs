using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Allatkert
    {
        private List<Allat> allatokk;

        public Allatkert()
        {
            this.allatokk = new List<Allat>();
        }

        public void AllatFelvetele(Allat allat)
        {
            allatokk.Add(allat);
            Console.WriteLine("az állat megérkezett az állatkertbe");
        }

        public void InformaciokListazasa()
        {
            foreach (var item in allatokk)
            {
                Console.WriteLine(item.InformaciotAd());
            }
        }


        public void CsoportosGondozas(int ido)
        {
            foreach (var item in allatokk)
            {
              if (item.GondozasSzukseges)
                {
                    item.Gondoz(ido);
                }
              else
                {
                    Console.WriteLine($"A {item.Nev} gondozása jelenleg nem szükséges");
                }
            }
        }
    }
}
