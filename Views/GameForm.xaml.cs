using ScrambledWord_v2.Commons;
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

namespace ScrambledWord_v2.Views
{
    /// <summary>
    /// Interaction logic for GameForm.xaml
    /// </summary>
    public partial class GameForm : Window
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            TxtBlkDisplayWords.Text = Functionalities.print();
        }
    }
}
