using System;
namespace Test.Week5.Entities
{
	public static class Universita
	{

        public static Studente Studente = new Studente("Mario", "rossi", new DateTime(1995, 1, 1), false);
        public static List<CorsiDiLaurea> CorsiDiLaurea = new List<CorsiDiLaurea>();
		public static void CreaStruttura()
		{
			Corso corso1 = new Corso("Algebra 1", 12);
			Corso corso2 = new Corso("Fisica 1", 11);
			Corso corso3 = new Corso("Algebra 2", 13);
			Corso corso4 = new Corso("Fisica 2", 12);

			Corso corso5 = new Corso("Analisi matematica", 6);
			Corso corso6 = new Corso("Programmazione", 8);

			CorsoLaurea corsoLaurea1 = new CorsoLaurea(Entities.CorsiDiLaurea.Fisica,4, 25);
			corsoLaurea1.CFU.Add(corso1);
			corsoLaurea1.CFU.Add(corso2);
			corsoLaurea1.CFU.Add(corso3);
			corsoLaurea1.CFU.Add(corso4);

			CorsoLaurea corsoLaurea2 = new CorsoLaurea(Entities.CorsiDiLaurea.Informatica, 8, 80);
			corsoLaurea2.CFU.Add(corso5);
			corsoLaurea2.CFU.Add(corso6);

			//CorsiDiLaurea.Add(corsoLaurea1);

			Immatricolazione immatricolazione = new Immatricolazione(new DateTime(2020, 1, 1), false, 22);
			
			Esame esameFatto = new Esame();
			esameFatto.CorsoDiQuestoEsame = corso1;
			esameFatto.Passato = true;
			Studente.Esami.Add(esameFatto);
			Studente.Immatricolazione = immatricolazione;
			immatricolazione.CorsoDiLaurea=corsoLaurea1;
		}

	}
}

