using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kunden
{
    class Kunde
    {
        public string vrnm;
        public string ncnm;
        public string email;
        public string pswrt;
        public string stdt;
        public Kunde(string vrnm, string ncnm, string email, string pswrt, string stdt)
        {
            this.vrnm = vrnm;
            this.ncnm = ncnm;
            this.email = email;
            this.pswrt = pswrt;
            this.stdt = stdt;
        }
        public Kunde(string email, string pswrt)
        {
            this.email = email;
            this.pswrt = pswrt;
        }
        public void KndNeu()
        {
            Console.WriteLine(vrnm + " " + ncnm + " " + email + " " + pswrt + " " + stdt);
        }
        public void Knd()
        {
            Console.WriteLine(email + " " + pswrt);
        }
        public static void Main()
        {
            Console.WriteLine("Neu?");
            string wahl;
            wahl = Console.ReadLine();
            switch (wahl)
            {
                case "y":
                    string vrnm = Console.ReadLine();
                    string ncnm = Console.ReadLine();
                    string email = Console.ReadLine();
                    string pswrt = Console.ReadLine();
                    string stdt = Console.ReadLine();
                    Kunde knd = new Kunde(vrnm, ncnm, email, pswrt, stdt);
                    knd.KndNeu();
                    break;
                case "n":
                    email = Console.ReadLine();
                    pswrt = Console.ReadLine();
                    Kunde knd2 = new Kunde(email, pswrt);
                    knd2.Knd();
                    break;
            }Console.ReadLine();
            


        }
    }


}
