using System;

string gaderypuluki(string clearText)
{
    //zmienna do przechowywania zaszyfrowanego tekstu
    //zapisujemy czysty tekst do dalszego szyfrowania
    string cypherText = clearText;
    //zamien G na A i zapisz do nowej zmiennej
    cypherText = cypherText.Replace('G', '@');
    //wez juz czesciowo zaszyfrowany tekst i zamien A na G\
    //użyj znaku pośredniego  aby zapobiec dwukrotnej zmianie jednej litery
    cypherText = cypherText.Replace('A', 'G');
    cypherText = cypherText.Replace('@', 'A');
    // d->e, e->d
    cypherText = cypherText.Replace('D', '@');
    cypherText = cypherText.Replace('E', 'D');
    cypherText = cypherText.Replace('@', 'E');
    //r->, y->r
    cypherText = cypherText.Replace('R', '@');
    cypherText = cypherText.Replace('Y', 'R');
    cypherText = cypherText.Replace('@', 'Y');
    //p->o, o->p
    cypherText = cypherText.Replace('P', '@');
    cypherText = cypherText.Replace('O', 'P');
    cypherText = cypherText.Replace('@', 'O');
    // l->, u->l
    cypherText = cypherText.Replace('L', '@');
    cypherText = cypherText.Replace('U', 'L');
    cypherText = cypherText.Replace('@', 'U');
    //k->i, i->k
    cypherText = cypherText.Replace('K', '@');
    cypherText = cypherText.Replace('I', 'K');
    cypherText = cypherText.Replace('@', 'I');

    return cypherText;
}

string gaderypoluki2(string clearText)
{
    string cypherText = "";

    foreach(char c in clearText)
    {
        //wykonaj poniższe imstrukcje dla każdej litery w tekście źródłowym
        // c = jedna literka z tekstu
        switch (c)
        {
            case 'G':
                cypherText += 'A';
                break;
            case 'A':
                cypherText+= 'G';
                break;
            case 'D':
                cypherText += 'E';
                break;
            case 'E':
                cypherText += "D";
                break;
            case 'R':
                cypherText += 'Y';
                break;
            case 'Y':
                cypherText += "R";
                break;
            case 'P':
                cypherText += "O";
                break;
            case 'O':
                cypherText += "P";
                break;
            case 'L':
                cypherText += 'U';
                break;
            case 'U':
                cypherText += 'L';
                break;
            case 'K':
                cypherText += 'I';
                break;
            case 'I':
                cypherText += 'K';
                break;
            default:
                //jeżeli nie pasuje do wzorca to przepisz istniejąca litere
                cypherText+= c;
                break;  
        }
    }
    return cypherText;
}

//tekst do zaszyfrowania
string clearText = "";
Console.WriteLine("Proszę podaj tekst do zaszyfrowania: ");
clearText = Console.ReadLine() ?? "";

//zmień na wielkie litery
clearText= clearText.ToUpper();


//zaszyfruj używając funkcji
string cypherText = gaderypuluki(clearText);

Console.WriteLine("Zaszyfrowanyy tekst (metoda1): " + cypherText);

Console.WriteLine("Zaszyfrowany tekst (metoda2): " + gaderypoluki2(clearText));