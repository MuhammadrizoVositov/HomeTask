

using System.Reflection.Metadata;
List<User> user = new List<User>()
{
    new User{Id=1,FirstName="Salim",LastName="Tolanov",Country="Uzb",StudyPlace="Tatu"},
    new User{Id=1,FirstName="Saloh",LastName="SoiPov",Country="RUS",StudyPlace="Adu"},
    new User{Id=1,FirstName="Farhod",LastName="Hojayev",Country="USA",StudyPlace="Fdu"},
    new User{Id=1,FirstName="Salimboy",LastName="Gofurov",Country="Korea",StudyPlace="Adu"},
    new User{Id=1,FirstName="Komil",LastName="Komilov",Country="Uzb",StudyPlace="Milliy"},
    new User{Id=1,FirstName="Salimboy",LastName="Gofurov",Country="USA",StudyPlace="Politex"},
    new User{Id=1,FirstName="Jamol",LastName="Komilov",Country="Uzb",StudyPlace="Agrar"},
    new User{Id=1,FirstName="Azizbek",LastName="Yaxyoyev",Country="RUS",StudyPlace="Med"},
    new User{Id=1,FirstName="Salimboy",LastName="Gofurov",Country="Uzb",StudyPlace="Singapurski"},
    new User{Id=1,FirstName="Sohibjon ",LastName="Hayitboyev",Country="BRIT",StudyPlace="Med"},
    new User{Id=1,FirstName="Salimboy",LastName="Gofurov",Country="Uzb",StudyPlace="Huquq"},
    new User{Id=1,FirstName="Iskandar",LastName="Gulomov",Country="BRIT",StudyPlace="Iqtisod"},
    new User{Id=1,FirstName="Salimboy",LastName="Gofurov",Country="Uzb",StudyPlace="Iqtisod"},
    new User{Id=1,FirstName="Odibek",LastName="Odilov",Country="KAZ",StudyPlace="Med"},
    new User{Id=1,FirstName="Maruf",LastName="Jinniyev",Country="KAZ",StudyPlace="Turin"},
};
var ozgartr = from coun in user
              where coun.Country == "Uzb"
              select coun;
ozgartr.ToList().ForEach(Console.WriteLine);

