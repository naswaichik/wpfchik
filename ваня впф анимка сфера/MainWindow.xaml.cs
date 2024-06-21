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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Задание_3_Анимация
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RadialGradientBrush brush = pulsarEllipse.Fill as RadialGradientBrush;
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.2;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromSeconds(2));
            animation.AutoReverse = true;
            animation.RepeatBehavior = RepeatBehavior.Forever;

            // Применяем анимацию к радиусу градиента
            brush.BeginAnimation(RadialGradientBrush.RadiusXProperty, animation);
            brush.BeginAnimation(RadialGradientBrush.RadiusYProperty, animation);
        }
    }
}
