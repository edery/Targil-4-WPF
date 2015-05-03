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
using System.Windows.Shapes;

namespace Targil4
{
    /// <summary>
    /// Interaction logic for OpendBook.xaml
    /// </summary>
    public partial class OpendBook : Window
    {
        private String currentBook;


        public OpendBook(String p)
        {
            this.currentBook = p;
            InitializeComponent();
            theBook.AnimateToNextPage(true, 7);
            
        }

    }
}
