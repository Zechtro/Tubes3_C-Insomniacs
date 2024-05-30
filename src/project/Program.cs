using System;
using WinFormsApp3.backend;

namespace WinFormsApp3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            // Debug.WriteLine("constructor fired");
            // System.Diagnostics.Debug.WriteLine("asdasd;aoisjdfkasjdf;");
            // Console.WriteLine("WHasdslkafd;alskdf/lsdaAT");
        }

        
    }
}
