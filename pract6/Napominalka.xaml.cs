namespace pract6;

public partial class Napominalka : ContentPage
{
	TimeSpan _time;
	DateTime _date;
	IDispatcherTimer _timer;
	string _message;
	
	public Napominalka()
	{
		InitializeComponent();
		
		_timer = Application.Current.Dispatcher.CreateTimer();
		_timer.Interval = TimeSpan.FromSeconds(1);
		_timer.Tick += Timer_Tick;
	}

	

	private void Timer_Tick(object sender, EventArgs e)
	{
		if (_date <= DateTime.Now)
		{
			DisplayAlert("Напоминание", _message, "Ok");
			_timer.Stop();
			st1.IsVisible = true;
			entsoo.Text = string.Empty;
		}
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		
		_date = dbDate.Date + dbTime.Time;
		_message = entsoo.Text + "\n" + _date.ToString("dd MMM yyyy HH mm");
		DisplayAlert("Успешно", "Ожидайте", "Ok");
		_timer.Start();
		st1.IsVisible = false;


	}
}