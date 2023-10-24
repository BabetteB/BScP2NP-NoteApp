using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_project_Note_App_np.Models;

namespace Mini_project_Note_App_np.NewFolder
{
    class NoteViewModel : INotifyPropertyChanged
    {
        public NoteViewModel()
        {
            Notes = new ObservableCollection<Note>
            {
                new Note { Id = 1, Name = "rasmus", Content = "espresso på is", Tag="To-Do" },
                new Note { Id = 2, Name = "Adrian", Content = "Espresso uden is", Tag="Uni"},
                new Note { Id = 3, Name = "Mie", Content = "Kage" },
            };

                    DisplayedNotes = new ObservableCollection<Note>();
                    foreach (Note note in Notes)
                    {
                DisplayedNotes.Add(note);
                    }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void SetTag(string Tag)
            {
                DisplayedNotes.Clear();
                foreach (Note note in Notes)
                {
                    if (note.Tag is null && !Tag.Equals("All"))
                    {
                    continue;
                    } else if (Tag.Equals("All") || note.Tag.Equals(Tag))
                    {
                        DisplayedNotes.Add(note);
                    }
                }
            }

        public ObservableCollection<Note> Notes { get; private set; }

        public ObservableCollection<Note> DisplayedNotes;


    }
}
