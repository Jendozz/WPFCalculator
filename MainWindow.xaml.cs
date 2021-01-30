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
using WPFCalc.Controls;

namespace WPFCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalcControl control = new CalcControl();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            control.TableList.ListChanged += TableList_ListChanged;

        }

        private void TableList_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            Table.Text = control.ShowList();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            control.AddToList(One.Content.ToString());
            e.Handled = true;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            control.AddToList(Two.Content.ToString());
            e.Handled = true;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            control.AddToList(Three.Content.ToString());
            e.Handled = true;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            control.AddToList(Four.Content.ToString());
            e.Handled = true;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            control.AddToList(Five.Content.ToString());
            e.Handled = true;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            control.AddToList(Six.Content.ToString());
            e.Handled = true;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            control.AddToList(Seven.Content.ToString());
            e.Handled = true;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            control.AddToList(Eight.Content.ToString());
            e.Handled = true;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            control.AddToList(Nine.Content.ToString());
            e.Handled = true;
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            control.AddToList(Zero.Content.ToString());
            e.Handled = true;
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {   if (control.TableList.Count == 0)
            {
                Table.Text = "Error";
            }
            else
            {
                control.AddToList(dot.Content.ToString());
                e.Handled = true;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            control.TableList.Clear();
            control.CalcList.Clear();
            e.Handled = true;
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            control.CalcAction(Plus.Content.ToString());
            e.Handled = true;
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            control.CalcAction(Minus.Content.ToString());
            e.Handled = true;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            control.CalcAction(Multiply.Content.ToString());
            e.Handled = true;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            control.CalcAction(Divide.Content.ToString());
            e.Handled = true;
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            Table.Text = control.Calculate();
            e.Handled = true;
        }

        private void PlusMinus_Click(object sender, RoutedEventArgs e)
        {
            Table.Text = control.ChangeSign();
            e.Handled = true;
        }

        private void DelChar_Click(object sender, RoutedEventArgs e)
        {
            control.DelChar();
            e.Handled = true;
        }

        private void Radical_Click(object sender, RoutedEventArgs e)
        {
            control.GetRadical();
            e.Handled = true;
        }

        private void OneDivideByX_Click(object sender, RoutedEventArgs e)
        {
            Table.Text = control.OneDivideByX();
            e.Handled = true;
        }
    }
}
