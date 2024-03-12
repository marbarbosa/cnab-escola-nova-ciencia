namespace SENC;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // # Passos para criar esse projeto. c
        // dotnet new winforms -o SENC
        ApplicationConfiguration.Initialize();
        Application.Run(new Menu());
    }    
}