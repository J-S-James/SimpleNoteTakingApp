using SimpleNoteTakingApp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNoteTakingApp.Models
{
    public class Note : ObservableObject
    {
        private string _text = String.Empty;

        public string Text
        {
            get { return _text; }
            set { OnPropertyChanged(ref _text, value); }
        }
    }
}
