
using Oop.item;


var salariedEmployee = new SalariedEmployee();
salariedEmployee.BasiSalary = 2000;
salariedEmployee.Housing = 1000;
salariedEmployee.Teansportaoin = 500;
salariedEmployee.SetFullName("Zeyed", "Abdoh");
salariedEmployee.Email = "Zeyad@gmail.com";
Console.WriteLine($"Salary of (without texes) salariedEmployee :{salariedEmployee.GetSalary():0.00}");
Console.WriteLine($"Salary of(with 10%texes) salariedEmployee :{salariedEmployee.GetSalary(10):0.00}");
Console.WriteLine($"Salary of(with 10% and Bonus) salariedEmployee :{salariedEmployee.GetSalary(10,20):0.00}");
var houryEmployee = new HouryEmployee();
houryEmployee.HouryRute = 100;
houryEmployee.TotaHours = 60;
houryEmployee.SetFullName("Ail", "Abdoh");
houryEmployee.Email = "WQSAD@gmail.com";
Console.WriteLine($"Salary of HouryEmployee :{houryEmployee.GetSalary():0.00}");
var interEmployee = new InterEmployee();
interEmployee.SetFullName("Raken", "Abdoh");
interEmployee.Email = "Raken@gmail.com";
Console.WriteLine($"Salary of InterEmployee :{interEmployee.GetSalary():0.00}");
Console.ForegroundColor= ConsoleColor.White;
Console.WriteLine("_____________________________________________________________");
var n = new Notufuer("maisiid@exds.com", 25, "sdas@ex.com", "ASSDA321");
var payslisGanerator  = new PayslisGanerator(n);
payslisGanerator.Ganerator(salariedEmployee);
payslisGanerator.Ganerator(houryEmployee);
payslisGanerator.Ganerator(interEmployee);

//Console.WriteLine("Encapualion");
//var emp = new Employee();
//emp.SetFullName("Zeyad", "Abdoh");
//emp.SetTaxPerchage(10);
//Console.WriteLine($"SetTaxPerchage IS : {emp.TaxPerchage}");
//emp.SetBirthDate(birthDate:new DateTime(2022,01,1));
//PrintPersonDetaits(emp);
//var applicant = new Applicant();
//applicant.SetFullName("Ail", "Abdoh");
//applicant.SetBirthDate(birthDate: new DateTime(2002, 1, 1));
//PrintPersonDetaits(applicant);
// void PrintPersonDetaits(Person person)
//{
//    Console.WriteLine($"----------------{person.GetType().Name}------------");
//    Console.WriteLine($"Full Nama Is : {person.FristName} {person.LastName[0]}");
//    Console.WriteLine(person.BirthDate.ToString("yy/MM/dd"));

//}