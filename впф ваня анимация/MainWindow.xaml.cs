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

namespace Задание_2_Анимация
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
        private void runAwayButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            double newX = random.Next(0, (int)(ActualWidth - runAwayButton.ActualWidth));
            double newY = random.Next(0, (int)(ActualHeight - runAwayButton.ActualHeight));
            runAwayButton.Margin = new Thickness(newX, newY, 0, 0);
        }
    }
}

