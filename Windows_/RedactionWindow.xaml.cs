using _3121Sr.Classes_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace _3121Sr.Windows_
{
    /// <summary>
    /// Interaction logic for RedactionWindow.xaml
    /// </summary>
    public partial class RedactionWindow : Window
    {
        Entities contextEntities= new Entities();
        Tasks corTask;
        public RedactionWindow(Tasks takos,Entities context)
        {
            InitializeComponent();
            corTask = takos;
            DataContext= corTask;
            contextEntities = context;
            
        }

        private void Added_Click(object sender, RoutedEventArgs e)
        {
            contextEntities.SaveChanges();
            MessageBox.Show("Yra!");
        }
    }
}
