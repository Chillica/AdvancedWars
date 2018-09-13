using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdvancedWars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Rectangle grass;
            ImageBrush grassBrush;
            int brushH = 64;
            int brushW = 64;

            grassBrush = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/bkg_sky.png")),
                ViewboxUnits = BrushMappingMode.Absolute,
                Viewbox = new Rect(32, 32, brushW, brushH)
            };

            grass = new Rectangle
            {
                Width = brushW,
                Height = brushH,
                Fill = grassBrush
            };


            World.Children.Add(grass);
            Canvas.SetTop(grass, 100);
            Canvas.SetLeft(grass, 100);
        }
    }
}
