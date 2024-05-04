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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection.Emit;

namespace showcase1wpf
{
    /// <summary>
    /// Interaction logic for results.xaml
    /// </summary>
    public partial class results : Window
    {
        List<string> fonts = new List<string>();
        int currentpos = 0;

        private void Update()
        {
            label.FontFamily = new System.Windows.Media.FontFamily(fonts[currentpos]);
            label.Content = fonts[currentpos];
        }

        public results()
        {
            InitializeComponent();
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            foreach (FontFamily fontFamily in installedFonts.Families)
            {
                fonts.Add(fontFamily.Name);
            }
            Update();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (currentpos == 0)
            {
                currentpos = fonts.Count - 1;
            } else
            {
                currentpos = currentpos - 1;
            }
            Update();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (currentpos >= fonts.Count - 1)
            {
                currentpos = 0;
            } else
            {
                currentpos = currentpos + 1;
            }
            Update();
        }
    }
}
