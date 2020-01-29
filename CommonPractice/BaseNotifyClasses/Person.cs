using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommonPractice.Interfaces;

namespace CommonPractice.BaseNotifyClasses
{
    public class Person : INotifyPropertyChanged, IPerson
    {
        private string _firstName;
        private string _lastName;
        public int Id { get; set; }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public override string ToString() => $"{FirstName} {LastName}";

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
