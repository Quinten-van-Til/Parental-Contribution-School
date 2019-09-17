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

namespace Ouderbijdrage_school
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Public Variables
        public int Input_Aantal;
        #endregion
        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            Container.Visibility = Visibility.Hidden;
        }
        #endregion
        #region Amount of children
        private void Aantal_TextChanged(object sender, TextChangedEventArgs e)
        {
            #region Input_Aantal != ""
            if (Aantal.Text != "")
            {
                Input_Aantal = int.Parse(Aantal.Text);
                Container.Visibility = Visibility.Visible;
            }
            else
            {
                Container.Visibility = Visibility.Hidden;
            }
            #endregion
            #region Input_Aantal Number
            if (Input_Aantal == 1)
            {
                Row2.Height = new GridLength(0);
                Row3.Height = new GridLength(0);
                Row4.Height = new GridLength(0);
                Row5.Height = new GridLength(0);
                Row6.Height = new GridLength(0);
                Row7.Height = new GridLength(0);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 2)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(0);
                Row4.Height = new GridLength(0);
                Row5.Height = new GridLength(0);
                Row6.Height = new GridLength(0);
                Row7.Height = new GridLength(0);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 3)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(0);
                Row5.Height = new GridLength(0);
                Row6.Height = new GridLength(0);
                Row7.Height = new GridLength(0);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 4)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(0);
                Row6.Height = new GridLength(0);
                Row7.Height = new GridLength(0);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 5)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(63);
                Row6.Height = new GridLength(0);
                Row7.Height = new GridLength(0);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 6)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(63);
                Row6.Height = new GridLength(63);
                Row7.Height = new GridLength(0);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 7)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(63);
                Row6.Height = new GridLength(63);
                Row7.Height = new GridLength(63);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 8)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(63);
                Row6.Height = new GridLength(63);
                Row7.Height = new GridLength(63);
                Row8.Height = new GridLength(63);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 9)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(63);
                Row6.Height = new GridLength(63);
                Row7.Height = new GridLength(63);
                Row8.Height = new GridLength(63);
                Row9.Height = new GridLength(63);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 10)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(63);
                Row6.Height = new GridLength(63);
                Row7.Height = new GridLength(63);
                Row8.Height = new GridLength(63);
                Row9.Height = new GridLength(63);
                Row10.Height = new GridLength(63);
            }
            #endregion
        }
        #endregion
        #region Populate Class1.ListBirth with year of birth
        private void BirthYears()
        {
            Class1.ListBirth.Clear();
            if (Input_Aantal > 0)
            {
                Class1.ListBirth.Add(((DateTime)Birth_1.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 1)
            {
                Class1.ListBirth.Add(((DateTime)Birth_2.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 2)
            {
                Class1.ListBirth.Add(((DateTime)Birth_3.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 3)
            {
                Class1.ListBirth.Add(((DateTime)Birth_4.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 4)
            {
                Class1.ListBirth.Add(((DateTime)Birth_5.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 5)
            {
                Class1.ListBirth.Add(((DateTime)Birth_6.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 6)
            {
                Class1.ListBirth.Add(((DateTime)Birth_7.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 7)
            {
                Class1.ListBirth.Add(((DateTime)Birth_8.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 8)
            {
                Class1.ListBirth.Add(((DateTime)Birth_9.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 9)
            {
                Class1.ListBirth.Add(((DateTime)Birth_10.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
        }
        #endregion
        #region Button Bereken
        private void Bereken_Click(object sender, RoutedEventArgs e)
        {
            #region Local Variables
            int i = 0;
            int Child = 0;
            int Kid = 0;
            Double Cost = 50;
            BirthYears();
            #endregion
            #region Calculate Age and the associated Cost (with Class1.ListBirth). Also checks for max amount of children.
            do
            {
                var age = DateTime.Today.Year - Class1.ListBirth[i].Year;
                age = (Class1.ListBirth[i] > DateTime.Today.AddYears(-age)) ? age-- : age;

                if (age < 10 && Child < 3)
                {
                    Cost += 25;
                    Child++;
                }
                else if (age > 9 && Kid < 2)
                {
                    Cost += 37;
                    Kid++;
                }
                i++;
            }
            while (i < Input_Aantal);
            #endregion
            #region Checks if Cost exceeds the max. of €150,- and for single parent families.
            Cost = (Cost > 150) ? 150 : Cost;
            Cost = (Parent.IsChecked == true) ? (Cost * 0.75) : Cost; 
            #endregion
            #region Display Cost
            Kosten_txt.Content = "De totale ouderbijdrage is:";
            Kosten_int.Content = Cost.ToString("C2");
            #endregion
        }
        #endregion

    }
}
