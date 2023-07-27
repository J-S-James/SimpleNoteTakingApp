using SimpleNoteTakingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNoteTakingApp.Services
{
    public interface INoteDataService
    {
        IEnumerable<Note> Load(string fileName);
        void Save(string fileName, IEnumerable<Note> notes);
    }
}
