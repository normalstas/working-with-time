
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace pract6;

public partial class Taimer : ContentPage
{
	TimeSpan _time;
	IDispatcherTimer _timer;
	bool sekondtm;
	bool flag;
	int hours;
	int minutes;
	int seconds;
	public Taimer()
	{
		InitializeComponent();
		InitializePickers();
		_timer = Application.Current.Dispatcher.CreateTimer();
		_timer.Interval = TimeSpan.FromSeconds(1);
		_timer.Tick += Timer_Tick;

	}

	private void InitializePickers()
	{

		for (int i = 0; i < 24; i++)
		{
			HourPicker.Items.Add(i.ToString());
		}

		for (int i = 0; i < 60; i++)
		{
			MinutePicker.Items.Add(i.ToString());
			SecondPicker.Items.Add(i.ToString());
		}
	}

	async private void Timer_Tick(object sender, EventArgs e)
	{
		sekondtm = true;
		st.IsVisible = false;
		_time = _time.Add(new TimeSpan(0, 0, -1));
		if (_time.TotalSeconds > 0)
		{
			otm.IsVisible = true;
			otm.IsEnabled = true;
			st.IsVisible = false;
			st.IsEnabled = false;
			HourPicker.IsVisible = false;
			MinutePicker.IsVisible = false;
			SecondPicker.IsVisible = false;
			lb.IsVisible = true;
			pick1.IsVisible = false;
			pick2.IsVisible = false;
			pick3.IsVisible = false;
			lb.Text = _time.ToString();

		}
		if (_time.TotalSeconds == 0)
		{
			prov();


		}

	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		
		st.IsVisible = true;
		st.IsEnabled = true;
		hours = int.Parse(HourPicker.SelectedItem.ToString());
		minutes = int.Parse(MinutePicker.SelectedItem.ToString());
		seconds = int.Parse(SecondPicker.SelectedItem.ToString());
		flag = true;

		_time = new TimeSpan(hours, minutes, seconds);
		_timer.Start();
	}


	async private void prov()
	{
		flag = await DisplayAlert("Запустить его заново?", "", "да", "нет");
		if (flag)
		{
			Button_Clicked(this, null);
			
		}
		else
		{
			st.IsEnabled = true;
			st.IsVisible = true;
			otm.IsVisible = false;
			otm.IsEnabled = false;
			HourPicker.IsVisible = true;
			MinutePicker.IsVisible = true;
			SecondPicker.IsVisible = true;
			pick1.IsVisible = true;
			pick2.IsVisible = true;
			pick3.IsVisible = true;
			lb.IsVisible = false;
			hours = 0;
			minutes = 0;
			seconds = 0;
			_timer.Stop();
		}
	}

	private void Otm(object sender, EventArgs e)
	{
		sekondtm = false;
		flag = false;
		prov();
	}

	
}