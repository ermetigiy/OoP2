using System;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerSevice = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, new FileLoggerService ());

            System.Collections.Generic.List<IKrediManager> krediler = 
                new System.Collections.Generic.List<IKrediManager>() 
                { ihtiyacKrediManager,tasitKrediManager,konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
