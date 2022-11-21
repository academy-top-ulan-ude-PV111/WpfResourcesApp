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

namespace WpfResourcesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SolidColorBrush brushAqua = new SolidColorBrush(Colors.Aqua);
            this.Resources.Add("brushAqua", brushAqua);

            //SolidColorBrush brush = (SolidColorBrush)this.FindResource("sBrush");
            //brush.Color = Colors.White;
        }

        public void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Content.ToString());
        }
    }

    
}
