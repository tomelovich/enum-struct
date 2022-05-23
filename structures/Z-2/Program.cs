using System;

namespace Z_2
{
    class Program
    {
        class Accauntant
        {
            public enum Employees
            {
                ChiefExecutiveOfficer = 220,
                ChiefTechnologyOfficer = 250,
                JuniorDeveloper = 210,
                MiddleDeveloper = 240,
                SeniorDeveloper = 220,
                QualityAssuranceEngineers = 270
            }
            public void AskForBonus(Employees postWorker, int hours)
            {                              
                if ((int)postWorker < hours)
                {
                    Console.WriteLine("Необходимо начислить премию");
                }
                else
                {
                    Console.WriteLine("Начислять премию не нужно");
                }
            }    
        }
        static void Main(string[] args)
        {
            Accauntant с = new Accauntant();
            с.AskForBonus(Accauntant.Employees.ChiefExecutiveOfficer, 240);
            с.AskForBonus(Accauntant.Employees.ChiefTechnologyOfficer, 220);
            с.AskForBonus(Accauntant.Employees.JuniorDeveloper, 235);
            с.AskForBonus(Accauntant.Employees.MiddleDeveloper, 225);
            с.AskForBonus(Accauntant.Employees.SeniorDeveloper, 240);
            с.AskForBonus(Accauntant.Employees.QualityAssuranceEngineers, 215);
        }
    }
}
