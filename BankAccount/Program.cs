using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            savingAccount megtakaritasiSzamla = new savingAccount();
            megtakaritasiSzamla.updateBalance(23652);
            megtakaritasiSzamla.updateBalance(2000);
            Console.WriteLine(megtakaritasiSzamla.returnBalance());
            Console.ReadKey();
        }
    }
}
