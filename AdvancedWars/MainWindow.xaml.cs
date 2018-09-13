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
            ImageBrush grassBrush;

            int brushH = 32;
            int brushW = 32;

            grassBrush = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/bkg_sky.png")),
                ViewboxUnits = BrushMappingMode.Absolute,
                Viewbox = new Rect(0, 0, brushW, brushH)
            };

            for (int i = 0; i < 256; i+=brushH)
            {
                for (int j = 0; j < 512; j += brushW)
                {
                    Rectangle grass = new Rectangle
                    {
                        Width = brushW,
                        Height = brushH,
                        Fill = grassBrush,
                        Name = "grass" + i.ToString() + j.ToString()
                    };

                    World.Children.Add(grass);

                    Canvas.SetTop(grass, i);
                    Canvas.SetLeft(grass, j);
                }
            }
        }
    }
}
