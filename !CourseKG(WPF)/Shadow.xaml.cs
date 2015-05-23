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
	/// Логика взаимодействия для Shadow.xaml
	/// </summary>
	public partial class Shadow : Window
	{
		public Shadow()
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
			this.Hide();
			MainWindow mw = new MainWindow();
			mw.Show();
		}

		/// <summary>
		/// This event open "Shooter" window.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
		private void Shooter_click(object sender, RoutedEventArgs e)
		{
			this.Hide();
			Shooter shooter = new Shooter();
			shooter.Show();
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
		#endregion
	}
}
