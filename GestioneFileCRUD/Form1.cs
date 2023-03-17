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
            AggQuantFile();
            AggFile(prodotto);
        }

        private void leggi_Click(object sender, EventArgs e)
        {
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
                    visualizza.Items.Add(line);
                    //legge la linea successiva
                    line = sr.ReadLine();
                }
                sr.Close();
            }
        }

        //funzioni di servizio
        public void AggFile(P prodotto)
        {
            StreamWriter sw = new StreamWriter("prodotti.csv", true);
            sw.WriteLine("Nome: " + prodotto.nome + "  Prezzo: " + prodotto.prezzo + " Quantità: " + prodotto.quant);
            sw.Close();
        }

        public void AggQuantFile()
        {
            
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
                    string[] div = line.Split(' ');
                    if (prodotto.nome == div[1])
                    {
                        prodotto.quant++;
                    }
                    //legge la linea successiva
                    line = sr.ReadLine();
                }
                sr.Close();
            }
        }
    }
}
