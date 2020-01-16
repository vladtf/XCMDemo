﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XCMDEMO.ViewModels
{
    public class ChatViewModel : Screen, IChildViewModel
    {
        public string Title { get; set; } = "Chat";
        private BindableCollection<string> _messages;
        private string _curMessage;
        public ChatViewModel()
        {
            Messages = new BindableCollection<string>
            {
                "Hello World", "New message", "Type something",
                "This is a looooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooong text"
            };

            CurrentMessage = "";
        }



        public string CurrentMessage
        {
            get { return _curMessage; }
            set { Set(ref _curMessage, value); }
        }

        public BindableCollection<string> Messages
        {
            get { return _messages; }
            set { Set(ref _messages, value); }
        }

        public void SendMessage()
        {
            Messages.Add(CurrentMessage);
            CurrentMessage = "";
        }

    }
}
