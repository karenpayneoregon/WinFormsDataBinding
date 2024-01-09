using System.ComponentModel;
using System.Runtime.CompilerServices;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8612 // Nullability of reference types in type doesn't match implicitly implemented member.

namespace MoveBetweenListBoxesCore.Models;

public class Customer : INotifyPropertyChanged
{
    private string _companyName;
    private int _identifier;
    private string _contactName;
    private int _contactTypeIdentifier;
    private int _genderIdentifier;
    private string _companyName1;

    public int Identifier
    {
        get => _identifier;
        set
        {
            if (value == _identifier) return;
            _identifier = value;
            OnPropertyChanged();
        }
    }

    public string CompanyName
    {
        get => _companyName1;
        set
        {
            if (value == _companyName1) return;
            _companyName1 = value;
            OnPropertyChanged();
        }
    }


    public string ContactName
    {
        get => _contactName;
        set
        {
            if (value == _contactName) return;
            _contactName = value;
            OnPropertyChanged();
        }
    }

    public int ContactTypeIdentifier
    {
        get => _contactTypeIdentifier;
        set
        {
            if (value == _contactTypeIdentifier) return;
            _contactTypeIdentifier = value;
            OnPropertyChanged();
        }
    }

    public int GenderIdentifier
    {
        get => _genderIdentifier;
        set
        {
            if (value == _genderIdentifier) return;
            _genderIdentifier = value;
            OnPropertyChanged();
        }
    }

    public override string ToString()
    {
        return CompanyName;
    }



    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}