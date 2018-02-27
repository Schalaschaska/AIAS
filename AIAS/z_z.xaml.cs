using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace AIAS
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class z_z : Page
    {
        public z_z()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regex X = new Regex(@"^\d*(-\d+)?$");
            if (X.IsMatch(t_1.Text))
            {

                int n = Convert.ToInt32(t_1.Text);
                List<int> N_list = new List<int>();
                for (int i = 0; i <= 6; i++)
                {
                    int x = n % 10;
                    int y = n / 10;
                    if (x < -4)
                    {
                        x = 10 + x;
                        y--;
                    }
                    if (x > 4)
                    {
                        x = x - 10;
                        y++;
                    }
                    N_list.Add(x);
                    n = y;
                }
                int[] mas = N_list.ToArray<int>();
                string rez_t = String.Join(" ", mas.Select(s => s.ToString()).ToArray());
                rez.Text = rez_t;
            }
            else
            {
                rez.Text = "Ошибка ввода";
            }
        }
    }
}
