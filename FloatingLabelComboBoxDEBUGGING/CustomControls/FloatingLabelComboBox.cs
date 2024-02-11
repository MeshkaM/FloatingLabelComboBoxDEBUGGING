using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CustomControls
{
    public class FloatingLabelComboBox : Control
    {
        static FloatingLabelComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FloatingLabelComboBox), new FrameworkPropertyMetadata(typeof(FloatingLabelComboBox)));
        }

        //***********************************************************************************************************************************************


        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register("LabelText", typeof(string), typeof(FloatingLabelComboBox), new PropertyMetadata("LabelText"));

        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        public static readonly DependencyProperty LabelForegroundProperty =
            DependencyProperty.Register("LabelForeground", typeof(Brush), typeof(FloatingLabelComboBox), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD6931B"))));

        public Brush LabelForeground
        {
            get { return (Brush)GetValue(LabelForegroundProperty); }
            set { SetValue(LabelForegroundProperty, value); }
        }

        public static readonly DependencyProperty LabelFontSizeProperty =
            DependencyProperty.Register("LabelFontSize", typeof(double), typeof(FloatingLabelComboBox), new PropertyMetadata(10.0));

        public double LabelFontSize
        {
            get { return (double)GetValue(LabelFontSizeProperty); }
            set { SetValue(LabelFontSizeProperty, value); }
        }


        //ComboBox Part

        public static readonly DependencyProperty ComboBoxTextProperty =
            DependencyProperty.Register("ComboBoxText", typeof(string), typeof(FloatingLabelComboBox), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public string ComboBoxText
        {
            get { return (string)GetValue(ComboBoxTextProperty); }
            set { SetValue(ComboBoxTextProperty, value); }
        }





        public static readonly DependencyProperty ComboBoxItemsSourceProperty =
            DependencyProperty.Register("ComboBoxItemsSource", typeof(object), typeof(FloatingLabelComboBox), new PropertyMetadata(null));
        public object ComboBoxItemsSource
        {
            get { return (object)GetValue(ComboBoxItemsSourceProperty); }
            set { SetValue(ComboBoxItemsSourceProperty, value); }
        }





        public static readonly DependencyProperty ComboBoxSelectedItemProperty =
            DependencyProperty.Register("ComboBoxSelectedItem", typeof(object), typeof(FloatingLabelComboBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnSelectedItemChange)));

        public object ComboBoxSelectedItem
        {
            get { return GetValue(ComboBoxSelectedItemProperty); }
            set { SetValue(ComboBoxSelectedItemProperty, value); }
        }

        private static void OnSelectedItemChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            FloatingLabelComboBox cc = d as FloatingLabelComboBox;
            if (cc != null) cc.OnPropertyChanged(nameof(ComboBoxSelectedItem));
        }




        public static readonly DependencyProperty ComboBoxSelectedValuePathProperty =
            DependencyProperty.Register("ComboBoxSelectedValuePath", typeof(string), typeof(FloatingLabelComboBox), new PropertyMetadata(null));

        public string ComboBoxSelectedValuePath
        {
            get { return (string)GetValue(ComboBoxSelectedValuePathProperty); }
            set { SetValue(ComboBoxSelectedValuePathProperty, value); }
        }





        public static readonly DependencyProperty ComboBoxSelectedValueProperty =
            DependencyProperty.Register("ComboBoxSelectedValue", typeof(object), typeof(FloatingLabelComboBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnSelectedValueChanged)));

        public object ComboBoxSelectedValue
        {
            get { return GetValue(ComboBoxSelectedValueProperty); }
            set { SetValue(ComboBoxSelectedValueProperty, value); }
        }

        private static void OnSelectedValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            FloatingLabelComboBox cc = d as FloatingLabelComboBox;
            if (cc != null) cc.OnPropertyChanged(nameof(ComboBoxSelectedValue));
        }






        public static readonly DependencyProperty ComboBoxDisplayMemberPathProperty =
            DependencyProperty.Register("ComboBoxDisplayMemberPath", typeof(string), typeof(FloatingLabelComboBox), new PropertyMetadata(null));

        public string ComboBoxDisplayMemberPath
        {
            get { return (string)GetValue(ComboBoxDisplayMemberPathProperty); }
            set { SetValue(ComboBoxDisplayMemberPathProperty, value); }
        }




        public static readonly DependencyProperty ComboBoxForegroundProperty =
            DependencyProperty.Register("ComboBoxForeground", typeof(Brush), typeof(FloatingLabelComboBox), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9FA8D1"))));

        public Brush ComboBoxForeground
        {
            get { return (Brush)GetValue(ComboBoxForegroundProperty); }
            set { SetValue(ComboBoxForegroundProperty, value); }
        }


        //8888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888
        //8888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888
        //8888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
