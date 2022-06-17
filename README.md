# Grupa2-Poliklinika
## Članovi tima:
- Kanita Hadžić
- Mirela Kurtović
- Medina Kazić

## Opis teme:
- Svjesni smo koliko je dobra organizacija zdravstvenih ustanova, klinika i poliklinika važna za normalno funkcionisanje društva, pogotovo u vrijeme pandemije koja je zadesila cijeli svijet. Stoga je ova aplikacija razvijena u svrhu lakše organizacije rada poliklinike. Glavni cilj aplikacije jeste omogućiti doktorima bolju organizaciju rada i koordinaciju pacijentima. Također, cilj aplikacije jeste i da omogući pacijentima jednostavan pristup, uvid i odabir medicinskih usluga koje poliklinika nudi.

## Funkcionalni zahtjevi:
- Doktori:
  - Registracija/prijava na profil sa vlastitim pristupnim podacima i unosom odjela na kojem je dotični doktor zaposlen.
  - Kreiranje i ažuriranje rasporeda termina.
  - Ukoliko je došlo do promjene u rasporedu termina, a dati termin je vec zakazao pacijent, potrebno je da pacijent dobije obavjestenje o takvoj akciji.
  - Pristup i ažuriranje medicinskog kartona pacijenta.
  - Izdavanje elektronskih recepata i nalaza, te slanje istih pacijentu na mail.
  - Ukoliko je jedan od doktora ujedno i direktor poliklinike on ima pravo da nadgleda određene aktivnosti kako doktora tako i pacijenata. Direktor poliklinike ima pravo da pristupi rasporedu termina svakog doktora kako bi pratio njihov aktivan rad, da postavi obavijest na aplikaciju ukoliko se ona tiče cijelog kolektiva poliklinike ili da obavijest pošalje u vidu maila ukoliko se ona tiče samo pojedinih uposlenika. Direktor poliklinike mora imati uvid u broj pacijenata novih pacijenata, kao i u broj pacijenata koji su svoje aktivnosti u poliklinici završili tako da ukoliko se desi jedna od ovih akcija direktoru mora doći obavještenje o istoj.
- Pacijenti:
  - Registracija profila sa vlastitim podacima pri čemu se kreira i medicinski karton pacijenta
  - Nakon odabira doktora i usluge, medicinski karton se pridružuje u "kartoteku" odabranog doktora.
  - Pristup rasporedu termina odabranog doktora i odabir željenog termina.
  - Ukoliko pacijent otkaže termin potrebno je poslati obavještenje doktoru (na mail?) o izvršenoj akciji.
  - Pohranjivanje svih elektronskih recepata i nalaza u PDF formatu na računar/telefon, kao i printanje istih.
  - Samostalno brisanje profila ukoliko je pacijent završio svoje aktivnosti u poliklinici čime se briše i njegov medicinski karton.

## Nefunkcionalni zahtjevi:
- Recepte i nalaze mogu izdavati samo doktori onim pacijentima koji se vode njihovim kartotekama.
- Doktori ne mogu imati uvid u kartoteke svojih kolega niti mogu ažurirati informacije u istim, osim ako se ne desi situacija da imaju istog pacijenta.
- Pacijenti samo mogu birati termine koji se nalaze u rasporedu termina, a sva ažuriranja i mijenjanje rasporeda vrši medicinsko osoblje. 
- Ukoliko je doktor promijenio vrijeme termina kojeg je neki pacijent već zakazao, automatski se šalje obavještenje na mail pacijentu u roku od 1 do 2 minute. 
- Termin je moguće zakazati u toku radnog vremena poliklinike (od 8:00 do 17:00) kako bi doktori mogli organizovati svoje radno vrijeme.
- Korisnici aplikacije (pacijenti) će imati niži nivo pristupa sistemu i mogu pristupiti samo vlastitim podacima dok zaposlenici (doktori) će imati autorizaciju za   pristup podacima klijenata i svojih podataka.
	
- Lični podaci korisnika aplikacije su zaštićeni poštujući zakon o zaštiti ličnih podataka.
- Aplikaciji će moći pristupiti korisnici svih operativnih sistema.
- Aplikacija će biti prilagođena svim veličinama ekrana (desktop računari, laptopi, mobiteli, tableti), bit će responzivna.
- Aplikacija treba da bude aktivna i funkcionalna bez nekih većih problema 0-24 svim danima u godini.
- Aplikacija grantuje tačnost podataka i zaštitu podataka svih korisnika od zloupotrebe.
    
## Akteri:
- Doktori 
- Pacijenti
- Direktor poliklinike

# Vanjski uređaj: upload i printanje PDF dokumenta 
# Asinhronosti: automatsko slanje e-maila ukoliko se desila neka promjena vezana za termin

