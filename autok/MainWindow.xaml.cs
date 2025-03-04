using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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

            beolvas();


            //var max = lista.Max(item => item.R, );
            var max1 = lista[0].ora;
            var max2 = lista[0].perc;
            var rendszam = lista[0].rendszam;
            foreach (var item in lista)
            {
                if (item.ora > max1)
                {
                    max1 = item.ora;
                }

            }

            foreach (var item in lista)
            {
                if (max1 == item.ora)
                {
                    if(item.perc > max2)
                    {
                        max2 = item.perc;
                        rendszam = item.rendszam;
                    }
                }

            }

            ketto.Content = $"Utolsó jeladás részletei: rendszám: {rendszam}, óra: {max1}, perc: {max2}";

            //3. feladat:
            var elso = lista[0].rendszam;
            var szoveg = "";
            foreach (var item in lista) {
                if (elso == item.rendszam) { 
                    var oraja = item.ora;
                    var perce = item.perc;

                    szoveg = szoveg + " " + oraja + ":" + perce+" ";
                }
            }

            harom.Content = $"Az első jármű: {elso} :" +szoveg;


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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ora2 = int.Parse(ora.Text);
            var perc2 = int.Parse(perc.Text);

            var jeladas = 0;

            foreach (var item in lista)
            {
                if(item.ora <= ora2 && item.perc <= perc2)
                {
                    jeladas++;
                }
            }

            negy.Content = $"Jeladások száma: {jeladas}";
        }
    }
}
