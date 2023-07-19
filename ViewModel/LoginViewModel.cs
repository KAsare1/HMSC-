using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HMS.Core;

namespace HMS.ViewModel
{
	public class LoginViewModel :ObservableObjects
	{
		public string username;
		public string password;
		private string errorMessage;
		public bool IsViewVisible = true;
		public ICommand LoginCommand { get; }
		public ICommand RecoverPasswordCommand { get; }
		public ICommand ShowPasswordCommand { get; }
		public ICommand RememberPasswordCommand { get; }

		public string GetUsername()
		{
			return username;
		}

		public void SetUsername(string value)
		{
			username = value;
			OnPropertyChanged(nameof(username));
		}

		public string GetPassword()
		{
			return password;
		}

		public void SetPassword(string value)
		{
			password = value;
			OnPropertyChanged(nameof(password));
		}

		public string GetErrorMessage()
		{
			return errorMessage;
		}

		public void SetErrorMessage(string value)
		{
			errorMessage = value;
			OnPropertyChanged(nameof(errorMessage));
		}

		public bool GetIsViewVisible()
		{
			return IsViewVisible;
		}

		public void SetIsViewVisible(bool value)
		{
			IsViewVisible = value;
			OnPropertyChanged(nameof(IsViewVisible));
		}

		public LoginViewModel()
		{
			LoginCommand = new RelayCommand(ExecteLoginCommand, CanExecteLoginCommand);
			RecoverPasswordCommand = new RelayCommand(p => ExecuteRecoverPasswordCommand("", ""));
		}

		private void ExecuteRecoverPasswordCommand(string useraname, string email)
		{
			throw new NotImplementedException();
		}

		private void ExecteLoginCommand(object obj)
		{
			throw new NotImplementedException();
		}

		private bool CanExecteLoginCommand(object arg)
		{
			bool validData;
			if (string.IsNullOrWhiteSpace(username) || username.Length < 3 || password == null || password.Length < 3)
				validData = false;
			else
				validData = true;
			return validData;
		}
	}
}
