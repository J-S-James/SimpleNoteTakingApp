using SimpleNoteTakingApp.Models;
using SimpleNoteTakingApp.Services;
using SimpleNoteTakingApp.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleNoteTakingApp.ViewModels
{
    public class NoteBookViewModel : ObservableObject
    {
        private INoteDataService _service;
        public ObservableCollection<Note> Notes { get; private set; }

        public ICommand SaveCommand { get; }
        public ICommand AddCommand { get; }
        public RelayCommand<Note> DeleteCommand { get; }


        public NoteBookViewModel(INoteDataService service)
        {
            _service = service;
            Notes = new ObservableCollection<Note>(service.Load("notes.bin"));

            SaveCommand = new RelayCommand(SaveNotes);
            AddCommand = new RelayCommand(AddNote);
            DeleteCommand = new RelayCommand<Note>((note) => DeleteNote(note));
        }

        private void AddNote()
        {
            Notes.Add(new Note());
        }

        private void SaveNotes()
        {
            _service.Save("notes.bin", Notes);
        }

        private void DeleteNote(Note note)
        {
            Notes.Remove(note);
        }

    }
}
