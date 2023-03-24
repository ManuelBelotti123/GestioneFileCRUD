using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneFileCRUD
{
    public partial class Form1 : Form
    {
        //dichiarazioni
        public struct P
        {
            public string nome;
            public float prezzo;
            public int quant;
            public int c;
        }
        P prodotto;

        public Form1()
        {
            InitializeComponent();
            //inizializzazioni

            //visibilità

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            prodotto.nome = nome.Text;
            prodotto.prezzo = float.Parse(prezzo.Text);
            prodotto.quant = int.Parse(quantita.Text);
            prodotto.c = 1;
            AggFile(prodotto);
        }

        private void cancella_Click(object sender, EventArgs e)
        {
            Cancella(nome.Text);
        }

        private void leggi_Click(object sender, EventArgs e)
        {
            Leggi(prodotto);
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            Modifica(nome.Text, nomemod.Text);
        }

        private void recuperodato_Click(object sender, EventArgs e)
        {
            RecuperoDato(nome.Text);
        }

        private void ricomp_Click(object sender, EventArgs e)
        {
            Ricompattazione();
        }

        //funzioni di servizio
        public void AggFile(P prodotto)
        {
            StreamWriter sw = new StreamWriter("prodotti.csv", true);
            sw.WriteLine(prodotto.nome + ";" + prodotto.prezzo + ";" + prodotto.quant + ";" + prodotto.c);
            sw.Close();
        }

        public void Leggi(P prodotto)
        {
            visualizza.Items.Clear();
            String line;
            if (File.Exists("prodotti.csv"))
            {
                StreamReader sr = new StreamReader("prodotti.csv");
                //leggo la prima riga
                line = sr.ReadLine();
                //controllo se i dati esistono
                while (line != null)
                {
                    //elabora i dati
                    string[] div = line.Split(';');
                    if (int.Parse(div.Last()) == 1)
                    {
                        visualizza.Items.Add(line);
                    }
                    //legge la linea successiva
                    line = sr.ReadLine();
                }
                sr.Close();
            }
        }

        public void Cancella(string n)
        {
            String line;
            if (File.Exists("prodotti.csv"))
            {
                StreamReader sr = new StreamReader("prodotti.csv");
                StreamWriter sw = new StreamWriter("appoggio.csv");
                //leggo la prima riga
                line = sr.ReadLine();
                //controllo se i dati esistono
                while (line != null)
                {
                    //elabora i dati
                    string[] div = line.Split(';');
                    if (n == div[0])
                    {
                        //sostuisce
                        sw.WriteLine(div[0] + ";" + div[1] + ";" + div[2] + ";" + "0");
                    }
                    else
                    {
                        sw.WriteLine(line);
                    }
                    /*
                    if (nome != div[1])
                    {
                        sw.WriteLine(line);
                    }*/
                    //legge la linea successiva
                    line = sr.ReadLine();
                }
                sw.Close();
                sr.Close();
            }

            if (File.Exists("prodotti.csv"))
            {
                File.Replace("appoggio.csv", "prodotti.csv", "backup1.csv");
            }
        }

        public void Modifica(string n, string m)
        {
            String line;
            if (File.Exists("prodotti.csv"))
            {
                StreamReader sr = new StreamReader("prodotti.csv");
                StreamWriter sw = new StreamWriter("appoggio.csv");
                //leggo la prima riga
                line = sr.ReadLine();
                //controllo se i dati esistono
                while (line != null)
                {
                    //elabora i dati
                    string[] div = line.Split(';');
                    if (n == div[0])
                    {
                        //sostuisce
                        sw.WriteLine(m + ";" + div[1] + ";" + div[2] + ";" + div[3]);
                    }
                    else
                    {
                        sw.WriteLine(line);
                    }
                    //legge la linea successiva
                    line = sr.ReadLine();
                }
                sr.Close();
                sw.Close();
            }

            if (File.Exists("appoggio.csv"))
            {
                File.Replace("appoggio.csv", "prodotti.csv", "backup.csv");
            }
        }

        public void RecuperoDato(string n)
        {
            String line;
            if (File.Exists("prodotti.csv"))
            {
                StreamReader sr = new StreamReader("prodotti.csv");
                StreamWriter sw = new StreamWriter("appoggio.csv");
                //leggo la prima riga
                line = sr.ReadLine();
                //controllo se i dati esistono
                while (line != null)
                {
                    //elabora i dati
                    string[] div = line.Split(';');
                    if (n == div[0])
                    {
                        //sostuisce
                        sw.WriteLine(div[0] + ";" + div[1] + ";" + div[2] + ";" + "1");
                    }
                    else
                    {
                        sw.WriteLine(line);
                    }
                    /*
                    if (nome.Text != div[1])
                    {
                        sw.WriteLine(line);
                    }*/
                    //legge la linea successiva
                    line = sr.ReadLine();
                }
                sw.Close();
                sr.Close();
            }

            if (File.Exists("appoggio.csv"))
            {
                File.Replace("appoggio.csv", "prodotti.csv", "backup.csv");
            }
        }

        public void Ricompattazione()
        {
            String line;
            if (File.Exists("prodotti.csv"))
            {
                StreamReader sr = new StreamReader("prodotti.csv");
                StreamWriter sw = new StreamWriter("appoggio.csv");
                //leggo la prima riga
                line = sr.ReadLine();
                //controllo se i dati esistono
                while (line != null)
                {
                    //elabora i dati
                    string[] div = line.Split(';');
                    if (int.Parse(div.Last()) != 0)
                    {
                        sw.WriteLine(line);
                    }
                    /*
                    if (nome.Text != div[1])
                    {
                        sw.WriteLine(line);
                    }*/
                    //legge la linea successiva
                    line = sr.ReadLine();
                }
                sw.Close();
                sr.Close();
            }

            if (File.Exists("appoggio.csv"))
            {
                File.Replace("appoggio.csv", "prodotti.csv", "backup.csv");
            }
        }
    }
}
