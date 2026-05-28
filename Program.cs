using System;
using System.Windows.Forms;

internal static class Program
{
    [STAThread]//This is required for Windows Forms applications.
    static void Main()//The entry point of the application.
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new CyberGuard.MainForm());
    }


   
}