using System;
using System.Collections.Generic;
using System.IO;
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

namespace autok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<auto> lista = new List<auto>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void beolvas()
        {
            using (var sr = new StreamReader("jeladas.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var sor = sr.ReadLine().Split('\t');
                    var krater = new auto(sor[0], int.Parse(sor[1]), int.Parse(sor[2]), int.Parse(sor[3]));
                    lista.Add(krater);
                }
            }
        }
    }
}
