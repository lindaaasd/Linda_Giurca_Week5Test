using System;
namespace Test.Week5.Entities
{
	public class Immatricolazione
	{
		//L’immatricolazione ha le seguenti caratteristiche:
		//Matricola(La matricola dello studente deve essere univoca, autogenerata e read-only)
		//DataInizio
		//CorsoDiLaurea
		//FuoriCorso
		//CFUAccumulati

		public static int prossimaMatricola = 1;

		public int Matricola { get; }
		public DateTime DataInizio { get; set; }
		public CorsoLaurea CorsoDiLaurea { get; set; }
		public bool FuoriCorso { get; set; }
		public int CFUAccumulati { get; set; } 


		public Immatricolazione()
		{
		}

		public Immatricolazione(DateTime dataInizio, bool fuoriCorso, int cfuAccumulati)
        {

			prossimaMatricola++;
			this.FuoriCorso = fuoriCorso;
			this.CFUAccumulati = cfuAccumulati;
			this.DataInizio = dataInizio;

		}


		
       
    }
}

	