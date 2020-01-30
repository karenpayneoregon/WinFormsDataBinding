using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace MoveBetweenListBoxes.Classes
{
    public class Customer : INotifyPropertyChanged
    {
        private string _companyName;
        public int Identifier { get; set; }

        public string CompanyName
        {
            get => _companyName;
            set
            {
                _companyName = value;

                OnPropertyChanged();
            }
        }

        public string ContactName { get; set; }
        public int ContactTypeIdentifier { get; set; }
        public int GenderIdentifier { get; set; }
        public override string ToString()
        {
            return CompanyName;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}