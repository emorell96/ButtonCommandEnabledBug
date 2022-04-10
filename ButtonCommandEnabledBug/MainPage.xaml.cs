namespace ButtonCommandEnabledBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public Command Command { get; set; }
	public MainPage()
	{
		BindingContext = this;
		Command = new Command(() => OnCounterClicked());
		InitializeComponent();
		
	}

	private void OnCounterClicked()
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}
}

