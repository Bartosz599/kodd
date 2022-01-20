using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Zad1
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();

            cbMetodaWczytania.DataSource = Enum.GetValues(typeof(MetodaWczytywaniaRepozytorium));
            cbMetryka.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }


        string sciezkaDoPliku;
        public string SciezkaDoPliku
        {
            get
            {
                return this.sciezkaDoPliku;
            }

            set
            {
                if (!System.IO.File.Exists(value))
                {
                    this.sciezkaDoPliku = "";
                    this.btnAnaliza.Enabled = false;
                    this.tbSciezkaPlikuRepozytorium.Text = "";

                    return;
                }

                this.sciezkaDoPliku = value;
                btnAnaliza.Enabled = true;
                tbSciezkaPlikuRepozytorium.Text = value;
            }
        }

        private void btnWybierzPlik_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            this.SciezkaDoPliku = ofd.FileName;

            Obiekt.cnf = new Config();

            var tmp = System.IO.File.ReadAllLines(ofd.FileName);
            label7.Text = tmp[0];
            var ob = new Obiekt(tmp.First(), (MetodaWczytywaniaRepozytorium)Enum.Parse(typeof(MetodaWczytywaniaRepozytorium), cbMetodaWczytania.SelectedValue.ToString()));
            if (cbMetodaWczytania.SelectedIndex >= 1)
                label4.Text = "Wypisz po przecinku wartosci wiersza do sprawdzenia ";
            else
                label4.Text = "Wypisz po spacji wartosci wiersza do sprawdzenia ";
            for (int i = 0; i < ob.wartosci.Length; i++)
            {
                clbAtrybutyDoPominiecia.Items.Add(
                    new KeyValuePair<string, int>($"Atrybut [{i}] = {ob.wartosci[i]}" , i)
                );
                clbAtrybutyDoPominiecia.DisplayMember = "Key";
            }

            
        }


        Obiekt[] obiekty;
        private void btnAnaliza_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbAtrybutyDoPominiecia.CheckedItems.Count; i++)
            {
                var tmp = (KeyValuePair<string, int>)clbAtrybutyDoPominiecia.CheckedItems[i];
                Obiekt.cnf.AtrybutyPominiete.Add(tmp.Value);
            }           

            var linie = System.IO.File.ReadAllLines(this.SciezkaDoPliku);

            this.obiekty = new Obiekt[linie.Length];
                        
            MetodaWczytywaniaRepozytorium metoda = (MetodaWczytywaniaRepozytorium)Enum.Parse(typeof(MetodaWczytywaniaRepozytorium), cbMetodaWczytania.SelectedValue.ToString());
            
            for (int i = 0; i < linie.Length; i++)
            {
                this.obiekty[i] = new Obiekt(linie[i], metoda);
            }

            Obiekt.ZamienSymboliczneNaNumeryczne(this.obiekty,1);
            Obiekt.ZnajdzMinMaxWNumerycznych(this.obiekty);

            Obiekt.Normalizacja(this.obiekty, (double)nudMi.Value, (double)nudMa.Value,1);

            var str = Newtonsoft.Json.JsonConvert.SerializeObject(Obiekt.cnf);

            System.IO.File.WriteAllText(this.SciezkaDoPliku + ".json", str);
            Dokladnosc.Enabled=true;
        }

        private void clbAtrybutyDoPominiecia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Dokladnosc_Click(object sender, EventArgs e)
        {
            
            int licznik=Obiekt.Accuracy(obiekty, Decimal.ToInt32(nUpDown.Value), cbMetryka.SelectedIndex, comboBox1.SelectedIndex);
            int ilosc = obiekty.Length;
            double dokladnosc = (licznik*100)/ilosc;
            
            accuracy.Text = Convert.ToString(dokladnosc)+"%"; 
        }

        private void btnKnn_Click(object sender, EventArgs e)
        {
            Obiekt[] obiektyCopy = new Obiekt[obiekty.Length];
            for(int i=0;i<obiekty.Length;i++)
            {
                obiektyCopy[i] = obiekty[i];
            }
            Obiekt nowyObiekt = new Obiekt(tbWiersz.Text, (MetodaWczytywaniaRepozytorium)Enum.Parse(typeof(MetodaWczytywaniaRepozytorium), cbMetodaWczytania.SelectedValue.ToString()));
            obiektyCopy[obiektyCopy.Length-1] = nowyObiekt;
            Obiekt.ZamienSymboliczneNaNumeryczne(obiektyCopy,2);
            obiektyCopy[obiektyCopy.Length-1].Normalizuj((double)nudMi.Value, (double)nudMa.Value,2);
            decyzja.Text=Obiekt.Knn(obiekty, obiektyCopy[obiektyCopy.Length-1], Decimal.ToInt32(nUpDown.Value), cbMetryka.SelectedIndex, comboBox1.SelectedIndex);
        }
    }
}
