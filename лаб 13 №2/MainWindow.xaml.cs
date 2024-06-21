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

namespace Лабораторная_работа_13_Задание_2
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimationUsingPath animationLeft = new DoubleAnimationUsingPath();
            animationLeft.PathGeometry = (PathGeometry)this.Resources["PathAnimation"];
            animationLeft.Duration = TimeSpan.FromSeconds(4);
            animationLeft.Source = PathAnimationSource.X;

            DoubleAnimationUsingPath animationTop = new DoubleAnimationUsingPath();
            animationTop.PathGeometry = (PathGeometry)this.Resources["PathAnimation"];
            animationTop.Duration = TimeSpan.FromSeconds(4);
            animationTop.Source = PathAnimationSource.Y;

            foreach (Viewbox item in canvas.Children)
            {
                item.BeginAnimation(Canvas.LeftProperty, animationLeft);
                item.BeginAnimation(Canvas.TopProperty, animationTop);
            }

        }
    }
}
