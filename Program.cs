using System.Diagnostics;
using System.Net;
class Program
{
    static void Main(string[] args)
{
    string Key;
    string Key1;
    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        Console.Write("Desktop Shortcut [y/n] ");
    Key = Console.ReadLine();
    if (Key == "y")
    {
        using (var client = new WebClient())
        {
            client.DownloadFile("https://raw.githubusercontent.com/Das-Kampfnudelholz/Spicetify-Installer/main/Spotify.exe", path + "/Spotify.exe");
        }
    }
    Console.Write("Add to autostart [y/n] ");
    Key1 = Console.ReadLine();
    if (Key1 == "y")
    {
        using (var client = new WebClient())
        {
            client.DownloadFile("https://raw.githubusercontent.com/Das-Kampfnudelholz/Spicetify-Installer/main/Spotify.exe", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "/Spotify.exe");
        }
    }
        Installer();
}

    public static void Installer()
    {




        System.Diagnostics.Process.Start("CMD.exe", "/C powershell.exe   \"iwr -useb https://raw.githubusercontent.com/spicetify/spicetify-cli/master/install.ps1 | iex\"");
        System.Diagnostics.Process.Start( "CMD.exe", "/C powershell.exe   \"iwr -useb https://raw.githubusercontent.com/spicetify/spicetify-marketplace/main/resources/install.ps1 | iex \"");
        System.Diagnostics.Process.Start("CMD.exe", "/C exit");
    }
}
   