namespace NotesApp.Pages;

public partial class AddNote : ContentPage
{
	public AddNote()
	{
		InitializeComponent();

        NoteTitleEntry.Text = "";
	}

    private void Back_Clicked(object sender, EventArgs e)
    {
        NoteTitleEntry.Text = "";
        NoteContentEntry.Text = "";
		GoToAllNotes();
    }

    private void Submit_Clicked(object sender, EventArgs e)
	{
		string title = NoteTitleEntry.Text;
		string content = NoteContentEntry.Text;

		Console.WriteLine("HELP ME GOD " + title);

		if (title == "")
		{
            ErrorLabel.Text = "An Error occured! Title is required";
        }
		else
		{
            Console.WriteLine("WE ARE DXONE ARENT YOU HAPPY");
            Note.AllNotes.Add(new Note() { Title = title, Content = content });
            ErrorLabel.Text = "";
            NoteTitleEntry.Text = "";
            NoteContentEntry.Text = "";
            GoToAllNotes();
        }
	}

	private async void GoToAllNotes()
	{
        await Shell.Current.GoToAsync("//allnotes");
    }
}