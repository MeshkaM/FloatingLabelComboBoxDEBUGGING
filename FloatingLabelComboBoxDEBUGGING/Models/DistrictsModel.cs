using CommunityToolkit.Mvvm.ComponentModel;

namespace FloatingLabelComboBoxDEBUGGING.Models
{
    public partial class DistrictsModel : ObservableObject
    {
        [ObservableProperty]
        int provinceID;

        [ObservableProperty]
        int districtID;

        [ObservableProperty]
        string? districtName;
    }
}