using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using DecisionAssistant.View;

namespace DecisionAssistant.ViewModel
{
     public class NavigationViewModel : INotifyPropertyChanged
    {
        public ICommand EmpCommand { get; set; }
        public ICommand DeptCommand { get; set; }
        private object seletedViewModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public object SelectedViewModel
        {
            get { return seletedViewModel; }
            set { seletedViewModel = value;
                OnPropertyChanged("seletedViewModel");
                 }
        }
        public NavigationViewModel()
        {
            //EmpCommand = new 
            //DeptCommand = new BaseCommand(OpenDept);
        }

        private void OpenEmp(object obj)

        {
            SelectedViewModel = new MenuUC();
        }
        private void OpenDept(object obj)

        {

            SelectedViewModel = new CreateModelUC();

        }

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }



    }
}
