using System;
namespace Test.Week5.Entities
{
	public class Studente
	{

		//Lo studente è definito con:
		//Nome
		//Cognome AnnoDiNascita Immatricolazione Esami RichiestaLaurea
		//L’immatricolazione ha le seguenti caratteristiche:
		//Matricola(La matricola dello studente deve essere univoca, autogenerata e read - only) DataInizio

		public string Nome { get; set; }
		public string Cognome { get; set; }
		public DateTime DOB { get; set; }
		public Immatricolazione Immatricolazione { get; set; }
		public bool RichiestaLaurea { get; set; }
		public List<Esame> Esami { get; set; } = new List<Esame>(); 


		public Studente()
		{
		}

		public Studente(string nome, string cognome, DateTime dob, bool richiestaLaurea)
        {
			this.Nome = nome;
			this.Cognome = cognome;
			this.DOB = dob;
			this.RichiestaLaurea = richiestaLaurea;
        }
	}
}

