# Robot VS. Human tāla veidošanas spēle

## Projekta apraksts

Šī ir interaktīva tēla veidošanas spēle, kurā lietotājs var izvēlēties tēlu, pielāgot tā izskatu, apģērbu un izmērus, kā arī apskatīt aprakstu par izvēlēto varoni.

Projektā ir iekļautas divas ainas:
- **Main** - sākuma aina
- **Alley** - tēla veidošanas aina

---

## 1. Sākuma aina (Main)

Sākuma ainā lietotājam ir pieejamas divas pogas:

- **START** - pāriet uz tēla veidošanas ainu
- **X (Exit)** - aizver projektu

Ir nodrošināta iespēja pārslēgties starp abām ainām.

---

## 2. Tēla informācijas ievade

Tēla veidošanas ainā ir pieejami divi ievades lauki:

- **Name** - tēla vārda ievade
- **Birth Year** - dzimšanas gada ievade (iespējams ievadīt tikai skaitļus)

Pēc datu ievades un pogas nospiešanas tiek attēlots teksts ar aprēķināto vecumu.

Piemērs:
> "Supervaronis Oskars ir 25 gadus vecs!"

Vecums tiek aprēķināts, izmantojot aktuālo gadu.

PS: Tākā spēlē tiek izmantos Robots no nākotnes, ir iespējams aprēķināt nākotnes "negatīvu" vecumu!

---

## 3. Tēla izvēle (Dropdown)

Izmantojot izkrītošo sarakstu (Dropdown), iespējams izvēlēties starp vismaz diviem tēliem:
- Robot
- Human

Mainot tēlu:
- Nomainās tēla attēls
- Atskaņojas atbilstošs skaņas efekts
- Scroll View tiek nomainīts tēla apraksts

---

## 4. Apģērbu un aprīkojuma kategorijas

Spēlē ir izveidotas vairākas kategorijas:

- Helmets
- Jackets
- Pants

Katra kategorija satur vismaz trīs apģērba elementus.

Ar Toggle palīdzību iespējams:
- Parādīt izvēlēto kategoriju
- Paslēpt izvēlēto kategoriju

---

## 5. Apģērba izvēle

Katras kategorijas ietvaros:

- Uzklikšķinot uz mazā attēla
- Attiecīgais apģērba gabals tiek uzlikts tēlam

Apģērba attēls mainās, saglabājot Toggle iestatīto redzamības stāvokli.

---

## 6. Drag and Drop funkcionalitāte

Izvēlēto aprīkojumu iespējams:

- Ar peles palīdzību pārvietot
- Novietot izvēlētajā vietā uz tēla

Tiek izmantots drag and drop princips.

---

## 7. Skaņas efekti

Projektā ir nodrošināti skaņas efekti:

- Pogas klikšķi
- Tēla maiņas skaņas
- Fona mūzika

Skaņas tiek atskaņotas atbilstošos lietotāja darbības brīžos.

---

## 8. Scroll View ar tēla aprakstu

Ainā ir ievietots Scroll View elements, kurā iespējams izlasīt informāciju par izvēlēto tēlu.

Mainot tēlu:
- Apraksts automātiski tiek atjaunināts

---

## 9. Tēla izmēru maiņa (Sliders)

Ir pieejami divi Slider elementi:

- Viens maina tēla platumu
- Otrs maina tēla garumu

Slider vērtība tiek interpretēta procentos:
- 100% - sākotnējais izmērs
- Zem 100% - samazināts izmērs
- Virs 100% - palielināts izmērs

---

## Vadības instrukcija

1. Atveriet projektu.
2. Nospiediet **START**, lai uzsāktu spēli.
3. Ievadiet vārdu un dzimšanas gadu.
4. Izvēlieties tēlu.
5. Pielāgojiet apģērbu kategorijas ar Toggle.
6. Izvēlieties apģērbu elementus.
7. Pārvietojiet tos ar drag and drop.
8. Mainiet tēla izmērus ar Slider palīdzību.
9. Izlasiet tēla aprakstu Scroll View sadaļā.

---

## Autors

Dainis Ābols

