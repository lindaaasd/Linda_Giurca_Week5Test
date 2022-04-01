using System;
namespace Test.Week5.Entities
{
	public class Esame
	{
		///Un Esame si riferisce ad un corso e tiene conto se esso è stato passato.
		
		public Corso CorsoDiQuestoEsame { get; set; }
		public bool Passato { get; set; }

		public Esame()
        {

        }

	}
}

