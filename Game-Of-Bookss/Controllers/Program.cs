using Game_Of_Bookss.Controllers;

class Program
{
    static void Main(string[] args)
    {
        var controller = new LibraryController();
        controller.InitializeLibrary();
        controller.Run();
    }
}