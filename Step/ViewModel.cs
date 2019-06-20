using System.ComponentModel;

namespace MvvmByStep.Step
{
	public class ViewModel : INotifyPropertyChanged
	{
		private readonly Model model;

		public ViewModel(Model model)
		{
			this.model = model;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}