using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TryToClick
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            int horizontalBorder = 200;
            int verticalBorder = 200;
            int left = (int)button.Margin.Left;
            int top = (int)button.Margin.Top;
            Random rand = new Random();

            int randomWay = rand.Next(0, 4);
            switch (randomWay)
            {
                case 0: if (button.Margin.Left > this.Width + horizontalBorder) left = (int)(button.Margin.Left - button.Width * 5);
                    else left = (int)(button.Margin.Left + button.Width * 5); 
                    break;

                case 1: if (left < this.Width - horizontalBorder) left = (int)(left + button.Width * 5);
                    else left = (int)(left - button.Width * 5);
                    break;

                case 2: if (top > this.Height + verticalBorder) top = (int)(top - button.Height * 5);
                    else top = (int)(top + button.Height * 5);
                    break;

                case 3:if (top < this.Height - verticalBorder) top = (int)(top + button.Height * 5);
                    else top = (int)(top - button.Height * 5);
                    break;
            }
            button.Margin = new Thickness(left, top, button.Margin.Right, button.Margin.Bottom);
        }
    }
}
