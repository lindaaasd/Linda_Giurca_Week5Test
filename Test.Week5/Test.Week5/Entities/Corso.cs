using System;
namespace Test.Week5.Entities
{
	public class Corso
	{

		//Un Corso ha un Nome e dei CFU.

		public string Nome { get; set; }
		public int CFUFornitiDaQuestoCorso { get; set; }

		public Corso()
        {

        }

		public Corso(string nome, int cfuForniti)
        {
			this.Nome = nome;
			this.CFUFornitiDaQuestoCorso = cfuForniti;
        }

	}
}

