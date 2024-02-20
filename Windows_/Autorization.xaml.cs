using _3121Sr.Classes_;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
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
    /// Interaction logic for Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        Entities context = new Entities();
        List<Users> user = new List<Users>();
        public Autorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Users cura = context.Users.Where(x=>x.Login==TB_Log.Text && x.Password==PasB.Password).FirstOrDefault();
            if (cura != null)
            {
                Menu m = new Menu(cura);
                this.Close();
                m.Show();
            }
            else
                MessageBox.Show("Error 404");
        }
            private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sp_Discription.Visibility= Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Registration a = new Registration();
            this.Close();
            a.Show();
        }
        private void TB_Log_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TB_Log.Text == null)
            {
                TB_Log.Text = "Имя пользователя";
                TB_Log.Foreground = new SolidColorBrush(Colors.Gray);
            }
            else
            {
                TB_Log.Foreground = new SolidColorBrush(Colors.Black);
            }

        }

        private void TB_Otvet_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Enter)
            {
                Users us= new Users();
                us = context.Users.Where(x=>x.Login == TB_Log.Text && x.Question == CMB_quest.Text && x.Answer == TB_Otvet.Text).FirstOrDefault();
                if (us == null)
                    TB_Result.Text = "Empty Answer";
                else
                {
                    TB_Result.Text = us.Password;
                }
            };
                
        }
    }
}
