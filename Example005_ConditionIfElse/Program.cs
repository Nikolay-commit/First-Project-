Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "марина")
{
    Console.WriteLine("Ура, это же МАРИНЭ!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}