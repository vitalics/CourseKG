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
		private void MainWindow_click(object sender, RoutedEventArgs e)
		{
			this.Hide();
			MainWindow mw = new MainWindow();
			mw.Show();
		}

		private void Shadow_click(object sender, RoutedEventArgs e)
		{
			this.Hide();
			Shadow shadow = new Shadow();
			shadow.Show();
		}

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}
		private void Calculate_click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("LOL!!!!!!!!!!!");
		}
		#endregion
	}
}
