using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._2
{
    internal class Program
    {
        class Banca
        {
            public string nomeBanca;
            List <Cliente> datiClienti = new List <Cliente> ();
            ArrayList datiPrestiti = new ArrayList();
            public Banca() { }
            public Banca(string nomeBanca)
            {
                this.nomeBanca = nomeBanca;
            }
            public void AddCliente(Cliente c)
            {
                datiClienti.Add(c);
            }
            public void AddPrestito(Prestito p)
            {
                datiPrestiti.Add(p);
            }
            public void RemCliente(Cliente c)
            {
                foreach (var cliente in datiClienti)
                {
                    if(cliente == c)
                    {
                        datiClienti.Remove(cliente);
                    }
                }
            }

        }
        class Cliente
        {
            public string nome;
            public string cognome;
            public string codiceF;
            public float stipendio;
            public Cliente() { }
            public Cliente(string nome, string cognome, string codiceF, float stipendio) 
            { 
                this.nome = nome;
                this.cognome = cognome;
                this.codiceF = codiceF;
                this.stipendio = stipendio;
            }
            public override string ToString()
            {
                return string.Format("{0} {1} {2} {3}", nome, cognome, codiceF, stipendio);
            }
        }
        class Prestito
        {
            public float ammontare;
            public float rata;
            public DateTime dataInizio;
            public DateTime dataFine;
            public Cliente c;
            public Prestito() { }
            public Prestito(Cliente c, float ammontare, float rata, DateTime dataInizio, DateTime dataFine) 
            {
                this.c = c;
                this.ammontare = ammontare;
                this.rata = rata;
                this.dataInizio = dataInizio;
                this.dataFine = dataFine;
            }
            public string StampaProspetto(Cliente c)
            {

                return "";
            }
            public override string ToString()
            {
                return string.Format("{0} {1} {2} {3}", ammontare, rata, dataInizio, dataFine);
            }
        }
        static void Main(string[] args)
        {
            Cliente marco = new Cliente("marco", "rossi", "MN232", 1000);
            Cliente paolo = new Cliente("paolo", "zucchi", "PZ136", 700);
            Prestito p1 = new Prestito(marco, 3000, 100, new DateTime(2018, 10, 11), new DateTime(2021, 2, 5));
            Banca Bpm = new Banca();
            Bpm.AddCliente(marco);
            Bpm.AddPrestito(p1);
        }
    }
}
