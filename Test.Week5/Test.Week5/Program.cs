using Test.Week5.Entities;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Universita.CreaStruttura();
//RISPOSTE DOMANDE TEST

//1.C public int Sum(ref int x, int y, int result)
//2.Le variabili di tipo string vengono memorizzate nella memoria heap perché sono Value Type.
//3.
//A int k = (int)z;
//B long x = y;



//Creare una Console App che gestisca l’iscrizione ad un esame di uno Studente.

//All’accesso, uno studente può:

//-Verbalizzare un Esame prenotato.
//NOTA:Scrivere un metodo EsamePassato che, dato un esame, vada ad aggiornare i CFU accumulati
//dallo studente, metta il flag Passato sull’esame e verifichi se con tale esame sono stati raggiunti
//i CFU necessari per richiedere la laurea (e quindi metta il flag Richiestalaurea a true);
//Requisiti tecnici:
//-Specificare almeno 3 costruttori - Usare almeno una volta enum


bool continua = true;
int scelta;

do
{
	scelta = PrintMenu();

    switch (scelta)
    {

        case 1:
            PrenotaEsame();
            // prenota esame

            break;
        case 2:
            // verbalizza esame
            VerbalizzaEsame();
            break;
        default:
            continua = false;
            Console.WriteLine("Arrivederci");
            break;
    }

} while (continua);

int PrintMenu()
{
    Console.WriteLine("** Benvenuto ** ");
    Console.WriteLine("1. Prenota esame ");
    Console.WriteLine("2. Verbalizza esame ");
    Console.WriteLine("3. Esci ");
    Console.WriteLine("Scelta/> ");
	Int32.TryParse(Console.ReadLine(), out int scelta);
	return scelta;

}


// -Prenotarsi ad un Esame
//NOTA:Uno studente può richiedere un esame solo se esso è presente nel Corso di Laurea associato allo
//studente,
//se i CFU del corso associato all’esame non superino i CFU massimi del Corso di laurea
//e se non
//ha il flag RichiestaLaurea assegnato a vero.
//Nel caso le condizioni siano verificate, lo studente aggiunge l’esame alla lista Esami.

void PrenotaEsame()
{
    //Studente studenteCheVuolePrenotare = new Studente();

    //Console.WriteLine("Qual'è il tuo nome?");
    //studenteCheVuolePrenotare.Nome = Console.ReadLine();
    //Console.WriteLine("Qual'è il tuo cognome?");
    //studenteCheVuolePrenotare.Cognome = Console.ReadLine();
    //Console.WriteLine("Quando sei nat* ?");
    //DateTime.TryParse(Console.ReadLine(), out DateTime dobStudente);
    //studenteCheVuolePrenotare.DOB = dobStudente;
    Console.WriteLine("Che esame vuoi prenotare?");
    string nomeEsameDaPrenotare = Console.ReadLine();

  
    foreach (var esame in Universita.Studente.Esami)
    {
        if (nomeEsameDaPrenotare == esame.CorsoDiQuestoEsame.Nome && esame.Passato==true)
        {
            Console.WriteLine("Hai già fatto questo esame! Ritorna al menu ");
            return;
        }
    }   

    bool corsoTrovato = false;
    Corso corsoDaPrenotare = new Corso();

    foreach(var corso in Universita.Studente.Immatricolazione.CorsoDiLaurea.CFU)
    {
        if(nomeEsameDaPrenotare == corso.Nome)
        {
            Console.WriteLine($"Il {nomeEsameDaPrenotare} si trova nel Corso di laurea!");
            corsoTrovato = true;
            corsoDaPrenotare = corso;
        } 
    }

    if(corsoTrovato == false)
    {
        Console.WriteLine("Questo corso non esiste nel tuo piano di studi");
        return;
    }

    if (Universita.Studente.Immatricolazione.CFUAccumulati  >
        Universita.Studente.Immatricolazione.CorsoDiLaurea.TotaliCFUNecessariPerLaurearsi )
    {
        Console.WriteLine("Hai già il punteggio sufficiente per laurearti, non fare più esami!");
        return;
    }

    if (Universita.Studente.RichiestaLaurea)
    {
        Console.WriteLine("Hai già richiesto la laurea, non fare più esami!");
        return;
    }

    Esame esameDaPrenotare = new Esame();
    esameDaPrenotare.CorsoDiQuestoEsame = corsoDaPrenotare;
    esameDaPrenotare.Passato = false;
    Universita.Studente.Esami.Add(esameDaPrenotare);

    Console.WriteLine("Hai prenotato l'esame!");
    
}
void VerbalizzaEsame()
{
    /*NOTA: Scrivere un metodo EsamePassato che, dato un esame, vada ad aggiornare 
     * i CFU accumulati dallo studente, metta il flag Passato sull’esame e verifichi se con tale 
     * esame sono stati raggiunti i CFU necessari per richiedere la laurea(e quindi metta il flag Richiestalaurea a true);*/

    Console.WriteLine("Che esame devi verbalizzare?");
    string esameDaVerbalizzare = Console.ReadLine();

    foreach(var esame in Universita.Studente.Esami)
    {
        if (esameDaVerbalizzare == esame.CorsoDiQuestoEsame.Nome)
        {
            esame.Passato = true;
            Universita.Studente.Immatricolazione.CFUAccumulati += esame.CorsoDiQuestoEsame.CFUFornitiDaQuestoCorso;
        }
    }

    if (Universita.Studente.Immatricolazione.CFUAccumulati >= Universita.Studente.Immatricolazione.CorsoDiLaurea.TotaliCFUNecessariPerLaurearsi)
    {
        Console.WriteLine("Puoi richiedere la laurea!!!");
        Universita.Studente.RichiestaLaurea = true;
    }
    Console.WriteLine("Complimenti, hai verbalizzato l'esame!");
}


