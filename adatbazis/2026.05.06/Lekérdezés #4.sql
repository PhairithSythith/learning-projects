-- Melyik színész mikor játszott legkorábban filmben?
/*SELECT fi.nev, fi.id, MIN(f.ev) AS legkorabbi_ev FROM filmes AS fi INNER JOIN szerepel 
AS sz ON sz.szineszId = fi.id INNER JOIN film AS f ON f.id = sz.filmId
GROUP BY fi.nev, fi.id; */

-- Melyik a legkorábban bemutatott film?
/*SELECT f.id, f.cim, f.ev FROM film AS f WHERE f.ev = (SELECT MIN(ev) FROM film);*/

-- Ki a legidősebb Budapesten született filmes?
/*SELECT fi.nev FROM filmes AS fi WHERE fi.szulhely = 'Budapest' AND fi.szuldatum =
(SELECT MIN(szuldatum) FROM filmes WHERE szulhely = 'Budapest');*/

-- Kik rendeztek legalább 10 milliós filmet? 
/*SELECT DISTINCT fi.nev, fi.id FROM filmes AS fi INNER JOIN film AS f ON 
f.rendezoId = fi.id WHERE f.koltseg >= 10;*/

-- Kik rendeztek legalább 10 milliós filmet? (Nem használható tábla összekapcsolás)
/*SELECT DISTINCT fi.nev FROM filmes AS fi WHERE fi.id IN 
(SELECT f.rendezoId FROM film AS f WHERE 
f.koltseg >= 10);*/

-- Kik azok akik rendeztek is és szerepeltek is filmben?
/*SELECT fi.nev FROM filmes AS fi WHERE fi.id IN (SELECT rendezoId FROM film)
AND fi.id IN (SELECT szineszId FROM szerepel);*/

-- Melyek azok a filmek amelyekben nem játszik senki?
/*SELECT f.cim FROM film AS f WHERE f.id NOT IN (SELECT filmId FROM szerepel);*/