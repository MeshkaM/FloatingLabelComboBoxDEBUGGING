using CommunityToolkit.Mvvm.ComponentModel;

namespace FloatingLabelComboBoxDEBUGGING.Models
{
    public partial class CountriesModel : ObservableObject
    {
        [ObservableProperty]
        string? countryName;
    }
}
