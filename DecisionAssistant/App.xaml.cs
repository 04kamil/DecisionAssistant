﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace DecisionAssistant
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            SetLanguageDictionary();
        }
        

        private void SetLanguageDictionary()
        {
            ResourceDictionary dict = new ResourceDictionary();
            switch(Thread.CurrentThread.CurrentCulture.ToString())
            {
                case "en-US":
                    dict.Source = new Uri("..\\Dictionary\\StringResources.xaml",UriKind.Relative);
                    break;
                case "pl-PL":
                    dict.Source = new Uri("..\\Dictionary\\StringResources.pl-PL.xaml",UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("..\\Dictionary\\StringResources.xaml",UriKind.Relative);
                    break;
            }
            this.Resources.MergedDictionaries.Add(dict);
        }
    }

 





}
