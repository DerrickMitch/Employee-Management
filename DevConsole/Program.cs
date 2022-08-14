using DevConsole;

var db = new EMDatabase();

IQueryable<Employee> employees = db.Employees;

foreach (var em in employees)
{
    Console.WriteLine($"{em.ID} - {em.LastName}, {em.FirstName} | Managed By: {(em.ManagerID != null ? em.Manager.FirstName : null)}");
}