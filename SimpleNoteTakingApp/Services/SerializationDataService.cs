using SimpleNoteTakingApp.Models;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;

namespace SimpleNoteTakingApp.Services
{
    public class SerializationDataService : INoteDataService
    {
        public IEnumerable<Note> Load(string fileName)
        {
            if (!File.Exists(fileName)) return Enumerable.Empty<Note>();
            using (var stream = File.Open(fileName, FileMode.Open))
            {
                using (var reader = new BinaryReader(stream, Encoding.UTF8, false)) 
                { 
                    var notes = new List<Note>();
                    var count = reader.ReadInt32();
                    for (int i = 0; i < count; i++)
                    {
                        var text = reader.ReadString();
                        notes.Add(new Note { Text = text });
                    }
                    return notes;
                }
            }
        }

        public void Save(string fileName, IEnumerable<Note> notes)
        {
            using (var stream = File.Open(fileName, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    writer.Write(notes.Count());
                    foreach (var note in notes)
                    {
                        writer.Write(note.Text);
                    }
                }
            }
        }
    }
}
