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

namespace Targil4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

   

        private void Book1MouseEnter(object sender, MouseEventArgs e)
        {
            //Storyboard sb = new Storyboard();
            //DoubleAnimation xAnimation = new DoubleAnimation(1, 0, new Duration(TimeSpan.FromSeconds(2)), FillBehavior.HoldEnd);
            //Storyboard.SetTarget(xAnimation, Book1);
            //Storyboard.SetTargetProperty(xAnimation, new PropertyPath("RenderTransform.ScaleX"));

            //DoubleAnimation yAnimation = new DoubleAnimation(1, 0, new Duration(TimeSpan.FromSeconds(2)), FillBehavior.HoldEnd);
            //Storyboard.SetTarget(yAnimation, Book1);
            //Storyboard.SetTargetProperty(yAnimation, new PropertyPath("RenderTransform.ScaleY"));

            //sb.Children.Add(xAnimation);
            //sb.Children.Add(yAnimation);
            //sb.Begin();
            
        }


        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                base.OnMouseLeftButtonDown(e);
                DragMove();
            }
            catch (Exception)
            {


            }
        }


        private void Book1_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            OpendBook ob = new OpendBook(BookTitle1.ContentStringFormat);
            ob.Show();
            this.Close();
        }

        private void Book2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpendBook ob = new OpendBook(BookTitle2.ContentStringFormat);
            ob.Show();
            this.Close();
        }

        private void Book3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpendBook ob = new OpendBook(BookTitle2.ContentStringFormat);
            ob.Show();
            this.Close();
        }


    }
}
