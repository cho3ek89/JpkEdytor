# JPK Edytor
**JPK Edytor** jest aplikacją umożliwiającą podgląd, tworzenie oraz edycję Jednolitych Plików Kontrolnych.
Obsługiwane są następujące typy plików:
 - JPK_VAT *(wersja 3)*
 - JPK_EWP *(wersja 1)*
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

> Przykładowa zawartość pliku CSV, który może zostać zaimportowany do arkusza „*Spis z natury*” pliku JPK_PKPiR *(wersja 2)*:
> 
>     "2019-11-23";"8514,83" 
>     "2019-11-29";"-4442,27"

### Walidacja pliku JPK
Aby przeprowadzić walidację nowo utworzonego bądź otwartego pliku JPK pod kątem poprawności merytorycznej z głównego menu aplikacji należy wybrać kolejno:\
**Plik** &rightarrow; **Waliduj**\
W przypadku wykrycia błędów walidacji zostanie wyświetlone okno „Błędy walidacji” zawierające wszystkie błędy walidacji pliku JPK.
W przypadku pomyślnej walidacji stosowny komunikat również zostanie wyświetlony.

### Zapisywanie pliku JPK
Z głównego menu aplikacji należy wybrać kolejno:\
**Plik** &rightarrow; **Zapisz**\
W oknie *„Zapisywanie jako”* należy wybrać plik JPK do nadpisania bądź podać nazwę nowego pliku, następnie nacisnąć przycisk *„Zapisz”*.
