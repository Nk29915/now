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
using static System.Net.Mime.MediaTypeNames;

namespace _3121Sr.Windows_
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        Entities context = new Entities();
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Users us= new Users();
            try
            {    
                us.Login = TB_Login.Text;
                us.Question = CMB_Quest.Text;
                us.Answer = TB_Otvet.Text;
                if (TB_Password.Text == TB_Conf_Pas.Text && TB_Password.Text != null && TB_Conf_Pas.Text != null)
                    us.Password = TB_Password.Text;
                else
                {
                    MessageBox.Show("Error");
                    return;
                }         
                context.Users.Add(us);
                context.SaveChanges();

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Autorization aut = new Autorization();
            this.Close();
            aut.Show();
        }
    }
}
