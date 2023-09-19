using HT_1_Models;
var users = new List<User>()
{
    new User("jalol","jabborov","jaloljabbarov"),
    new User("jamol","Komilov","Ibrohimjabbarov@gmail.com"),
    new User("kamol","Qosimoq","mashhurjabbarov@gmail.com"),
    new User("Qosim","jamolov","Qosimovjabbarov@gmail.com"),
    new User("Odil","odilov","odiloc@gamil.com"),
};
var usersContainer = new UsersContainer(users);
Console.WriteLine(usersContainer[users[0].Id]);
Console.WriteLine();
Console.WriteLine(usersContainer["ja"]);
Console.WriteLine();
Console.WriteLine(usersContainer[2]);