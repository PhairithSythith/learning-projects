repulojegy_foglalo-- Módosítások (új adat felvitel, meglévő adat módosítása, törlés)
-- INSERT INTO film (cim, ev, hossz, rendezoId) VALUES ('Varázsceruza', 1980, 80, 1);
 /* INSERT INTO filmes (nev, szuldatum, szulhely) VALUES ('Mekk Elek', 1999-01-01,
 'Kecskemét');
INSERT INTO szerepel (szerep, szineszId, filmId)
VALUES ('Kecske', 14, 8); */

-- Varázsceruza költsége legyen 100 millió
-- UPDATE film SET koltseg=100 WHERE id=8;

-- Állítsuk 0-ra a korhatárt
-- UPDATE film SET korhatar=0 WHERE korhatar=NULL;

-- Törlöld a Varázsceruza filmet
DELETE FROM szerepel WHERE id=15;
DELETE FROM film WHERE id=8;
