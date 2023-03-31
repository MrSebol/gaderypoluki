//tekst do zaszyfrowania
string clearText = "GADERYPOLUKI";
//zmienna do przechowywania zaszyfrowanego tekstu
string cypherText = "";
//zamien G na A i zapisz do nowej zmiennej
cypherText = clearText.Replace('G', '@');
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

Console.WriteLine("Zaszyfrowanyy tekst: " + cypherText);