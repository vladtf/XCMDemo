﻿using Acr.UserDialogs;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XCMDEMO.ViewModels
{
    public class HomeViewModel : Conductor<SandBoxViewModel>.Collection.OneActive
    {
        private string _mainText;
        private string _text;
        public SandBoxViewModel SandBox;
        public HomeViewModel()
        {
            MainText = "Hello World!";
            TestText = "Not Hello1!";

            SandBox = new SandBoxViewModel();
        }

        public string MainText
        {
            get { return _mainText; }
            set
            {
                SetField(ref _mainText, value);
            }
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (!object.Equals(field, value))
            {
                field = value;
                NotifyOfPropertyChange(propertyName);
                return true;
            }
            return false;
        }


        public string TestText
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }


        public void Work()
        {
            //var result = await App.Current.MainPage.DisplayAlert("Button Clicked", "Press Ok", "Ok", "Cancel");
            
            ActivateItem(SandBox);
            //Console.WriteLine(ActiveItem);
        }

    }
}
