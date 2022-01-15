using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;



namespace CsGoMarketBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите id предмета: ");
                var itemId = Console.ReadLine();
                Console.WriteLine("Введите цену предмета: ");
                var iPrice = Console.ReadLine();
                Console.WriteLine("Введите трейд-ссылку партнера: ");
                var strPartnerAndToken = Console.ReadLine();

                




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
