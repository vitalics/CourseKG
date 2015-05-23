#region Usings
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
#endregion

namespace _CourseKG_WPF_
{
	/// <summary>
	/// Логика взаимодействия для Shooter.xaml
	/// </summary>
	public partial class Shooter : Window
	{
		public Shooter()
		{
			InitializeComponent();
		}
		#region Events
		/// <summary>
		/// This event open Main Window.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
		private void MainWindow_click(object sender, RoutedEventArgs e)
		{
			this.Close();
			MainWindow mw = new MainWindow();
			mw.Show();
		}

		/// <summary>
		/// Handles the click event open "Shadow" window.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
		private void Shadow_click(object sender, RoutedEventArgs e)
		{
			this.Close();
			Shadow shadow = new Shadow();
			shadow.Show();
		}

		/// <summary>
		/// This event close the application.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
		private void Exit_click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}
		/// <summary>
		/// This event event open message box.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
		private void Calculate_click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("LOL!!!!!!!!!!!");
		}
		private void Error_TextChanged1(object sender, TextChangedEventArgs e)
		{
			string text = (sender as TextBox).Text;
			int a;
			bool flag = true;
			try
			{
				a = int.Parse(text);
			}
			catch
			{
				this.Error1.Content = "Incorrect number";
				flag = false;
			}

			if (flag)
			{
				this.Error1.Content = string.Empty;
			}
		}
		private void Error_TextChanged2(object sender, TextChangedEventArgs e)
		{
			string text = (sender as TextBox).Text;
			int a;
			bool flag = true;
			try
			{
				a = int.Parse(text);
			}
			catch
			{
				this.Error2.Content = "Incorrect number";
				flag = false;
			}

			if (flag)
			{
				this.Error2.Content = string.Empty;
			}
		}
		private void Error_TextChanged3(object sender, TextChangedEventArgs e)
		{
			string text = (sender as TextBox).Text;
			int a;
			bool flag = true;
			try
			{
				a = int.Parse(text);
			}
			catch
			{
				this.Error3.Content = "Incorrect number";
				flag = false;
			}

			if (flag)
			{
				this.Error3.Content = string.Empty;
			}
		}
		private void Error_TextChanged4(object sender, TextChangedEventArgs e)
		{
			string text = (sender as TextBox).Text;
			int a;
			bool flag = true;
			try
			{
				a = int.Parse(text);
			}
			catch
			{
				this.Error4.Content = "Incorrect number";
				flag = false;
			}

			if (flag)
			{
				this.Error4.Content = string.Empty;
			}
		}
		private void Error_TextChanged5(object sender, TextChangedEventArgs e)
		{
			string text = (sender as TextBox).Text;
			int a;
			bool flag = true;
			try
			{
				a = int.Parse(text);
			}
			catch
			{
				this.Error5.Content = "Incorrect";
				flag = false;
			}

			if (flag)
			{
				this.Error5.Content = string.Empty;
			}
		}
		private void Error_TextChanged6(object sender, TextChangedEventArgs e)
		{
			string text = (sender as TextBox).Text;
			int a;
			bool flag = true;
			try
			{
				a = int.Parse(text);
			}
			catch
			{
				this.Error6.Content = "Incorrect";
				flag = false;
			}

			if (flag)
			{
				this.Error6.Content = string.Empty;
			}
		}
		#endregion
	}
}