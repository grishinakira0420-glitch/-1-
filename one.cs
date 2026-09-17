using System;
using System.Collections.Generic;

class Program
{
    static List<string> users = new List<string>();
    static string[] books = { "Книга 1", "Книга 2", "Книга 3" };

    public void main ()
    {
        Console.Write("Имя: ");
        string name = Console.ReadLine();
        Console.Write("Фамилия: ");
        string surname = Console.ReadLine();
        string user = name + " " + surname;

        if (users.Contains(user))
            ChooseBook(user);
        else
        {
            CreateCard(user);
            ChooseBook(user);
        }
    }

    static void CreateCard(string user)
    {
        users.Add(user);
        Console.WriteLine("Карточка создана");
    }

    static void ChooseBook(string user)
    {
        Console.WriteLine("Выберите книгу (1-3):");
        for (int i = 0; i < books.Length; i++)
            Console.WriteLine((i + 1) + ". " + books[i]);
        
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы взяли: " + books[choice - 1]);
    }
}

}
