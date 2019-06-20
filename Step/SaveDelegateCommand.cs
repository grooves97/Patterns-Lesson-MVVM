namespace MvvmByStep.Step
{
	public class SaveDelegateCommand
	{
		public DelegateCommand Command { get; private set; }

		public SaveDelegateCommand()
		{
			this.Command = new DelegateCommand(this.ExecuteSave, this.CanSave);
		}

		public void ExecuteSave(object unused)
		{
			
		}

		public bool CanSave(object unused)
		{
			return true;
		}

	}
}
