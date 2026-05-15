/*LEKÉRDEZÉSEK*/

-- 1 tárolt filmek és bemutatási évük
SELECT ev, cim FROM film;

-- 2 filmek összes adat
SELECT * FROM film;

-- 3 filmek címe és költsége
SELECT cim AS 'filmcím', koltseg*1000000 As 'költség', 'forint' FROM film; -- *100000 lehet használni műveleteket és 'forint' (literál) amivel írni lehet az eredménybe bele

-- 4 filmesek neve születési éve és helye
SELECT nev, YEAR(szuldatum), szulhely FROM filmes; -- függvény használata

-- 5 melyek a 1990 óta bemutatott filmek címei
SELECT cim FROM film WHERE ev>=1990;

-- 6 Kik a nem  Budapesten született legalább 50 éves filmek?
SELECT nev FROM filmes WHERE szulhely <>'Budapest' AND YEAR(CURDATE())-YEAR(szuldatum)>=50;

-- 7 melyek a legalább 80 perces 12 és 14 korhatarú filmek
SELECT * FROM film WHERE (korhatar=12 OR korhatar=14) AND hossz>=80; -- a műveleti sorrendre figyelni kell!
/*vaaaaagy: SELECT * FROM film WHERE korhatar IN (12, 14) AND hossz>=80*/
