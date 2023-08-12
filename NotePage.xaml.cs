namespace notes;

/*public partial class NotePage : ContentPage
{
	public NotePage()
	{
		InitializeComponent();
	}

	public void SaveButton_Clicked(object sender, EventArgs e)
	{
		Console.WriteLine(sender.ToString(), e);
	}

    public void DeleteButton_Clicked(object sender, EventArgs e)
	{
        Console.WriteLine(sender.ToString(), e);
    }*/

public partial class NotePage : ContentPage
{
	string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

	public NotePage()
	{
		InitializeComponent();

		if (File.Exists(_fileName))
		{
			TextEditor.Text = File.ReadAllText(_fileName);
		}
	}
	
	private void SaveButton_Clicked(Object sender, EventArgs e) 
	{
		//Save the file.
		File.WriteAllText(_fileName, TextEditor.Text);
	}

	public void DeleteButton_Clicked(Object sender, EventArgs e)
	{
		if (File.Exists(_fileName))
		{
			File.Delete(_fileName);
		}
        TextEditor.Text = string.Empty;
    }
}