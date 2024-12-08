using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Pages
{
    public class Note
    {
        public static ObservableCollection<Note> AllNotes { get; set; } = new();

        public string Title { get; set; }
        public string Content { get; set; }

        static Note()
        {
            AllNotes.Add(new Note() { Title = "Temp1", Content = "Its not fun to be doing this" });
            AllNotes.Add(new Note() { Title = "PHIL IS NOT PAYING HIS INSURANCE", Content = "One of us only tells lies, another only ever lies" });
            AllNotes.Add(new Note() { Title = "IMAGINE WHAT U HAVE TO PAY UP NOW SAT", Content = "Who might you be looking for" });
        }
    }
}
