

using RegistrationServise;

EmailSenderService emailSenderService = new EmailSenderService();
AccauontServise accauontServise = new AccauontServise(emailSenderService);
try
{
    accauontServise.Register("Joniber@gmail.com", "pasword12345");
    Console.WriteLine("Account succsefully registrated");

}
catch(ArgumentException ex)
{
    Console.WriteLine($"Argument Exeption{ex.Message}");
}
catch(InvalidOperationException ex)
{
    Console.WriteLine($"Invalid Operation{ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Exception{ex.Message}");
}
