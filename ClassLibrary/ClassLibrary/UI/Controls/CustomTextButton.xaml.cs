using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ClassLibrary.UI.Controls
{
    public partial class CustomTextButton : UserControl
    {
        private static readonly SolidColorBrush defaultBackgroundBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
        private static readonly SolidColorBrush defaultForegroundBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        private static readonly SolidColorBrush defaultMouseOverBackgroundBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        private static readonly SolidColorBrush defaultMouseOverForegroundBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
        private static readonly int defaultCornerRadius = 15;
        public static readonly DependencyProperty ButtonContentProperty = DependencyProperty.Register("ButtonContent", typeof(string), typeof(CustomTextButton));
        public string ButtonContent
        {
            get { return (string)GetValue(ButtonContentProperty); }
            set { SetValue(ButtonContentProperty, value); }
        }
        public static readonly DependencyProperty ButtonCommandProperty = DependencyProperty.Register("ButtonCommand", typeof(ICommand), typeof(CustomTextButton));
        public ICommand ButtonCommand
        {
            get { return (ICommand)GetValue(ButtonCommandProperty); }
            set { SetValue(ButtonCommandProperty, value); }
        }
        public static readonly DependencyProperty ButtonForegroundProperty = DependencyProperty.Register("ButtonForeground", typeof(Brush), typeof(CustomTextButton), new PropertyMetadata(defaultForegroundBrush));
        public Brush ButtonForeground
        {
            get { return (Brush)GetValue(ButtonForegroundProperty); }
            set { SetValue(ButtonForegroundProperty, value); }
        }
        public static readonly DependencyProperty ButtonBackgroundProperty = DependencyProperty.Register("ButtonBackground", typeof(Brush), typeof(CustomTextButton), new PropertyMetadata(defaultBackgroundBrush));
        public Brush ButtonBackground
        {
            get { return (Brush)GetValue(ButtonBackgroundProperty); }
            set { SetValue(ButtonBackgroundProperty, value); }
        }
        public static readonly DependencyProperty MouseOverBackgroundProperty = DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(CustomTextButton), new PropertyMetadata(defaultMouseOverBackgroundBrush));
        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }
        public static readonly DependencyProperty MouseOverForegroundProperty = DependencyProperty.Register("MouseOverForeground", typeof(Brush), typeof(CustomTextButton), new PropertyMetadata(defaultMouseOverForegroundBrush));
        public Brush MouseOverForeground
        {
            get { return (Brush)GetValue(MouseOverForegroundProperty); }
            set { SetValue(MouseOverForegroundProperty, value); }
        }
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(int), typeof(CustomTextButton), new PropertyMetadata(defaultCornerRadius));
        public int CornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public CustomTextButton()
        {
            InitializeComponent();
        }
    }
}
