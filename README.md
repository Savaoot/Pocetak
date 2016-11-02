# Pocetak
Projekat iz C# za fakultet

# This is the first part of the project for the subject "Platforme za Objektno Programiranje" on OSSSIT faculty department at FTN college.
***
### Platforme za objektno programiranje
### Predmetni projekat
### Školska 2016/2017
***
#### Potrebno je realizovati stand-alone GUI .NET aplikaciju u WPF tehnologiji za administraciju poslovanja škole jezika.
##### Aplikacija treba da omogući administraciju:
1. Podataka o školi
	*  Evidentira se naziv, adresa, telefon, email, adresa internet sajta, PIB, matični broj i broj žiro računa.
2. Nastavnika
	* Za nastavnike se evidentiraju lični podaci
3. Učenika
	* Za učenike se evidentiraju lični podaci
4. Kurseva
	* Za svaki kurs se evidentira koji se jezik uči, koji je tip kursa (nivo jezika), cena kursa, učenici koji pohađaju kurs i nastavnik koji ga predaje.
5. Uplata
	* Potrebno je evidentirati svaku uplatu učenika za pohađanje kursa.
6. Korisnika aplikacije
	* Evidentiraju se osobe koje imaju pravo da koriste aplikaciju. Postoje dva tipa korisnika aplikacije - administrator i zaposleni.

Administracija navedenih podataka podrazumeva pregled, unos, izmenu i brisanje podataka.
Sva brisanja su logička (element se proglašava neaktivnim, a ne uklanja se fizički).

Aplikaciju može koristiti samo ulogovani korisnik.
Podatke o školi, nastavnike i korisnike ažurira administrator.
Zaposleni je zadužen za evidenciju učenika, kurseva i uplata.

Za sve navedene entitete, pri prikazu je potrebno omogućiti:

1. Sortiranje po svakom od entiteta.
2. Pretragu podataka.
	* Nastavnike i učenike je moguće pretraživati po imenu, prezimenu i jmbg.
	* Korisnike je moguće pretraživati po imenu, prezimenu i korisničkom imenu.
	* Kurseve je moguće pretraživati po jeziku i tipu.
	* Uplate je potrebno pretraživati po kursu i učeniku.
	
Perzistenciju podataka realizovati korišćenjem relacione baze podataka.
