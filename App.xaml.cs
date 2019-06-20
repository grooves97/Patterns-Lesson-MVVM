using System.Diagnostics.CodeAnalysis;
using System.Windows;
using MvvmByStep.Step;

namespace MvvmByStep
{
	[SuppressMessage("ReSharper", "UnusedMember.Local")]
	public partial class App : Application
	{
		private void App_OnStartup(object sender, StartupEventArgs e)
		{
			this.Step();
		}

		private void Step()
		{
			ViewFactory factory = new ViewFactory();

			ViewInfrastructure infrastructure = factory.Create();

			infrastructure.View.DataContext = infrastructure.ViewModel;
			infrastructure.View.Show();			
		}
	}
}
