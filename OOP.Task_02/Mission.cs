namespace OOP.Task_02;
public sealed class Mission
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsValid => DateTime.Now <= ExpirationDate;
    public string Status { get; set; }
    public DateTime ExpirationDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public Mission()
    {
        CreatedDate = DateTime.Now;
    }
    public override string ToString()
    {
        return $"id: ({Id}) , name: ({Name}) , description: ({Description}) , is valid: ({IsValid}) , status: ({Status}) , expiration date: ({ExpirationDate}) ";
    }
}
