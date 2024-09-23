using System.Timers;

namespace pract6;

public partial class Budilnik : ContentPage
{
	DateTime _date;
	TimeSpan tmsbud1, tmsbud2, tmsbud3, tmsbud4, tmsbud5;
	IDispatcherTimer _timer;
	
	int buttonCount = 0;
	string denbud1,denbud2,denbud3,denbud4,denbud5;
	TimeSpan _time;
	string daa;


	public Budilnik()
	{
		InitializeComponent();
		InitializePickers();
		_timer = Application.Current.Dispatcher.CreateTimer();
		_timer.Interval = TimeSpan.FromSeconds(1);
		_timer.Tick += Timer_Tick;
		
	}
		


	string[] dni = new string[] {"Monday","Tuesday","Wednesday",
		"Thursday","Friday","Saturday","Sunday"};

	private void InitializePickers()
	{

		for (int i = 0; i <= 6; i++)
		{
			d1Picker.Items.Add(dni[i].ToString());
			d2Picker.Items.Add(dni[i].ToString());
			d3Picker.Items.Add(dni[i].ToString());
			d4Picker.Items.Add(dni[i].ToString());
			d5Picker.Items.Add(dni[i].ToString());
		}


	}

	private void Timer_Tick(object sender, EventArgs e)
	{
		_date = DateTime.Now;
		_time = new TimeSpan(_date.Hour, _date.Minute, 0);
		daa = _date.DayOfWeek.ToString();

		if (sw1.IsToggled)
		{
			denbud1 = d1Picker.SelectedItem.ToString();
			tmsbud1 = tm1.Time;
			if (tmsbud1.CompareTo(_time) == 0)
			{
				if (daa == denbud1)
				{
					DisplayAlert("Сработал 1", "", "ok");
					sw1.IsToggled = false;
					
				}
			}
		}

		if (sw2.IsToggled)
		{
			denbud2 = d2Picker.SelectedItem.ToString();
			tmsbud2 = tm2.Time;
			if (tmsbud2.CompareTo(_time) == 0)
			{
				if (daa == denbud2)
				{
					DisplayAlert("Сработал 2", "", "ok");
					sw2.IsToggled = false;
					
				}
			}
		}
		if (sw3.IsToggled)
		{
			denbud3 = d3Picker.SelectedItem.ToString();
			tmsbud3 = tm3.Time;
			if (tmsbud3.CompareTo(_time) == 0)
			{
				if (daa == denbud3)
				{
					DisplayAlert("Сработал 3", "", "ok");
					sw3.IsToggled = false;
					
				}
			}

		}

		if (sw4.IsToggled)
		{
			denbud4 = d4Picker.SelectedItem.ToString();
			tmsbud4 = tm4.Time;
			if (tmsbud4.CompareTo(_time) == 0)
			{
				if (daa == denbud4)
				{
					DisplayAlert("Сработал 4", "", "ok");
					sw4.IsToggled = false;
					
				}
			}
		}

		if (sw5.IsToggled)
		{
			denbud5 = d5Picker.SelectedItem.ToString();
			tmsbud5 = tm5.Time;
			if (tmsbud5.CompareTo(_time) == 0)
			{
				if (daa == denbud5)
				{
					DisplayAlert("Сработал 5", "", "ok");
					sw5.IsToggled = false;
					
				}
			}
		}
		if (!sw1.IsToggled && !sw2.IsToggled && !sw3.IsToggled && !sw4.IsToggled && !sw5.IsToggled)
		{
			_timer.Stop();
		}
		

	}



	private void Button_Clicked(object sender, EventArgs e)
	{


		buttonCount++;
		switch (buttonCount)
		{
			case 1: sw1.IsVisible = true; bud1.IsVisible = true; break;
			case 2: sw2.IsVisible = true; bud2.IsVisible = true; break;
			case 3: sw3.IsVisible = true; bud3.IsVisible = true; break;
			case 4: sw4.IsVisible = true; bud4.IsVisible = true; break;
			case 5: sw5.IsVisible = true; bud5.IsVisible = true; break;
			default:
				DisplayAlert("Нельзя много", "", "Ладно");
				break;
		}


	}

	private void bud1_Clicked(object sender, EventArgs e)
	{
		st1.IsVisible = true;
		sw1.IsToggled = false;
	}

