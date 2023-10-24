using Mini_project_Note_App_np.NewFolder;

namespace Mini_project_Note_App_np;

public partial class MainPage : ContentPage
{
	int count = 0;
	private readonly NoteViewModel Notes;

    private bool isAllSelected;
    private bool isToDoSelected;
    private bool isUniSelected;

    public MainPage()
	{
		InitializeComponent();
		this.BindingContext = this;
        Notes = new NoteViewModel();
		NotesView.ItemsSource = Notes.DisplayedNotes;
	}

	private void UniSelected(object sender, EventArgs e)
	{
		Notes.SetTag("Uni");

			
		SemanticScreenReader.Announce(AllBtn.Text);
	}
    private void ToDoSelected(object sender, EventArgs e)
    {
        Notes.SetTag("To-Do");


        SemanticScreenReader.Announce(AllBtn.Text);
    }

    private void AllSelected(object sender, EventArgs e)
    {
        Notes.SetTag("All");


        SemanticScreenReader.Announce(AllBtn.Text);
    }
}

