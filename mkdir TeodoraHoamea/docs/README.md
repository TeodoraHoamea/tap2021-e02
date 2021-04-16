# Evaluarea nr. 2 pentru cursul Tehnici Avansate de Programare #

## Context ##
Sunteți proaspăt angajat(ă) la o agenție guvernamentală secretă care se ocupă de apărarea împotriva armelor biologice - Agenția pentru Defensiva Împotriva Bio-Armelor și Substanțelor (*ADIBAS*) și sunteți repartizat(ă) în departamentul care se ocupă de Neutralizarea Aplicată prin Inspecția a k-Evoluții (*NAIKE*).

Deoarece proiectul e abia la început echipa de dezvoltare se ocupă de stocarea în baza de date a mostrelor de ADN obținute din diverse teste. Aceste mostre vor fi ulterior prelucrate pe un super-calculator pentru antrenarea unui model de învățare automată.

Salvarea mostrelor se face într-un tabel căruia îi este asociată o clasă (`Sample`) cu următoarele proprietăți:
- `Id` de tip `Guid`,
- `DnaSequence` de tip `string` care conține 1000 caractere și fiecare caracter poate fi  `A`, `C`, `G` sau `T`,
- `AnalysisTime` de tip `DateTime` care conține data și timpul când secvența a fost analizată.

Prima sarcină pe care o primiți este să implementați șablonul `Repository` pentru stocarea și manipularea datelor, după care, fiind într-o criză de timp, echipa vă mai dă o sarcină suplimentară: să verificați că proprietatea `DnaSequence` conține o secvență DNA validă.

Totodată, în căsuța poștală vă apare un e-mail de la șeful echipei de dezvoltare Raíd Bitescu, care a ajuns în această postură printr-o eroare de procedură și nu prea are treabă cu programarea dar îi plac acronimele:

> Salut,
>
> Bine ai venit în echipa de dezvoltare NAIKE! Colegii cu care ai susținut interviul te-au lăudat foarte mult, însă ca să faci parte cu adevărat din această echipă de elită mai trebuie să demonstrezi că ai nu doar experiență ci și cunoștințe teoretice de nivel înalt.
>
> Prin urmare îți trimit un singur cuvânt pentru care vreau explicații: SOLID. Aștept un răspuns în două ore.

Două sarcini în plus chiar din primele ore a dimineții vă pun pe gânduri despre procesele din echipă însă gradul ridicat de profesionalism vă face să lăsați aceste gânduri pentru altă dată și să alcătuiți următoarea listă de acțiuni:
1. Creați o soluție nouă în Visual Studio (sau Visual Studio Code).
2. Creați un proiect nou în care să implementați o variantă generică pentru `Repository Pattern` folosindu-vă de biblioteca `EntityFramework`.
3. Creați un proiect nou care să conțină clasa `Sample` descrisă mai sus și adăugați implementarea pentru această clasă.
4. Creați alte două proiecte: unul pentru o metodă de extensiune numită `IsValidDnaSequence` și altul pentru testele unitare ale acestei metode. Implementați metoda în stil `TDD` astfel încât metoda să primească un argument de tip `string` și să verifice că:
   1. Secvența conține 1000 caractere și
   2. Caracterele sunt A, C, G sau T.
5. Creați un document în care să explicați principiile SOLID.

## Cerințe ##
1. Faceți fork la acest proiect
2. În fork-ul vostru, creați un director nou cu numele utilizatorului vostru GitHub. Ex: `mkdir numeutilizator`.
3. În directorul `numeutilizator` creați alte două directoare: `docs` și `src`.
4. În directorul `src` implementați sarcinile practice (acțiunile 1-4) aplicând bunele practici discutate în cursurile și laboratoarele anterioare.
5. În directorul `docs` creați un fișier `README.md` și completați textul pentru sarcina teoretică (acțiunea 5) respectând sintaxa markdown. Documentul final trebuie să aibă un titlu și câte o secțiune cu subtitlu și descriere pentru fiecare principiu descris.
6. Sarcinile practice (acțiunile 1-4) trebuie implementate pe platforma `.net core` utilizând limbajul C#.
6. După ce ați completat sarcinile sau la sfârșitul laboratorului creați un pull-request.

## Observații ##
- Pentru cerințele de mai sus trebuie să lucrați exclusiv în timpul alocat laboratorului. Pull-request-ul cu rezolvarea trebuie să fie inițiat înainte de sfârșitul laboratorului.
- Fiecare student va iniția un singur pull-request.
- Pentru a genera o secvență ARN folosiți [Random DNA Sequence Generator](http://faculty.ucr.edu/~mmaduro/random.htm).
