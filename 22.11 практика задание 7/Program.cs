using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._11_практика_задание_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = Interaction.InputBox("Введите ваше имя",
                "Ввод имени");
            string year1;
            year1 = Interaction.InputBox("Введите ваш год рождения",
                "Ввод вашего года рождения");
            string year2;
            year2 = Interaction.InputBox("Введите текуший год", "Ввод текущего года");
            int x = Convert.ToInt32(year1);
            int y = Convert.ToInt32(year2);
            int age = y - x;
            string res = "имя: " + name + ", возраст: " + age ;
            MessageBox.Show(res, "Результат");
        }
    }
}
