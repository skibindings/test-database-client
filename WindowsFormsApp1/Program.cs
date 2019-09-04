using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*using (The_State_Duma_Entities db = new The_State_Duma_Entities(DBUtils.getConnString()))
            {
         
                DbConnection conn = db.Database.Connection;
                try
                {
                    conn.Open();   // check the database connection
                    Console.WriteLine("Connection success");
                }
                catch
                {
                    Console.WriteLine("Сonnection failed");
                }

                var sozyvies = db.Sozyvies.ToList();
                foreach (var p in sozyvies)
                    Console.WriteLine("{0} - {1} - {2}", p.Nomer, p.Data_nachala, p.Data_konca);
            } */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
