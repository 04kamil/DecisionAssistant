using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DecisionAssistant.Model;
using System.Windows.Input;

namespace DecisionAssistant.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            _CanExecute = true;
        }
        private bool _CanExecute;
        private List<RelationModel> relations;
        private List<AlterntaiveModel> altenatives;
        private List<CriterionModel> criterion;

        public event PropertyChangedEventHandler PropertyChanged;
protected void OnPropertyChanged(string name)
{
    PropertyChangedEventHandler handler = PropertyChanged;
    if (handler != null)
    {
        handler(this, new PropertyChangedEventArgs(name));
    }
}


        #region Navigacja
        private Uri _frameSource;// = new Uri("/View/MenuUC.xaml", UriKind.Relative);
        public ICommand _GoToCreateModel;
        public ICommand _GoToEnterData;
        public ICommand _GoToResult;
        public ICommand _GoToMainMenu;
        public Uri FrameSource
        {
            get { return _frameSource; }
            set
            {
                _frameSource = value;
                OnPropertyChanged("FrameSource");
            }
            //OnPropertyChanged("FrameSource");
        }

        public ICommand GoToCreateModel
        {
            get
            {
                return _GoToCreateModel ?? (_GoToCreateModel = new CommandHandler(() => ExecuteGoToCommand(0), _CanExecute));
            }
        }

        public ICommand GoToEnterData
        {
            get
            {
                return _GoToEnterData ?? (_GoToEnterData = new CommandHandler(() => ExecuteGoToCommand(1), _CanExecute));
            }
        }





        public void ExecuteGoToCommand(int i)//myaction
        {
            switch(i)
            {
                case 0: FrameSource = new Uri("/View/CreateModelUC.xaml", UriKind.Relative);
                    break;
                case 1:
                    FrameSource = new Uri("/View/EnterDataUC.xaml", UriKind.Relative);
                    break;
                case 2:
                    FrameSource = new Uri("/View/ResultUC.xaml", UriKind.Relative);
                    break;
                case 3:
                    FrameSource = new Uri("/View/MenuUC.xaml", UriKind.Relative);
                    break;

            }
        }

        public class CommandHandler : ICommand
        {
            public event EventHandler CanExecuteChanged;
            private Action _action;
            private bool _canExecute;
            public CommandHandler(Action action,bool canExecute)
            {
                _action = action;
                _canExecute = canExecute;
            }

            public bool CanExecute(object parameter)
            {
                return _canExecute;
            }

            public void Execute(object parameter)
            {
                _action();
            }
        }

        #endregion







    }




}
