using SimpleNoteTakingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNoteTakingApp.Services
{
    public class MockDataService : INoteDataService
    {
        private IEnumerable<Note> _notes;

        public MockDataService() 
        {
            _notes = new List<Note>()
            {
                new Note()
                {
                    Text = "Test"
                },
                new Note()
                {
                    Text = "Test2"
                },
                new Note()
                {
                    Text = "Test3"
                },
                new Note()
                {
                    Text = "Test4"
                }
            };
        }

        public IEnumerable<Note> Load(string fileName)
        {
            return _notes;
        }

        public void Save(string fileName, IEnumerable<Note> notes)
        {
            throw new NotImplementedException();
        }
    }
}
