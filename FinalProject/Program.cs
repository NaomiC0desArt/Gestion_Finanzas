
using FinalProject.Context;
using FinalProject.Forms.Auth;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Windows.Forms;

namespace FinalProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Batteries.Init();

            using (var db = new AppDbContext())
            {
                db.Database.Migrate(); // crea el .db y aplica TODAS las migraciones pendientes
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}