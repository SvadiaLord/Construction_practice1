using Construction_practice1.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ClassPerson classPerson = new ClassPerson(17, "Leha");
            classPerson.DisplayInfo();

            ClassCar classCar = new ClassCar("Lada", "Kalina", 1986);
            classCar.DisplayInfo();

            ClassBook classBook = new ClassBook("Магическая Битва: Satory ГОЙДА Edition", "Гена Цидармян", 666);
            classBook.DisplayInfo();

            ClassRectangle classRectangle = new ClassRectangle(100, 200);
            classRectangle.DisplayInfo();

            ClassCircle classCircle = new ClassCircle(100);
            classCircle.DisplayInfo();

            ClassStudent classStudent = new ClassStudent("Leha", "П23-2.1", 23678778);
            classStudent.DisplayInfo();

            ClassEmployee classEmployee = new ClassEmployee("Иван", "Менеджер", 50000);
            classEmployee.RaiseSalary(10);
            Console.WriteLine($"Зарплата после повышения: {classEmployee.Salary}");

            ClassBankAccount classBankAccount = new ClassBankAccount("123456789", 1000);
            classBankAccount.Deposit(500);
            classBankAccount.Withdraw(200);
            Console.WriteLine($"Баланс счета: {classBankAccount.Balance}");

            ClassMovie classMovie = new ClassMovie("В поисках Немо", "Эндрю Стэнтон", 2003);
            classMovie.DisplayInfo();

            ClassAnimal classAnimal = new ClassAnimal("Барсик", "Кот");
            classAnimal.DisplayInfo();

            ClassProduct classproduct = new ClassProduct("Яблоко", 10.99m, 100);
            classproduct.AddStock(50);
            classproduct.RemoveStock(20);
            Console.WriteLine($"Количество товара: {classproduct.Quantity}");
        }
    }
}
