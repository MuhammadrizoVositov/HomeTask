public  class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Country { get; set; }
    public string StudyPlace { get; set; }
    public override string ToString()
    {
        return $"Ismi:{FirstName}\n Familya:{LastName}\n Davlati:{Country}";
    }

}