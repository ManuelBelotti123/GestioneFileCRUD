﻿using System;
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
            AggFile();
        }

        private void cancella_Click(object sender, EventArgs e)
        {
            Cancella();
        }

        private void leggi_Click(object sender, EventArgs e)
        {
            Leggi();
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            Modifica();
        }

        //funzioni di servizio
        public void AggFile()
        {
            StreamWriter sw = new StreamWriter("prodotti.csv", true);
            sw.WriteLine("Nome: " + prodotto.nome + " Prezzo: " + prodotto.prezzo + " Quantità: " + prodotto.quant + " C: " + prodotto.c);
            sw.Close();
        }

        public void Leggi()
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

        public void Cancella()
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
                    line.Remove(line.Length - 1, 1);
                    line.Append('0');
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

            /*if (File.Exists("appoggio.csv"))
            {
                File.Replace("appoggio.csv", "prodotti.csv", "backup.csv");
            }*/
        }

        public void Modifica()
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
                    string[] div = line.Split(' ');
                    if (nome.Text == div[1])
                    {
                        //sostuisce
                        sw.WriteLine("Nome: " + nomemod.Text + "  Prezzo: " + prezzomod.Text + "  Quantità: " + prodotto.quant);
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
    }
}
