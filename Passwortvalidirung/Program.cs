namespace Passwortvalidirung;

class Program
{
    static void Main2(string[] args)
    {
        string password = Console.ReadLine();
        List<string> errors = new List<string>();
        if (password.Length < 8)
        {
            errors.Add("Das Passwort muss mindestens 8 Zeichen lang sein.");
        }
        bool einGroßbuchstabe = false;
        bool einKleinbuchstabe = false;
        bool eineZahl = false;
        foreach (char singleChar in password)
        {
            if (char.IsUpper(singleChar))
            {
                einGroßbuchstabe = true;
            }
            if (char.IsLower(singleChar))
            {
                einKleinbuchstabe = true;
            }
            if (char.IsDigit(singleChar))
            {
                eineZahl = true;
            }
            if(einGroßbuchstabe && einKleinbuchstabe && eineZahl)
            {
                break;
            }
        }
        if (!einGroßbuchstabe)
        {
            errors.Add("Das Passwort muss mindestens einen Großbuchstaben enthalten.");
        }
        if (!einKleinbuchstabe)
        {
            errors.Add("Das Passwort muss mindestens einen Kleinbuchstaben enthalten.");
        }
        if (!eineZahl)
        {
            errors.Add("Das Passwort muss mindestens eine Zahl enthalten.");
        }

        if (Palindromprüfung.Program.isPalindrome(password))
        {
            errors.Add("Das Passwort darf kein Palindrom sein.");
        }

        if (errors.Count == 0)
        {
            Console.WriteLine("Das Passwort ist gültig.");
        }
        else
        {
            Console.WriteLine("Das Passwort ist ungültig:");
            foreach (string error in errors)
            {
                Console.WriteLine(error);
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Um dich anzumelden, bauchst du ein Passwort, dieses muss Folgendes erfüllen:");
        Console.WriteLine("Mindestens 8 Zeichen lang\nEnthält mindestens einen Großbuchstaben\nEnthält mindestens einen Kleinbuchstaben\nEnthält mindestens eine Zahl");

        string Userinput = Console.ReadLine();

        char[] stelle = Userinput.ToCharArray();

        int i = 0;

        if (Userinput.Length < 8)
        {
            Console.WriteLine("Dein Passwort ist nicht 8 Zeichen lang");
        }
        else if (!Char.IsUpper(stelle[i++]))
        {
            Console.WriteLine("Dein Passwort braucht einen Großbuchstaben");
        }
        else if (!Char.IsLower(stelle[i++]))
        {
            Console.WriteLine("Dein Passwort braucht einen Kleinbuchstaben");
        }
        else if (Char.IsDigit(stelle[i++]))
        {
            Console.WriteLine("Dein Passwort braucht eine Zahl");
        }
        else
        {
            Console.WriteLine("Dein Passwort ist Gültig");
        }
    }
}