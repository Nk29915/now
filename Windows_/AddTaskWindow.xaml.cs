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
    /// Interaction logic for AddTaskWindow.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        Users us;
        Entities context = new Entities();
        public AddTaskWindow(Users asmr)
        {
            InitializeComponent();
            us= asmr;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            TextRange TR = new TextRange(RichTB.Document.ContentStart, RichTB.Document.ContentEnd);
            Tasks tsk = new Tasks {Taks=NameTaskTB.Text,Discription=TR.Text,Date= DP.SelectedDate,Status = false, User= us.Login};
            context.Tasks.Add(tsk);
            context.SaveChanges();
            this.Close();
        }
    }
}
