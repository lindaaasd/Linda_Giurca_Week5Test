using System;
namespace Test.Week5.Entities
{
	public class CorsoLaurea
	{
		//Un Corso di laurea è dato da: Nome,
		//AnniDiCorso,
		//Cfu per ottenere la laurea lista di corsi associati.
		//I possibili nomi dei Corsi di Laurea possono essere solo i seguenti: Matematica, Fisica, Informatica, Ingegneria, Lettere.
		//Un Corso ha un Nome e dei CFU.

		public CorsiDiLaurea Nome { get; set; }
		public int AnniDiCorso { get; set; }
		public int TotaliCFUNecessariPerLaurearsi { get; }
		public List<Corso> CFU { get; set; } = new List<Corso>();

		public CorsoLaurea()
        {

        }

		public CorsoLaurea(CorsiDiLaurea nome, int anniDiCorso, int totaliCFU)
        {
			this.Nome = nome;
			this.AnniDiCorso = anniDiCorso;
			this.TotaliCFUNecessariPerLaurearsi = totaliCFU;
        }

	}
}

