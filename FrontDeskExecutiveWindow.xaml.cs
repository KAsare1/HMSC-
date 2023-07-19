using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HMS.Pages;

namespace HMS
{
	/// <summary>
	/// Interaction logic for FrontDeskExecutiveWindow.xaml
	/// </summary>
	public partial class FrontDeskExecutiveWindow : Window
	{
		public FrontDeskExecutiveWindow()
		{
			InitializeComponent();
		}

		private void homebtnchecked(object sender, RoutedEventArgs e)
		{
			Main.Content = new Home();
		}

		private void AppointmentsChecked(object sender, RoutedEventArgs e)
		{
			Main.Content = new Appointments();
		}

		private void RegistrationChecked(object sender, RoutedEventArgs e)
		{
			Main.Content = new Registration();
		}

		private void CheckInChecked(object sender, RoutedEventArgs e)
		{
			Main.Content = new CheckIn();
		}
	}
}
