using CommunityToolkit.Mvvm.ComponentModel;

namespace FloatingLabelComboBoxDEBUGGING.Models
{
    public partial class StudentModel : ObservableObject
    {
        [ObservableProperty]
        int studentID;

        [ObservableProperty]
        string? studentName;

        [ObservableProperty]
        string? countryofBirth;

        [ObservableProperty]
        int provinceofBirth;

        [ObservableProperty]
        int districtofBirth;
    }

}
