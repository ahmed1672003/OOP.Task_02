using OOP.Task_02;

MissionOperations operations = new MissionOperations();

operations.Create(new()
{
    Id = 1,
    CreatedDate = DateTime.Now,
    ExpirationDate = DateTime.Now.AddDays(5),
    Name = "Test",
    Description = "description !",
    Status = "Is not Deliveried"
});

operations.Update(new()
{
    Id = 1,
    Name = "Changed Test",
    Description = "Changed Description !",
    Status = "Success",
    ExpirationDate = DateTime.Now.AddDays(30)
}, 1);
Console.WriteLine(operations.RetrieveById(1));
operations.Delete(1);

Console.WriteLine(operations.Count());
