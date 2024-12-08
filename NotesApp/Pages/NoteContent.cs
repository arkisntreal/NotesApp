namespace NotesApp.Pages;

public class NoteContent : ContentPage
{
	public NoteContent(Note note)
	{
		Content = new VerticalStackLayout
		{
			BackgroundColor = Color.FromArgb("1c1c1c"),
			Children = {
				new Label {
					Text = note.Title,
					TextColor = Colors.AntiqueWhite,
					FontSize = 24,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Margin = 20
				},
				new Label {
					Text = note.Content,
                    TextColor = Colors.AntiqueWhite,
                    FontSize = 16,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Margin = 20
				}
			}
		};
	}
}