﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower()== "пирожок")
{
    Console.WriteLine("Ура, это же Чубася");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}