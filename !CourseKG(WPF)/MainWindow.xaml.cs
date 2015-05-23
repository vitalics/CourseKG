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
using System.Windows.Navigation;
using System.Windows.Shapes;
#endregion

namespace _CourseKG_WPF_
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MainWindow"/> class.
		/// </summary>
		public MainWindow()
		{
			InitializeComponent();
			//test parser
			//Parser parser = new Parser();
			//parser.Parse();
		}
		#region Events
		/// <summary>
		/// this event open "Shooter" window.
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
		/// This event open "Shadow" window.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
		private void Shadow_click(object sender, RoutedEventArgs e)
		{
			this.Hide();
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
		#endregion
	}
}