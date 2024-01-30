/*
Scrivere una classe Person con le proprietà Nome, Cognome, Eta e con properties e GetDettagli che restituisca in una stringa le informazioni
sulla persona in questione. P.S.: GetDettagli restituisce tutti i dettagli (Nome, cognome ed età della persona).
Utilizzare una Console Application per stampare i dati dei metodi. Lasciare al candidato la scelta se utilizzare costruttori
per la popolazione degli oggetti o istanziare le proprietà nella classe Program.
*/

namespace FS0623A_backend_002_EsercizioPersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Cognome: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Età: ");
            int age = int.Parse(Console.ReadLine());

            Person myPerson = new Person(firstName, lastName, age);
            Console.WriteLine(myPerson.GetDetails());
        }
    }

    public class Person
    {
        string _firstName;
        string _lastName;
        int _age;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                // controllo se ha più di 3 caratteri
                if (value.Length > 1)
                {
                    _firstName = value;
                } else
                {
                    // lanciare un errore 
                }
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length > 2)
                {
                    _lastName = value;
                } else
                {
                    // lanciare un errore 
                }
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                } else
                {
                    // lanciare un errore 
                }

            }
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string GetDetails()
        {
            return $"La persona si chiama {FirstName} {LastName} ed ha {Age} anni.";
        }
    }
}
