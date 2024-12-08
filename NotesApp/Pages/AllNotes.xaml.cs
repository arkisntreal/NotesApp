using System.Collections.ObjectModel;

namespace NotesApp.Pages;

public partial class AllNotes : ContentPage
{
	public AllNotes()
	{
		InitializeComponent();
	}

    private void DeleteNote_Clicked(object sender, EventArgs e)
    {
		var selected = NoteListView.SelectedItem;

		for (int i = 0; i < Note.AllNotes.Count(); i++)
		{
			if (Note.AllNotes[i] == selected)
			{
                Note.AllNotes.RemoveAt(i);
			}
		}
	}

    private async void GoToNote_Clicked(object sender, EventArgs e)
    {
		for (int i = 0; i < Note.AllNotes.Count(); i++)
		{
			if (Note.AllNotes[i] == NoteListView.SelectedItem)
			{
				var note = new NoteContent(Note.AllNotes[i]);
				await Navigation.PushAsync(note);
            }
		}
    }

    private async void AddNote_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("//addnote");
    }
}