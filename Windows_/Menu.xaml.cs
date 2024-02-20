using _3121Sr.Classes_;
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

namespace _3121Sr.Windows_
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        Classes_.Entities context = new Classes_.Entities();
        List<Tasks> dglist= new List<Tasks>();
        Users cura;
        public Menu(Users us)
        {
            InitializeComponent();
            cura = us;
            DP.SelectedDate = DateTime.Today;
            dglist = context.Tasks.Where(x => x.User == cura.Login).ToList();
            DG.ItemsSource= dglist;
            Tb_name.Text = us.Login;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
            dglist = context.Tasks.Where(x => x.User == cura.Login && x.Date == dt).ToList();
            DG.ItemsSource = dglist;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = null;
            dglist = context.Tasks.Where(x => x.User == cura.Login).ToList();
            DG.ItemsSource = dglist;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddTaskWindow adw = new AddTaskWindow(cura);
            adw.Owner= this;
            adw.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
            if (DG.SelectedItem == null) MessageBox.Show("Not Correct Dannie");
            else
            {
                Tasks RedTasks = DG.SelectedItem as Tasks;
            RedactionWindow RW = new RedactionWindow(RedTasks,context);
            RW.Owner= this;
            RW.ShowDialog();
            }
        }
    }
}
