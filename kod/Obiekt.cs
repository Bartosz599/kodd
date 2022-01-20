using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Zad1
{




    enum MetodaWczytywaniaRepozytorium
    {
        australian = 0,
        crx = 1,
        BreastCancerWisconsin=2


    }

    internal class Obiekt
    {
        public static Config cnf;


        public string decyzja;
        public Dictionary<int, double> numeryczne;

        public Dictionary<int, double> numeryczneZamienione = new Dictionary<int, double>();

        public Dictionary<int, double> znormalizowane;
        public List<double> znormalizowane2 = new List<double>();

        public Dictionary<int, string> symboliczne = null;
        public Dictionary<int, string> Symboliczne
        {
            get
            {
                if(this.symboliczne == null)
                {
                    this.symboliczne = this.PobierzWartosciSymboliczne();
                }

                return this.symboliczne;
            }
        }

        public string[] wartosci;

        /// <summary>
        /// 1 22.08 11.46 2 4 4 1.585 0 0 0 1 2 100 1213 0
        /// </summary>
        /// <param name="linia"></param>
        public Obiekt(string linia, MetodaWczytywaniaRepozytorium metoda = MetodaWczytywaniaRepozytorium.australian)
        {
            switch(metoda)
            {
                case MetodaWczytywaniaRepozytorium.australian:
                    Metoda0(linia);                  
                    break;

                case MetodaWczytywaniaRepozytorium.crx:
                    Metoda0(linia, ',');
                    break;
                case MetodaWczytywaniaRepozytorium.BreastCancerWisconsin:
                    Metoda0(linia, ',');
                    break;
                default:
                    throw new Exception("Nieobsługiwana metoda w Konstruktorze klasy Obiekt");
            }
            
        }
        

        Dictionary<int, string> PobierzWartosciSymboliczne()
        {
            Dictionary<int, string> wynik = new Dictionary<int, string>();

            for (int i = 0; i < this.wartosci.Length; i++)
            {
                if(!this.numeryczne.ContainsKey(i))
                {
                    wynik.Add(i, wartosci[i]);
                }
            }
            return wynik;
        }

        internal static void Normalizacja(Obiekt[] obiekty, double mi, double ma,int pierwszy)
        {
            for (int i = 0; i < obiekty.Length; i++)
            {
                obiekty[i].Normalizuj(mi, ma,pierwszy);
            }
            

            Obiekt.cnf.Mi = mi;
            Obiekt.cnf.Ma = ma;
        }

        internal void Normalizuj(double mi, double ma, int pierwszy)
        {
            
            this.znormalizowane = new Dictionary<int, double>();
            foreach (var item in this.numeryczne)
            {
                var numerAtrybutu = item.Key; // numer atrybutu
                if (Obiekt.cnf.AtrybutyPominiete.Contains(numerAtrybutu))
                    continue;


                var wynik = ZnormalizujWartosc(cnf.Min[numerAtrybutu], cnf.Max[numerAtrybutu], mi, ma, item.Value);
                if(pierwszy==1)
                    this.znormalizowane.Add(item.Key, wynik);                
                this.znormalizowane2.Add(wynik);
            }

            foreach (var item in this.numeryczneZamienione)
            {
                var numerAtrybutu = item.Key; // numer atrybutu
                if (Obiekt.cnf.AtrybutyPominiete.Contains(numerAtrybutu))
                    continue;

                var wynik = ZnormalizujWartosc(cnf.Min[numerAtrybutu], cnf.Max[numerAtrybutu], mi, ma, item.Value);
                if (pierwszy == 1)
                    this.znormalizowane.Add(item.Key, wynik);
                this.znormalizowane2.Add(wynik);
            }
        }

        static double ZnormalizujWartosc(double min, double max, double mi, double ma, double wartosc)
        {
            return (wartosc - min) / (max - min) * (ma - mi) + mi;
        }

        void Metoda0(string linia, char separator = ' ')
        {
            var wartosci = linia.Split(new char[] { separator });
            this.decyzja = wartosci.Last();

            this.wartosci = new string[wartosci.Length - 1];
            this.numeryczne = new Dictionary<int, double>();

            for (int i = 0; i < wartosci.Length - 1; i++)
            {
                this.wartosci[i] = wartosci[i];
                try
                {
                    double? tmp = Parsuj(wartosci[i]);
                    if (tmp.HasValue)
                        this.numeryczne.Add(i, tmp.Value);
                }
                catch (Exception e) { }
            }
        }

        double? Parsuj(string wartosc)
        {
            wartosc = wartosc.Trim();
            double wynik = 0;

            if (!double.TryParse(wartosc.Replace(".", ","), out wynik))
            {
                if (!double.TryParse(wartosc.Replace(",", "."), out wynik))
                    return null;
            }

            return wynik;
        }

        public override string ToString()
        {
            return $"Atrybuty[{this.wartosci.Length}] ({this.decyzja})";
        }

        public static Dictionary<string, int> CzestosciWartosci(Obiekt[] obiekty, int index)
        {
            Dictionary<string, int> czestosci = new Dictionary<string, int>();
            foreach (var ob in obiekty)
            {
                var symbol = ob.wartosci[index];

                if(czestosci.ContainsKey(symbol))
                {
                    czestosci[symbol]++;
                }
                else
                {
                    czestosci.Add(symbol, 1);
                }
            }

            return czestosci;
        }

        public static Dictionary<string, int> PrzypisywanieSymbolomNumerow(Dictionary<string, int> czestosci)
        {
            var wynik = czestosci.OrderBy(item => item.Value);

            Dictionary<string, int> przypisane = new Dictionary<string, int>();

            int i = 0;
            foreach (var item in wynik)
            {
                przypisane.Add(item.Key, i++);
                
            }

            return przypisane;
        }

        public void ZamienSymbolNaNumer(Dictionary<string, int> przypisane, int index)
        {
            if (!this.numeryczneZamienione.ContainsKey(index))
                this.numeryczneZamienione.Add(index, 0);

            var symbol = this.wartosci[index];

            var numer = przypisane[symbol];

            this.numeryczneZamienione[index] = numer;
        }
        
        public static double ObliczOdleglosci(Obiekt obiekt1, Obiekt obiekt2, int metryka)
        {
            double suma=0;
            
            if (metryka == 1)
            {
                for (int i = 0; i < obiekt1.znormalizowane2.Count; i++)
                {
                    double wynik = Convert.ToDouble(obiekt1.znormalizowane2[i]) - Convert.ToDouble(obiekt2.znormalizowane2[i]);
                    wynik = Math.Abs(wynik);
                    suma += wynik;
                }
                
            }

            else
            {
                for (int i = 0; i < obiekt1.znormalizowane2.Count; i++)
                {
                    double wynik = (Convert.ToDouble(obiekt1.znormalizowane2[i]) - Convert.ToDouble(obiekt2.znormalizowane2[i]));
                    wynik = Math.Pow(wynik, 2);
                    suma += wynik;

                }
                suma = Math.Sqrt(suma);
            }

            return suma;
            

        }
        internal static string Knn(Obiekt[] obiekty, Obiekt obiekt, int k, int metryka, int metoda)
        {
            // wyciaganie unikalnych wartosci decyzji
            // knn na dwa sposoby
            // pokrycie dokladnosc w 1 kontra reszta
            // pomylone nazwy funkcji

            List<string> decyzje = new List<string>();
            for(int i=0;i<obiekty.Length;i++)
            {
                if(!decyzje.Contains(obiekty[i].decyzja))
                {
                    decyzje.Add(obiekty[i].decyzja);
                }
            }


            if(metoda==0)
            {
                var wystapienia = new (int ilosc, string decyzja)[decyzje.Count];

                
                var tupleList = new (double odleglosc, string decyzja)[k];
                int z = 0;
                for (int i = 0; i < obiekty.Length; i++)
                {
                    if (obiekt != obiekty[i])
                    {
                        double tmp = ObliczOdleglosci(obiekt, obiekty[i], metryka);
                        if (z < k)
                        {
                            tupleList[z] = (tmp, obiekty[i].decyzja);
                            z = z + 1;

                        }
                        else
                        {
                            Array.Sort(tupleList);
                            if (tupleList[k - 1].odleglosc >= tmp)
                                tupleList[k - 1] = (tmp, obiekty[i].decyzja);

                        }
                    }


                }
                for(int i=0;i<decyzje.Count;i++)
                {
                    wystapienia[i].decyzja = decyzje[i];
                    wystapienia[i].ilosc = 0;
                }
                for(int i =0;i<decyzje.Count;i++)
                {
                    for(int j =0;j<k;j++)
                    {
                        if (wystapienia[i].decyzja == tupleList[j].decyzja)
                            wystapienia[i].ilosc +=1;

                    }
                }
                Array.Sort(wystapienia);
                if (wystapienia[wystapienia.Length - 1].ilosc == wystapienia[wystapienia.Length - 2].ilosc)
                    return "brak decyzji";
                else
                    return wystapienia[wystapienia.Length - 1].decyzja;


            }
            else
            {
                return "x";
            }
        }
        internal static int Accuracy(Obiekt[] obiekty, int k, int metryka,int metoda)
        {
            
            int licznik=0;
            string decyzja2;
            for(int i=0;i<obiekty.Length;i++)
            {
                decyzja2 = Knn(obiekty, obiekty[i], k, metryka, metoda);
                if (decyzja2 == obiekty[i].decyzja)
                    licznik += 1;
            }
                   
            return licznik;
        }

        public static void ZamienSymboliczneNaNumeryczne(Obiekt[] obiekty, int pierwszy)
        {
            var symboliczne = obiekty.First().Symboliczne;

            foreach (var item in symboliczne)
            {
                var index = item.Key;

                var czestosci = Obiekt.CzestosciWartosci(obiekty, index);

                var przypisane = Obiekt.PrzypisywanieSymbolomNumerow(czestosci);
                if(pierwszy==1)
                {
                    Obiekt.cnf.Min.Add(index, przypisane.First().Value);
                    Obiekt.cnf.Max.Add(index, przypisane.Last().Value);
                }
                

                for (int i = 0; i < obiekty.Length; i++)
                //Parallel.For(0, obiekty.Length, i =>
                {
                    obiekty[i].ZamienSymbolNaNumer(przypisane, index);
                }
                //);
            }
        }


        public static void ZnajdzMinMaxWNumerycznych(Obiekt[] obiekty)
        {
            var numeryczne = obiekty.First().numeryczne;

            foreach (var item in numeryczne)
            {
                var index = item.Key;

                double min = obiekty[0].numeryczne[index];
                double max = obiekty[0].numeryczne[index];

                List<Obiekt> brakująceWartosci = new List<Obiekt>();
                for (int i = 1; i < obiekty.Length; i++)
                {
                    if (obiekty[i].numeryczne.ContainsKey(index))
                    {
                        if (obiekty[i].numeryczne[index] < min)
                            min = obiekty[i].numeryczne[index];

                        if (obiekty[i].numeryczne[index] > max)
                            max = obiekty[i].numeryczne[index];
                    }
                    else
                    {
                        brakująceWartosci.Add(obiekty[i]);
                    }
                }

                foreach (var ob in brakująceWartosci)
                {
                    ob.numeryczne.Add(index, min);
                    ob.Symboliczne.Remove(index);
                }

                Obiekt.cnf.Min.Add(index, min);
                Obiekt.cnf.Max.Add(index, max);
            }
        }
    }
}