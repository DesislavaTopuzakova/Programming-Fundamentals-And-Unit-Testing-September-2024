//входни данни
string password = Console.ReadLine();

//проверка за въведената парола
if (password == "s3cr3t!")
{
    Console.WriteLine("Welcome");
}
else
{
    //обратен / противен случай: password != "s3cr3t!"
    Console.WriteLine("Wrong password!");
}
