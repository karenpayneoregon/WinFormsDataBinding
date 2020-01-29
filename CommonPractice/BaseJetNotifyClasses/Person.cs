using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommonPractice.Interfaces;
using JetBrains.Annotations;

namespace CommonPractice.BaseJetNotifyClasses
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
                if (value == _firstName) return;
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value == _lastName) return;
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public override string ToString() => $"{FirstName} {LastName}";
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}