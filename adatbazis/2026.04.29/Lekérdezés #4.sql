-- Mely színészek játszottak 6-14 korhatárú filmben?
/* SELECT DISTINCT fi.nev, fi.id FROM filmes AS fi INNER JOIN szerepel 
AS sz ON fi.id = sz.szineszId INNER JOIN film AS f ON sz.filmId = f.id WHERE
f.korhatar BETWEEN 6 AND 14; */

-- Gyűjtsük ki a magyarországi stúdiók összes adatát név szerint ábécé sorrendben
/* SELECT * FROM studio AS s WHERE s.orszag='Magyarország' ORDER BY s.nev ASC; */

-- Gyűjtsük ki  az összes legalább 80 perces film címét
-- amelyben játszott Koltai Róbert bemutatási év szerint csökkenő sorrendben
/* SELECT distinct f.cim, f.id FROM film AS f INNER JOIN szerepel AS sz ON f.id=sz.filmId 
INNER JOIN filmes AS fi ON sz.szineszId=fi.id WHERE f.hossz>=80 
AND fi.nev ='Koltai Róbert' ORDER BY f.ev DESC; */

-- Hány darab filmet gyártatottak 2000 előtt?
/* SELECT COUNT(*) AS filmek_szama_2000_elott FROM film WHERE ev<2000; */

-- Átlagosan mennyibe kerül egy Magyar Televízió által gyártott film?
/* SELECT AVG(f.koltseg) AS atlag_ar FROM film AS f INNER JOIN studio AS s 
ON f.studioId=s.id WHERE s.nev='Magyar Televízió'; */

-- Hány stúdió gyártott filmet 1980 előtt?
/* SELECT COUNT(DISTINCT s.id) AS studiok_amik_1980_elott_gyartottak_filmet FROM 
studio AS s INNER JOIN film AS f ON f.studioId=s.id WHERE f.ev<1980; */
/* így is lehetett volna: 
 SELECT COUNT(DISTINCT f-studioID) AS studiok_amik_1980_elott_gyartottak_filmet FROM 
film AS f  WHERE f.ev<1980;
*/

-- Melyik településen mennyi filmes született?
/* SELECT fi.szulhely, COUNT(*) FROM filmes AS fi GROUP BY fi.szulhely; */

-- melyik évben összesen mennyit költöttek filmm gyártásra?
/* SELECT f.ev, SUM(f.koltseg) AS evente_koltseg FROM film AS f GROUP BY f.ev
ORDER BY f.ev; */

-- Melyik stúdiónak mennyibe került a legköltségesebb, legfeljebb 12 korhatárú
-- filmje?
SELECT s.nev, MAX(f.koltseg) AS legdragabb_film_12_korhatarig FROM film AS f
INNER JOIN studio AS s ON f.studioId=s.id WHERE f.korhatar<=12 GROUP BY
s.id, s.nev;
