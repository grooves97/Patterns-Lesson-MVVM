using System;
using System.ComponentModel;
using System.Windows.Input;

namespace MvvmByStep.Step
{
	public class ViewModel : INotifyPropertyChanged
	{
		private readonly Model model;

		public string Name
		{
			get
			{
				return this.model.Name;
			}
			set
			{
				if (this.model.Name != value)
				{
					this.model.Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}

		public string Address
		{
			get
			{
				return this.model.Address;
			}
			set
			{
				if (this.model.Address != value)
				{
					this.model.Address = value;
					this.OnPropertyChanged("Address");
				}
			}
		}

		public bool IsMale
		{
			get
			{
				return this.model.IsMale;
			}
			set
			{
				if (this.model.IsMale != value)
				{
					this.model.IsMale = value;
					this.OnPropertyChanged("IsMale");
				}
			}
		}

		public int BirthDay
		{
			get
			{
				return this.model.BirthDate.Day;
			}
			set
			{
				if (this.model.BirthDate.Day != value)
				{
					this.model.BirthDate = new DateTime(this.model.BirthDate.Year, this.model.BirthDate.Month, value);
					this.OnPropertyChanged("BirthDay");
				}
			}
		}

		public int BirthMonth
		{
			get
			{
				return this.model.BirthDate.Month;
			}
			set
			{
				if (this.model.BirthDate.Month != value)
				{
					this.model.BirthDate = new DateTime(this.model.BirthDate.Year, value, this.model.BirthDate.Day);
					this.OnPropertyChanged("BirthMonth");
				}
			}
		}

		public int BirthYear
		{
			get
			{
				return this.model.BirthDate.Year;
			}
			set
			{
				if (this.model.BirthDate.Year != value)
				{
					this.model.BirthDate = new DateTime(value, this.model.BirthDate.Month, this.model.BirthDate.Day);
					this.OnPropertyChanged("BirthYear");
				}
			}
		}

        public string Email
        {
            get
            {
                return this.model.Email;
            }

            set
            {
                if (this.model.Email != value)
                {
                    this.model.Email = value;
                    this.OnPropertyChanged("Email");
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.model.PhoneNumber;
            }

            set
            {
                if (this.model.PhoneNumber != value)
                {
                    this.model.PhoneNumber = value;
                    this.OnPropertyChanged("PhoneNumber");
                }
            }
        }

		public ICommand SaveCommand { get; private set; }

		public ICommand EraseCommand { get; private set; }

		public ViewModel(Model model, ICommand saveCommand, ICommand eraseCommand)
		{
			this.model = model;
			this.SaveCommand = saveCommand;
			this.EraseCommand = eraseCommand;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}