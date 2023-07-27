using SimpleNoteTakingApp.Services;
using SimpleNoteTakingApp.Utility;
using SimpleNoteTakingApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNoteTakingApp
{
    public class AppViewModel : ObservableObject
    {
        private NoteBookViewModel _bookViewModel;

        public NoteBookViewModel BookViewModel
        {
            get { return _bookViewModel; }
            set
            { OnPropertyChanged(ref _bookViewModel, value); }
        }

        public AppViewModel()
        {
            var dataService = new SerializationDataService();

            BookViewModel = new NoteBookViewModel(dataService);
        }
    }
}
