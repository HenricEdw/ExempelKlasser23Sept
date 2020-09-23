using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilTest
{
    class Bil
    {
        //Medlemsvariabel/Inastansvariabel
        public string Färg;
        public string RegNummer;
        private int MaxHastighet;
        private int CurrentSpeed;
        

        public Bil(string Färg, string RegNummer, int MaxHastighet)
        {
            this.Färg = Färg;
            this.RegNummer = RegNummer;
            this.MaxHastighet = MaxHastighet;
            CurrentSpeed = 0;
        }

        public Bil(){}

        public string GetFärg()
        {
            return Färg;
        }

        public int GetMaxHastighet()
        {
            return MaxHastighet;
        }

        public void SetFärg(string färg)
        {
            if (färg == "Röd")
            {
                Färg = "Svart";
            }
            else
            {
                Färg = färg;
            }
        }

        public int Gasa(int speed)
        {
            if (speed > MaxHastighet)
            {
                CurrentSpeed = MaxHastighet;
            }
            else
            {
                CurrentSpeed = speed;
            }

            return CurrentSpeed;
        }
    }
}
