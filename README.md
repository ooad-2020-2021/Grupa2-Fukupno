<h1 align="center">Grupa2-Fukupno</h1>
<h1 align="center">TuT.ba</h1>

![Logo](https://i.postimg.cc/3w5bLSby/Prava-Verz.jpg)


**Završen deployment aplikacije i stranici možete pristupiti preko sljedećeg linka**
+[Web stranica](http://ahadzic7-001-site1.itempurl.com/)

------
### Članovi: 

1. [Samra Behić](https://github.com/Samra17)
2. [Armin Hadžić](https://github.com/ahadzic7)
3. [Irvin Ćatić](https://github.com/icatic1)


------
## Namjena sistema:

Aplikacija za pomoć pri savladavanju predmeta sa ETF-a („TuT.ba“) nudi podšku za:
* pronalazak tutora specijaliziranih u određenim oblastima 
* dogovor on-line/on-site instrukcija i konsultacija
* pronalazak preporučene literature
* mogućnost da budete i Vi tutor.

Namjena sistema je savremen i pojednostavljen pristup materijalima, te osobama koje su u mogućnosti pružiti pomoć pri učenju, shvatanju i samom polaganju predmeta sa ETF-a.
Instrukcije i konsultacije su omogućene ukoliko postoji osoba koja je prijavljena kao tutor na predmetu. Ukoliko takva ne postoji, moguće je pronaći literaturu za traženi predmet, koja može biti besplatna ili plaćena.
Osoba ne mora biti registrirana kako bi vidjela interfejs aplikacije, međutim u tom slučaju ima pravo vidjeti samo osnovne informacije o sistemu, odnosno šta dati sistem nudi. 
Osoba se može registrovati kao student ili kao tutor.

## Akteri:

* administrator
* student
* tutor


##  Prikaz funkcionalnih i nefunkcionalnih zahtjeva:

![dijagram](https://i.postimg.cc/TYZyhFPH/dijagram.jpg)

**ADMINISTRATOR:**
* kontrola tutora koji su prijavljeni na stranici
* kontrola predmeta koji su dostupni na stranici
* kontrola materijala koji su dostupni na stranici
* kontrola novododanih materijala i novoprijavljenih tutora
* prijava za tutora mora proći provjeru kod administratora 
* dodavanje novih materijala mora proći kroz provjeru kod administratora
* mogućnost dodavanja kredita na bankovne kartice

**STUDENT:**
* prijava/registracija na sistem sa svojim pristupnim podacima
* plaćanje karticom (asinhron proces)
* uvid u predmete, za koje sistem pruža podršku, tutore na tim predmetima, kao i ocjenu tutora
* uvid u aktuelne akcije, odnosno popuste, ili neki pakete, oni će biti prikazani studentu na naslovnoj stranici
* prijava za instrukcije iz bilo kojeg predmeta na kojem postoji tutor, te slobodan termin za prijavu
* uvid u literaturu/materijale na stranici
* ukoliko su omogućene on-site instrukcije, student mora prihvatiti i pročitati COVID – protokol
* mogućnost ocjenjivanja tutora nakon instrukcija 
* filtriranje/sortiranje tutora po ocjeni ili cijeni (algoritam)
* upload i download materijala na stranici
* pronalazak GPS lokacije održavanja instrukcija (vanjski uređaj)

**TUTOR:**
* prijava/registracija na sistem sa svojim pristupnim podacima. Pri registraciji, pored ličnih informacija, tutor odabire predmete (ponuđeni od strane administratora), te postavlja cijenu jednog časa svojih instrukcija
* mogućnost prijave na više predmeta
* svaki tutor ima svoju ocjenu (prosječna ocjena svih studenata koji su slušali njegove instrukcije)
* modifikacija termina za instrukcije, kako pri registraciji, tako i naknadno
* odjava sa svih predmeta, isključivo ako ne postoje zakazane instrukcije za dati predmet
* uvid u ocjene koje je dobio od strane studenata
* mogućnost dodavanja načina realizacije instrukcija :
	1. UŽIVO
	1. ONLINE
	1. UŽIVO/ONLINE
* ukoliko su omogućene instrukcije uživo, tutor mora prihvatiti i pročitati COVID – protokol (u slučaju promjene vlastitog zdravstvenog stanja, tutor je dužan obustaviti instrukcije uživo)
* mogućnost dodavanja posebnih popusta ili paketa za više predmeta samo ako on drži sve predmete u paketu 
* upload i download materijala na stranici
* omogućavanje GPS lokacije u slučaju instrukcija uživo (vanjski uređaj)



**Nefunkcionalni zahtjevi:**

* validacija unesenih podataka pri registraciji (forma lozinke, nemogućnost korištenja korisničkog imena koji postoji već u sistemu... )
* potvrda o dovoljnoj naknadi na kartici prije ugovaranja termina instrukcija
* zabranjeni termini održavanja instrukcija nakon 22h i prije 7h
* zabranjeno otkazivanje termina od strane studenta 24h prije početka istog
