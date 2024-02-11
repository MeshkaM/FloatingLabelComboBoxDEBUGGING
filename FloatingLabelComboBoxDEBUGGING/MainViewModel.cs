using CommunityToolkit.Mvvm.ComponentModel;
using FloatingLabelComboBoxDEBUGGING.Models;
using MaterialDesignFixedHintTextBox;
using System.Collections.ObjectModel;

namespace FloatingLabelComboBox
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<StudentModel> students;

        [ObservableProperty]
        StudentModel selectedStudent;
        partial void OnSelectedStudentChanged(StudentModel? oldValue, StudentModel? newValue)
        {
          
        }

        [ObservableProperty]
        ObservableCollection<CountriesModel>? countries;
        [ObservableProperty]
        CountriesModel? selectedCountry;

        [ObservableProperty]
        ObservableCollection<ProvincesModel>? provinces;
        [ObservableProperty]
        ProvincesModel? selectedProvince;

        [ObservableProperty]
        ObservableCollection<DistrictsModel>? districts;
        [ObservableProperty]
        DistrictsModel? selectedDistrict;

        public MainViewModel()
        {
            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            Students = new ObservableCollection<StudentModel>(await DAL.LoadStudentsAsync());

            Countries = new ObservableCollection<CountriesModel>(await DAL.LoadCountriesAsync());
            Provinces = new ObservableCollection<ProvincesModel>(await DAL.LoadProvincesAsync());
            Districts = new ObservableCollection<DistrictsModel>(await DAL.LoadDistrictsAsync());

            this.SelectedStudent = Students.FirstOrDefault();
            OnPropertyChanged(nameof(SelectedStudent));
        }
    }

}
