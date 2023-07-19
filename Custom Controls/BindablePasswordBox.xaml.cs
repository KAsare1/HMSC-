using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HMS.Custom_Controls
{
	/// <summary>
	/// Interaction logic for BindablePasswordBox.xaml
	/// </summary>
	public partial class BindablePasswordBox : UserControl
	{
		public static readonly DependencyProperty PasswordProperty = DependencyProperty.Register("Password", typeof(string), typeof(BindablePasswordBox)) ;

		public string Password {
			get { return (string)GetValue(PasswordProperty); }
			set { SetValue(PasswordProperty, value); }
		}

		public BindablePasswordBox()
		{
			InitializeComponent();
			txtPassword.PasswordChanged += OnPasswordChanged;
		}

		public void OnPasswordChanged(object sender, RoutedEventArgs e)
		{
			Debug.WriteLine(txtPassword.Password);
		}
	}
}