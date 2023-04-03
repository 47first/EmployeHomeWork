using System;

namespace EmployeHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe[] employes = new Employe[10]
            { 
                new Employe("Харитон", "Захаров", "Радеонович", "Вавилов", 30000m),
                new Employe("Михаэль", "Штокхаузен", "Генрихович", "Челомей", 45000m),
                new Employe("Виктор", "Петров", "Васильевич", "Павлов", 30000m),
                new Employe("Лариса", "Филатова", "Андреевна", "Нептун", 20000m),
                new Employe("Дмитрий", "Сеченов", "Сергеевич", "Челомей", 80000m),
                new Employe("Луффи", "Монки Д", "Драгонов", "Вавилов", 15000m),
                new Employe("Зина", "Муравьева", "Петровна", "Нептун", 10000m),
                new Employe("Усопп", "Годов", "Батькович", "Павлов", 30000m),
                new Employe("Зоро", "Ророноа", "Михоукович", "Челомей", 70000m),
                new Employe("Фрэнки", "Супэров", "Томов", "Нептун", 40000m),
            };

            ShowAllEmployersData(employes);
            Console.WriteLine();

            ShowSumOfSalary(employes);
            Console.WriteLine();

            ShowMinSalary(employes);
            Console.WriteLine();

            ShowMaxSalary(employes);
            Console.WriteLine();

            ShowAverageSalary(employes);
            Console.WriteLine();

            ShowFullNames(employes);

            Console.ReadLine();
        }

        private static void ShowAllEmployersData(Employe[] employes)
        {
            Console.WriteLine("Id\tФИО - Отдел - Зарплата");

            foreach (var employe in employes)
                Console.WriteLine(employe.ToString());
        }

        private static void ShowSumOfSalary(Employe[] employes)
        {
            Console.WriteLine($"Затраты на зарплаты: {GetSumOfSalaries(employes)}");
        }

        private static decimal GetSumOfSalaries(Employe[] employes)
        {
            decimal totalSum = 0;

            foreach (var employe in employes)
                totalSum += employe.Salary;

            return totalSum;
        }

        private static void ShowMinSalary(Employe[] employes)
        {
            Employe minSalaryEmploye = employes[0];

            foreach (var employe in employes)
                if (employe.Salary < minSalaryEmploye.Salary)
                    minSalaryEmploye = employe;

            Console.WriteLine($"Сотрудник с минимальной зарплатой:\n{minSalaryEmploye}");
        }

        private static void ShowMaxSalary(Employe[] employes)
        {
            Employe maxSalaryEmploye = employes[0];

            foreach (var employe in employes)
                if (employe.Salary > maxSalaryEmploye.Salary)
                    maxSalaryEmploye = employe;

            Console.WriteLine($"Сотрудник с максимальной зарплатой:\n{maxSalaryEmploye}");
        }

        private static void ShowAverageSalary(Employe[] employes)
        {
            decimal sumOfSalaries = GetSumOfSalaries(employes);

            Console.WriteLine($"Средняя зарплата: {sumOfSalaries / employes.Length}");
        }

        private static void ShowFullNames(Employe[] employes)
        {
            Console.WriteLine($"ФИО сотрудников:");

            foreach (var employe in employes)
                Console.WriteLine(employe.FullName);
        }
    }
}
