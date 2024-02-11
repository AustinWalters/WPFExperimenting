using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ClassLibrary.UI.Controls
{
    public partial class CustomIconButton : UserControl
    {
        private static readonly SolidColorBrush defaultBackgroundBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
        private static readonly SolidColorBrush defaultForegroundBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        private static readonly SolidColorBrush defaultMouseOverBackgroundBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        private static readonly SolidColorBrush defaultMouseOverForegroundBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
        private static readonly int defaultCornerRadius = 5;
        private static readonly int defaultPathHeight = 50;
        private static readonly int defaultPathWidth = 50;

        public static readonly DependencyProperty ButtonCommandProperty = DependencyProperty.Register("ButtonCommand", typeof(ICommand), typeof(CustomIconButton));
        public ICommand ButtonCommand
        {
            get { return (ICommand)GetValue(ButtonCommandProperty); }
            set { SetValue(ButtonCommandProperty, value); }
        }

        public static readonly DependencyProperty ButtonForegroundProperty = DependencyProperty.Register("ButtonForeground", typeof(Brush), typeof(CustomIconButton), new PropertyMetadata(defaultForegroundBrush));
        public Brush ButtonForeground
        {
            get { return (Brush)GetValue(ButtonForegroundProperty); }
            set { SetValue(ButtonForegroundProperty, value); }
        }
        public static readonly DependencyProperty ButtonBackgroundProperty = DependencyProperty.Register("ButtonBackground", typeof(Brush), typeof(CustomIconButton), new PropertyMetadata(defaultBackgroundBrush));
        public Brush ButtonBackground
        {
            get { return (Brush)GetValue(ButtonBackgroundProperty); }
            set { SetValue(ButtonBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBackgroundProperty = DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(CustomIconButton), new PropertyMetadata(defaultMouseOverBackgroundBrush));
        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }
        public static readonly DependencyProperty MouseOverForegroundProperty = DependencyProperty.Register("MouseOverForeground", typeof(Brush), typeof(CustomIconButton), new PropertyMetadata(defaultMouseOverForegroundBrush));
        public Brush MouseOverForeground
        {
            get { return (Brush)GetValue(MouseOverForegroundProperty); }
            set { SetValue(MouseOverForegroundProperty, value); }
        }
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(int), typeof(CustomIconButton), new PropertyMetadata(defaultCornerRadius));
        public int CornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty PathDataProperty = DependencyProperty.Register("PathData", typeof(Geometry), typeof(CustomIconButton));

        public Geometry PathData
        {
            get { return (Geometry)GetValue(PathDataProperty); }
            set { SetValue(PathDataProperty, value); }
        }

        public static readonly DependencyProperty PathHeightProperty = DependencyProperty.Register("PathHeight", typeof(int), typeof(CustomIconButton), new PropertyMetadata(defaultPathHeight));
        public int PathHeight
        {
            get { return (int)GetValue(PathHeightProperty); }
            set { SetValue(PathHeightProperty, value); }
        }

        public static readonly DependencyProperty PathWidthProperty = DependencyProperty.Register("PathWidth", typeof(int), typeof(CustomIconButton), new PropertyMetadata(defaultPathWidth));
        public int PathWidth
        {
            get { return (int)GetValue(PathWidthProperty); }
            set { SetValue(PathWidthProperty, value); }
        }
        public CustomIconButton()
        {
            InitializeComponent();
        }
    }
}
