Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "софья")
{
    Console.WriteLine("Привет, это же Софья!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
