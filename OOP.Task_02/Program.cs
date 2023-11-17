using OOP.Task_02;

MissionOperations operations = new MissionOperations();

operations.Create(new Mission()
{
    Id = 1,
    CreatedDate = DateTime.Now,
    ExpirationDate = DateTime.Now.AddDays(5),
    Name = "Test",
    Description = "description !",
    Status = "Is not Deliveried"
});

operations.Delete(1);
Console.WriteLine(operations.RetrieveById(1));

Console.WriteLine(operations.Count());
