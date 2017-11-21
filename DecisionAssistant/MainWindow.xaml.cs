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
using MahApps.Metro.Controls;
using DecisionAssistant.ViewModel;
using DecisionAssistant.View;

namespace DecisionAssistant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = new MainWindowViewModel();
            //MenuUC mc = new MenuUC();
            Pages.NavigationService.Navigate(new Uri("/View/MenuUC.xaml", UriKind.Relative));
            //to jest wyjscie tylko nalezy jeszcze data 

        }
    }
}
