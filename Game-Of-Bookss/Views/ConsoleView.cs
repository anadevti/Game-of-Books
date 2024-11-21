using System;
using System.Collections.Generic;
using Game_Of_Bookss.Models;

namespace Game_Of_Bookss.Views
{
    public class ConsoleView
    {
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=============================================");
            Console.WriteLine("     Sistema de Gerenciamento de Biblioteca");
            Console.WriteLine("=============================================");
            Console.WriteLine("1. Listar Livros");
            Console.WriteLine("2. Adicionar Livro");
            Console.WriteLine("3. Emprestar Livro");
            Console.WriteLine("4. Devolver Livro");
            Console.WriteLine("5. Sair");
            Console.WriteLine("=============================================");
            Console.Write("Escolha uma opção: ");
        }

        public void ShowMessage(string message, bool isError = false)
        {
            Console.ForegroundColor = isError ? ConsoleColor.Red : ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void ShowBooks(IEnumerable<Book> books)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine($"{"Título",-20} {"Autor",-20} {"Ano",-5} {"Disponível",-10}");
            Console.WriteLine("=============================================");

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title,-20} {book.Author,-20} {book.YearOfPublication,-5} {book.CheckAvailability(),-10}");
            }
        }
    }
}