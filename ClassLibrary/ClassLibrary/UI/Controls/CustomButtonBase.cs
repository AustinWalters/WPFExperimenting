using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ClassLibrary.UI.Controls
{
    public class CustomButtonBase : UserControl
    {
        protected static readonly SolidColorBrush defaultBackgroundBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
        protected static readonly SolidColorBrush defaultForegroundBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        protected static readonly SolidColorBrush defaultMouseOverBackgroundBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        protected static readonly SolidColorBrush defaultMouseOverForegroundBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));

        protected static readonly int defaultCornerRadius = 15;

        public static readonly DependencyProperty ButtonCommandProperty = DependencyProperty.Register("ButtonCommand", typeof(ICommand), typeof(CustomButtonBase));
        public ICommand ButtonCommand
        {
            get { return (ICommand)GetValue(ButtonCommandProperty); }
            set { SetValue(ButtonCommandProperty, value); }
        }

        public static readonly DependencyProperty ButtonForegroundProperty = DependencyProperty.Register("ButtonForeground", typeof(Brush), typeof(CustomButtonBase), new PropertyMetadata(defaultForegroundBrush));
        public Brush ButtonForeground
        {
            get { return (Brush)GetValue(ButtonForegroundProperty); }
            set { SetValue(ButtonForegroundProperty, value); }
        }

        public static readonly DependencyProperty ButtonBackgroundProperty = DependencyProperty.Register("ButtonBackground", typeof(Brush), typeof(CustomButtonBase), new PropertyMetadata(defaultBackgroundBrush));
        public Brush ButtonBackground
        {
            get { return (Brush)GetValue(ButtonBackgroundProperty); }
            set { SetValue(ButtonBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBackgroundProperty = DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(CustomButtonBase), new PropertyMetadata(defaultMouseOverBackgroundBrush));
        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverForegroundProperty = DependencyProperty.Register("MouseOverForeground", typeof(Brush), typeof(CustomButtonBase), new PropertyMetadata(defaultMouseOverForegroundBrush));
        public Brush MouseOverForeground
        {
            get { return (Brush)GetValue(MouseOverForegroundProperty); }
            set { SetValue(MouseOverForegroundProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(int), typeof(CustomButtonBase), new PropertyMetadata(defaultCornerRadius));
        public int CornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
    }
}
