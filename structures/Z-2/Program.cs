using System;

namespace Z_2
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

    class Accauntant
    {
        public bool AskForBonus(Employees postWorker, int hours)
        {                              
            if ((int)postWorker < hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant с = new Accauntant();
            Console.WriteLine(с.AskForBonus(Employees.ChiefExecutiveOfficer, 240));
            Console.WriteLine(с.AskForBonus(Employees.ChiefTechnologyOfficer, 220));
            Console.WriteLine(с.AskForBonus(Employees.JuniorDeveloper, 235));
            Console.WriteLine(с.AskForBonus(Employees.MiddleDeveloper, 225));
            Console.WriteLine(с.AskForBonus(Employees.SeniorDeveloper, 240));
            Console.WriteLine(с.AskForBonus(Employees.QualityAssuranceEngineers, 215));
        }
    }
}
