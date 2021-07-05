using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

           //IKrediManager[] krediler = new IKrediManager[] { new IhtiyacKrediManager(), new KonutKrediManager(), new TasitKrediManager()};
           // foreach (IKrediManager kredi in krediler)
           // {
           //     kredi.Hesapla();
           // }
            
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new DatabaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);//yeni eklediğim esnaf kredisini hesaplayacak ve onu da sms e loglayacak.

            List<IKrediManager> krediler = new List<IKrediManager> {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);





            Console.ReadKey();
        }
    }
}
