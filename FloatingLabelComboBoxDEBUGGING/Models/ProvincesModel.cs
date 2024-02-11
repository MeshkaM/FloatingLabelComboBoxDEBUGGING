using CommunityToolkit.Mvvm.ComponentModel;

namespace FloatingLabelComboBoxDEBUGGING.Models
{
    public partial class ProvincesModel : ObservableObject
    {
        [ObservableProperty]
        string? countryName;

        [ObservableProperty]
        int provinceID;

        [ObservableProperty]
        string? provinceName;
    }
}