	private void sw1_Toggled(object sender, ToggledEventArgs e)
	{
		if (d1Picker.SelectedItem != null)
		{
			var selectedTime = tm1.Time;
			string tmbud1 = $"{selectedTime.Hours:D2}:{selectedTime.Minutes:D2}";
			st1.IsVisible = false;
			switch (d1Picker.SelectedItem)
			{
				case "Monday": bud1.Text = $"Понедельник {tmbud1}"; break;
				case "Tuesday": bud1.Text = $"Вторник {tmbud1}"; break;
				case "Wednesday": bud1.Text = $"Среда {tmbud1}"; break;
				case "Thursday": bud1.Text = $"Четверг {tmbud1}"; break;
				case "Friday": bud1.Text = $"Пятница {tmbud1}"; break;
				case "Saturday": bud1.Text = $"Суббота {tmbud1}"; break;
				case "Sunday": bud1.Text = $"Воскресенье {tmbud1}"; break;
				default:
					break;
			}
			_timer.Start();
		}
		else
		{
			sw1.IsToggled = false;
		}
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{

	}

	private void bud3_Clicked(object sender, EventArgs e)
	{
		st3.IsVisible = true;
		sw3.IsToggled = false;
	}

	private void bud2_Clicked(object sender, EventArgs e)
	{
		st2.IsVisible = true;
		sw2.IsToggled = false;
	}

	private void bud4_Clicked(object sender, EventArgs e)
	{
		st4.IsVisible = true;
		sw4.IsToggled = false;
	}

	private void bud5_Clicked(object sender, EventArgs e)
	{
		st5.IsVisible = true;
		sw5.IsToggled = false;
	}



	private void sw4_Toggled(object sender, ToggledEventArgs e)
	{
		if (d4Picker.SelectedItem != null)
		{
			var selectedTime = tm4.Time;
			string tmbud4 = $"{selectedTime.Hours:D2}:{selectedTime.Minutes:D2}";
			st4.IsVisible = false;
			switch (d4Picker.SelectedItem)
			{
				case "Monday": bud4.Text = $"Понедельник {tmbud4}"; break;
				case "Tuesday": bud4.Text = $"Вторник {tmbud4}"; break;
				case "Wednesday": bud4.Text = $"Среда {tmbud4}"; break;
				case "Thursday": bud4.Text = $"Четверг {tmbud4}"; break;
				case "Friday": bud4.Text = $"Пятница {tmbud4}"; break;
				case "Saturday": bud4.Text = $"Суббота {tmbud4}"; break;
				case "Sunday": bud4.Text = $"Воскресенье {tmbud4}"; break;
				default:
					break;
			}
			
			_timer.Start();

		}
		else
		{
			sw4.IsToggled = false;
		}

	}

	private void sw3_Toggled(object sender, ToggledEventArgs e)
	{
		if (d3Picker.SelectedItem != null)
		{
			var selectedTime = tm3.Time;
			string tmbud3 = $"{selectedTime.Hours:D2}:{selectedTime.Minutes:D2}";
			st3.IsVisible = false;
			switch (d3Picker.SelectedItem)
			{
				case "Monday": bud3.Text = $"Понедельник {tmbud3}"; break;
				case "Tuesday": bud3.Text = $"Вторник {tmbud3}"; break;
				case "Wednesday": bud3.Text = $"Среда {tmbud3}"; break;
				case "Thursday": bud3.Text = $"Четверг {tmbud3}"; break;
				case "Friday": bud3.Text = $"Пятница {tmbud3}"; break;
				case "Saturday": bud3.Text = $"Суббота {tmbud3}"; break;
				case "Sunday": bud3.Text = $"Воскресенье {tmbud3}"; break;
				default:
					break;
			}
			_timer.Start();
		}
		else
		{
			sw3.IsToggled = false;
		}

	}

	private void sw2_Toggled(object sender, ToggledEventArgs e)
	{
		if (d2Picker.SelectedItem != null)
		{
			var selectedTime = tm2.Time;
			string tmbud2 = $"{selectedTime.Hours:D2}:{selectedTime.Minutes:D2}";
			st2.IsVisible = false;
			switch (d2Picker.SelectedItem)
			{
				case "Monday": bud2.Text = $"Понедельник {tmbud2}"; break;
				case "Tuesday": bud2.Text = $"Вторник {tmbud2}"; break;
				case "Wednesday": bud2.Text = $"Среда {tmbud2}"; break;
				case "Thursday": bud2.Text = $"Четверг {tmbud2}"; break;
				case "Friday": bud2.Text = $"Пятница {tmbud2}"; break;
				case "Saturday": bud2.Text = $"Суббота {tmbud2}"; break;
				case "Sunday": bud2.Text = $"Воскресенье {tmbud2}"; break;
				default:
					break;
			}
			_timer.Start();
		}
		else
		{
			sw2.IsToggled = false;
		}


	}



	private void sw5_Toggled(object sender, ToggledEventArgs e)
	{
		if (d5Picker.SelectedItem != null)
		{
			var selectedTime = tm5.Time;
			string tmbud5 = $"{selectedTime.Hours:D2}:{selectedTime.Minutes:D2}";
			st5.IsVisible = false;
			switch (d5Picker.SelectedItem)
			{
				case "Monday": bud5.Text = $"Понедельник {tmbud5}"; break;
				case "Tuesday": bud5.Text = $"Вторник {tmbud5}"; break;
				case "Wednesday": bud5.Text = $"Среда {tmbud5}"; break;
				case "Thursday": bud5.Text = $"Четверг {tmbud5}"; break;
				case "Friday": bud5.Text = $"Пятница {tmbud5}"; break;
				case "Saturday": bud5.Text = $"Суббота {tmbud5}"; break;
				case "Sunday": bud5.Text = $"Воскресенье {tmbud5}"; break;
				default:
					break;
			}
			_timer.Start();
		}
		else
		{
			sw5.IsToggled = false;
		}


	}
}