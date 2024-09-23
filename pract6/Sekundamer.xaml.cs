namespace pract6;

public partial class Sekundamer : ContentPage
{
	public Sekundamer()
	{
		InitializeComponent();
		st.Text = ">";
	}
	bool sekondtm;
	int second;

	private void Plus(object sender, EventArgs e)
	{
		
			TimeSpan time = TimeSpan.FromSeconds(second);
			zapis.Text = time.ToString(@"hh\:mm\:ss");
			pl.IsVisible = false;
			pl.IsEnabled = false;
			del.IsEnabled = true;
			del.IsVisible = true;

	}

	private void Delete(object sender, EventArgs e)
	{
		
			pl.IsVisible = true;
			pl.IsEnabled = true;
			del.IsEnabled = false;
			del.IsVisible = false;
			zapis.Text = string.Empty;
		
	}

	private async void Start(object sender, EventArgs e)
	{
		sekondtm = true;
		st.IsEnabled = false;
		st.IsVisible = false;
		if (string.IsNullOrEmpty(zapis.Text))
		{
			pl.IsEnabled = true;
			pl.IsVisible = true;

		}
        else
        {
			del.IsEnabled = true;
			del.IsVisible = true;
		}

        stopp.IsVisible = true;
		stopp.IsEnabled = true;
		otm.IsEnabled = true;
		otm.IsVisible = true;
		pl.IsVisible = true;
		pl.IsEnabled = true;
		
		while (sekondtm)
		{
			second += 1;
			TimeSpan time = TimeSpan.FromSeconds(second);
			sekunds.Text = time.ToString(@"hh\:mm\:ss");
			await Task.Delay(1000);
		}

	}

	private void Stop(object sender, EventArgs e)
	{
		sekondtm = false;
		stopp.IsVisible = false;
		stopp.IsEnabled = false;
		st.IsVisible= true;
		st.IsEnabled= true;
	}

	private void Otm(object sender, EventArgs e)
	{
		sekondtm = false;
		second = 0;
		zapis.Text = string.Empty;
		otm.IsEnabled = false;
		otm.IsVisible = false;
		pl.IsEnabled = false;
		pl.IsVisible = false;
		st.IsVisible= true;
		st.IsEnabled= true;
		sekunds.Text = "00:00:00";
		stopp.IsVisible = false;
		stopp.IsEnabled= false;
	}
}