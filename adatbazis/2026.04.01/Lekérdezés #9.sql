-- Az 1950 előtt, Budapesten, Szegeden és Miskolcon született  filmesek nevét
SELECT nev FROM filmes WHERE YEAR(szuldatum) <1950 AND szulhely IN ('Szeged','Miskolc','Budapest');

-- Az 1950 és 2000 között bemutatott legalább 80 perces filmek összes adata
SELECT * FROM film WHERE ev BETWEEN 1950 AND 2000 AND hossz >=80;

-- Azon filmek címe és bemutatási éve, amelyik címe tartalmazza az 'anya' szót
SELECT cim, ev FROM film WHERE cim LIKE '%anya%';

-- Mely stúdiók nevének a második betűje 'u'?
SELECT nev FROM studio WHERE nev NOT LIKE '_u%';

-- Melyek azok a filmek, amelyyeknek nem ismert a rendezője?
SELECT * FROM film WHERE rendezoId IS NULL;

-- 2000 előtt bemutatott filmek címe és stúdiójának neve
SELECT f.cim, s.nev FROM film AS f INNER JOIN studio AS s ON f.studioId=s.id WHERE f.ev<2000; 
-- SELECT film.cim, studio.nev, film.studioId, studio.id FROM film, studio WHERE film.ev<2000 AND film.studioId=studio.id;  -- ez ugyanaz csak hosszabban és körülményesebben

-- 6-tól 14-ig korhatáros filmek címe és rendezőjének neve 
SELECT f.cim, fi.nev FROM film AS f INNER JOIN filmes AS fi ON f.rendezoId=fi.id WHERE f.korhatar BETWEEN 6 AND 14;  

-- Kik játszottak abban a filmben amelynek a címe a 'csacsi' szóra végződik?
SELECT fi.nev FROM filmes AS fi INNER JOIN szerepel AS sz ON fi.id=sz.szineszId INNER JOIN film AS f ON f.id=sz.filmId WHERE f.cim LIKE '%csacsi'; 

-- Az összes film címe, bemutatási éve, rendezőjének és stúdiójának neve
SELECT f.cim, f.ev, fi.nev, s.nev FROM film f LEFT OUTER JOIN filmes fi ON f.rendezoId = fi.id LEFT OUTER JOIN studio AS s ON f.studioId = s.id;

-- Kik rendeztek filmet olyan stúdiónak, amelyik neve H betűvel kezdődik?
SELECT fi.cim FROM filmes AS fi INNER JOIN film AS f ON f.studioId=si.rendezoID WHERE fi.nev LIKE 'H%';

-- mely településeken születtek 1970 előtt filmesek?
SELECT DISTINCT fi.szulhely FROM filmes AS fi WHERE YEAR(fi.szuldatum)<1970;

