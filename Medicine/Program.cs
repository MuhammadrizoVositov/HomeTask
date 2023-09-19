
using Bogus;
using Medicine;

static void Main(string[] args)
{
    int idSeed = 1;
    Faker<Student> studentFaker = new Faker<Student>()
    .RuleFor(student => student.Id, id => idSeed)
    .RuleFor(student => student.Name, name => name.Person.FirstName)
    .RuleFor(student => student.Description, description => description.Lorem.Paragraph(10))
    .RuleFor(student => student.PhoneNumber, number => number.Person.Phone)
    .RuleFor(student => student.EmailAdress, email => email.Person.Email);



}
