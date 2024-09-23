namespace pract6
{
	public partial class MainPage : ContentPage
	{
		
		IDispatcherTimer _timer;
		

		public MainPage()
		{
			InitializeComponent();
			
			_timer = Application.Current.Dispatcher.CreateTimer();
			_timer.Interval = TimeSpan.FromSeconds(1);
			_timer.Tick += Timer_Tick;
			_timer.Start();
		}
			DateTime today;
			DateTime totime;

		
		private void Timer_Tick(object sender, EventArgs e)
		{
			today = DateTime.Now;
			totime = DateTime.Now;
			date.Text = today.ToString("dd MMM yyyy");
			time.Text = totime.ToString("HH: mm: ss");
			
		}

	}

}
