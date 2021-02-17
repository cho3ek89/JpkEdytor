# JPK Edytor
**JPK Edytor** jest aplikacją umożliwiającą podgląd, tworzenie oraz edycję Jednolitych Plików Kontrolnych.
Obsługiwane są następujące typy plików:
 - JPK_V7K *(wersja 1)*
 - JPK_V7M *(wersja 1)*
 - JPK_VAT *(wersja 3)*
 - JPK_EWP *(wersje: 2, 1)*
 - JPK_FA *(wersje: 3, 2)*
 - JPK_FA_RR *(wersja 1)*
 - JPK_KR *(wersja 1)*
 - JPK_MAG *(wersja 1)*
 - JPK_PKPiR *(wersja 2)*
 - JPK_WB *(wersja 1)*

## Wymagania aplikacji
 - Microsoft Windows 7 lub nowszy
 - Microsoft .NET Framework 4.5 lub nowszy ([pobierz](https://dotnet.microsoft.com/download/dotnet-framework))

## Instrukcja obsługi

### Tworzenie pliku JPK
Z głównego menu aplikacji należy wybrać kolejno:\
**Plik** &rightarrow; **Nowy** &rightarrow; **Typ pliku JPK**

### Otwieranie pliku JPK
Z głównego menu aplikacji należy wybrać kolejno:\
**Plik** &rightarrow; **Otwórz** &rightarrow; **Typ pliku JPK**\
W oknie *„Otwieranie”* najeży wybrać plik JPK oraz nacisnąć przycisk *„Otwórz”*.

### Podgląd pliku JPK
Widok każdego nowo utworzonego bądź otwartego pliku JPK jest podzielony na karty, na przykład: *„Nagłówek”*, *„Podmiot”*, *„Dochody”*, *„Spis z natury”*, *„Przychody i rozchody”* w przypadku pliku JPK_PKPIR *(wersja 2)*. W celu przełączenia się z jednej karty na drugą należy kliknąć w nagłówek karty zawierający jej nazwę, na przykład *„Spis z natury”*.

Niektóre karty widoku pliku JPK zawierają arkusz, na przykład karta *„Spis z natury”* widoku pliku JPK_PKPIR *(wersja 2)*. Najechanie kursorem myszy na nagłówek kolumny niniejszego arkusza (na przykład: *„Data spisu”*) spowoduje wyświetlenie się po ułamku sekundy dymka zawierającego opis danej kolumny. Kliknięcie kursorem myszy na nagłówek kolumny arkusza spowoduje posortowanie wierszy arkusza względem tej kolumny.

Niektóre komórki arkusza mogą mieć *szary* kolor czcionki – dzieje się tak kiedy są one nieobowiązkowe oraz zawierają wartości domyślne lub gdy nie są spełnione inne warunki. Takie komórki nie znajdą się w wynikowym pliku JPK.

### Edycja pliku JPK

#### Edycja danych w arkuszach
Z prawej strony każdego wiersza arkusza znajduje się przycisk „**-**”, kliknięcie go spowoduje usunięcie danego wiersza. W dole arkusza, z prawej strony znajduję przycisk „**+**”, kliknięcie go spowoduje dodanie nowego wiersza na końcu arkusza.

#### Importowanie danych do arkuszy z plików CSV
Aby aplikacja poprawnie wczytała plik CSV, powinien on:
 - używać kodowania **UTF-8**
 - używać znaku „**;**” jako separatora pól
 - być zgodny ze specyfikacją standardu pliku CSV
 - posiadać liczbę i kolejność kolumn odpowiadającą liczbie i kolejności kolumn w arkuszu, do którego ten plik ma być zaimportowany
 - zawierać tylko dane (wiersz z nazwami kolumn nie powinien być obecny)
 - posiadać daty zapisane w formacie *rrrr-mm-dd*, na przykład: **2019-04-27**
 - wartości typu &#9746;/&#9744; powinny być zapisane jako: **true**/**false**
> Możliwość zapisu oraz edycji plików CSV posiada na przykład program Microsoft Excel.

Aby zaimportować plik CSV do arkusza w aplikacji należy z głównego menu aplikacji należy wybrać kolejno:\
**Plik** &rightarrow; **Importuj CSV** &rightarrow; **Nazwa karty widoku pliku JPK, która zawiera arkusz**\
W oknie *„Otwieranie”* najeży wybrać plik CSV oraz nacisnąć przycisk *„Otwórz”*.

> Przykładowa zawartość pliku CSV, który może zostać zaimportowany do arkusza „*Sprzedaż*” pliku JPK_V7K *(wersja 1)* lub JPK_V7M *(wersja 1)*:
> 
>     ;1190217475;Magazyn s.c.;536/22346;2020-06-14;0001-01-01;;1;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;1;0;0;0;0;0;0;0;0;0;0;24352,17;596,09;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0
>     PL;3796700710;Asfaltownia sp. z o.o.;426/88343;2020-06-14;2020-07-02;Ro;0;0;0;1;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;1;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;624562,08;63456,95;0;0;0;0;0;0;0;0;0;0;0;0;1230,55
> Przykładowa zawartość pliku CSV, który może zostać zaimportowany do arkusza „*Zakupy*” pliku JPK_V7K *(wersja 1)* lub JPK_V7M *(wersja 1)*:
> 
>     ;8114066171;Firma s.a.;345/74433;2020-08-06;0001-01-01;;0;0;5252,51;662,20;0;0;0;0;0;0;0
>     PL;5692926146;Fabryka s.c.;216/63645;2020-09-06;2020-09-07;Wew;0;0;0;0;5843,36;986,49;0;0;0;0;127,91

### Walidacja pliku JPK
Aby przeprowadzić walidację nowo utworzonego bądź otwartego pliku JPK pod kątem poprawności merytorycznej z głównego menu aplikacji należy wybrać kolejno:\
**Plik** &rightarrow; **Waliduj**\
W przypadku wykrycia błędów walidacji zostanie wyświetlone okno „Błędy walidacji” zawierające wszystkie błędy walidacji pliku JPK.
W przypadku pomyślnej walidacji stosowny komunikat również zostanie wyświetlony.

### Zapisywanie pliku JPK
Z głównego menu aplikacji należy wybrać kolejno:\
**Plik** &rightarrow; **Zapisz**\
W oknie *„Zapisywanie jako”* należy wybrać plik JPK do nadpisania bądź podać nazwę nowego pliku, następnie nacisnąć przycisk *„Zapisz”*.
