
using SessionOne;

var student = new Student();
var employee = new Employee();

var list = new List<Employee>()
{
    new Employee()
    {
        Name = "Malek",
    },
    new Employee()
    {
        Name = "Ahmad",
    }
};


var ahmad = list.FirstOrDefault(s => s.Name == "Ahmad");
var malek = list.FirstOrDefault(s => s.Name == "Malek");

//ahmad.SetIsDeleted(Guid.NewGuid());

Console.WriteLine($"Is Deleted = {ahmad.IsDeleted + " " + ahmad.Name + " " + ahmad.DeleteTime + " " + ahmad.DeleterId}");
Console.WriteLine($"Is Deleted =  {malek.IsDeleted + " " + malek.Name + " " + malek.DeleteTime + " " + malek.DeleterId}");

//DeleteAllUsers(list);
DeleteUser(ahmad);

Console.WriteLine($"Is Deleted = {ahmad.IsDeleted + " " + ahmad.Name + " " + ahmad.DeleteTime + " " + ahmad.DeleterId}");
Console.WriteLine($"Is Deleted =  {malek.IsDeleted + " " + malek.Name + " " + malek.DeleteTime + " " + malek.DeleterId}");


void DeleteAllUsers(List<Person> inputs)
{
    if (inputs is null || inputs?.Count == 0)
    {
        return;
    }

    foreach (var student in inputs)
    {
        if (student != null)
        {
            student.SetIsDeleted(Guid.NewGuid());
        }
    }
}

void DeleteUser(Person input)
{
    if (input is null)
    {
        return;
    }

    if (student != null)
    {
        student.SetIsDeleted(Guid.NewGuid());
    }
}

//Person studentWaseem = new Student();

//student.SetIdNumber(1);
//employee.SetIdNumber(500);

//SetIdNumber(employee);
//SetIdNumber(student);

//void SetIdNumber(Person input)
//{
//    input.SetIdNumber(1);
//    Console.WriteLine(input.IdNumber);
//}

