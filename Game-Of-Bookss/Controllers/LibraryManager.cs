using System;
using System.Collections.Generic;
using System.Linq;
using Game_Of_Bookss.Models;
using Game_Of_Bookss.Views;

namespace Game_Of_Bookss.Controllers
{
    public class LibraryController
    {
        private readonly List<Book> _books = new List<Book>();
        private readonly ConsoleView _view = new ConsoleView();

        public void InitializeLibrary()
        {
            _books.Add(new Book("1984", "George Orwell", "Dystopian", 1949));
            _books.Add(new Book("O Senhor dos Anéis", "J.R.R. Tolkien", "Fantasy", 1954));
            _books.Add(new Book("O Pequeno Príncipe", "Antoine de Saint-Exupéry", "Children's Literature", 1943));
            _books.Add(new Book("Dom Quixote", "Miguel de Cervantes", "Adventure", 1605));
            _books.Add(new Book("A Revolução dos Bichos", "George Orwell", "Political satire", 1945));
        }

        public void Run()
        {
            while (true)
            {
                _view.ShowMenu();
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ListBooks();
                        break;
                    case "2":
                        AddBook();
                        break;
                    case "3":
                        BorrowBook();
                        break;
                    case "4":
                        ReturnBook();
                        break;
                    case "5":
                        ViewLoans();
                        break;
                    case "6":
                        return;
                    default:
                        _view.ShowMessage("Opção inválida!", true);
                        break;
                }
            }
        }

        private void ListBooks()
        {
            _view.ShowBooks(_books);
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
        }


        private void AddBook()
        {
            Console.Write("Título: ");
            string title = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(title))
            {
                _view.ShowMessage("Título não pode ser vazio!", true);
                return;
            }

            Console.Write("Autor: ");
            string author = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(author))
            {
                _view.ShowMessage("Autor não pode ser vazio!", true);
                return;
            }

            Console.Write("Gênero: ");
            string genre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(genre))
            {
                _view.ShowMessage("Gênero não pode ser vazio!", true);
                return;
            }

            Console.Write("Ano de Publicação: ");
            if (int.TryParse(Console.ReadLine(), out int year) && year > 0)
            {
                _books.Add(new Book(title, author, genre, year));
                _view.ShowMessage("Livro adicionado com sucesso!");
            }
            else
            {
                _view.ShowMessage("Ano inválido!", true);
            }
        }


        private void BorrowBook()
        {
            Console.Write("Título do livro: ");
            string title = Console.ReadLine();
            var book = _books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (book == null || !book.CheckAvailability())
            {
                _view.ShowMessage("Livro não encontrado ou indisponível!", true);
                return;
            }

            Console.Write("Nome do usuário: ");
            string userName = Console.ReadLine();
            Console.Write("E-mail do usuário: ");
            string userEmail = Console.ReadLine();

            var user = new User(userName, userEmail);
            var loan = new Loan(book, user, DateTime.Now, DateTime.Now.AddDays(14));
            _view.ShowMessage("Livro emprestado com sucesso!");
        }

        private void ReturnBook()
        {
            Console.Write("Título do livro: ");
            string title = Console.ReadLine();
            var book = _books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (book == null)
            {
                _view.ShowMessage("Livro não encontrado!", true);
                return;
            }

            book.MarkAsReturned();
            _view.ShowMessage("Livro devolvido com sucesso!");
        }

        private void ViewLoans()
        {
            _view.ShowMessage("Funcionalidade a ser implementada...");
        }
    }
}
