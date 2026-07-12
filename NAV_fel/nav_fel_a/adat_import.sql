/* Figyelmeztetés: (1261) Row 2 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 2 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 2 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 3 */
/* Figyelmeztetés: (1261) Row 3 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 3 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 3 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 4 */
/* Figyelmeztetés: (1261) Row 4 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 4 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 4 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 5 */
/* Figyelmeztetés: (1261) Row 5 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 5 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 5 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 6 */
/* Figyelmeztetés: (1261) Row 6 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 6 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 6 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 7 */
/* Figyelmeztetés: (1261) Row 7 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 7 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 7 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 8 */
/* Figyelmeztetés: (1261) Row 8 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 8 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 8 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 9 */
/* Figyelmeztetés: (1261) Row 9 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 9 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 9 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 10 */
/* Figyelmeztetés: (1261) Row 10 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 10 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 10 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 11 */
/* Figyelmeztetés: (1261) Row 11 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 11 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 11 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 12 */
/* Figyelmeztetés: (1261) Row 12 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 12 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 12 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 13 */
/* Figyelmeztetés: (1261) Row 13 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 13 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 13 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 14 */
/* Figyelmeztetés: (1261) Row 14 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 14 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 14 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 15 */
/* Figyelmeztetés: (1261) Row 15 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 15 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 15 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'ESST_ID' at row 16 */
/* Figyelmeztetés: (1261) Row 16 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 16 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 16 doesn't contain data for all columns */
SET FOREIGN_KEY_CHECKS = 1;
SHOW WARNINGS;
/* Érintett sorok: 136 869  Talált sorok: 64  Figyelmeztetés: 65 538  Időtartam 8 lekérdezések: 1,515 mp. */
/* Could not determine name of table. */
USE `nav_fel_e`;
SET FOREIGN_KEY_CHECKS = 0;
-- 1. TÖRLÉS
TRUNCATE TABLE `nav_fel_e`.`szamla`;
TRUNCATE TABLE `nav_fel_e`.`gazdmut`;
-- 2. GAZDASÁGI MUTATÓK IMPORTÁLÁSA
LOAD DATA LOCAL INFILE 'C:\\Users\\ritzo\\Desktop\\nav_fel\\gazdmut.csv' 
REPLACE INTO TABLE `nav_fel_e`.`gazdmut` 
CHARACTER SET utf8mb4 
FIELDS TERMINATED BY ','                 -- Átírva pontosvesszőről vesszőre
OPTIONALLY ENCLOSED BY '"' 
LINES TERMINATED BY '\r\n'               -- Visszaállítva a Windows soremelésre
IGNORE 1 LINES 
(AA_AZON, VALLALATMERET, TEAOR_KATEGORIA);
SHOW WARNINGS;
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 1 */
/* Figyelmeztetés: (1261) Row 1 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 1 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 2 */
/* Figyelmeztetés: (1261) Row 2 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 2 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 3 */
/* Figyelmeztetés: (1261) Row 3 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 3 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 4 */
/* Figyelmeztetés: (1261) Row 4 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 4 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 5 */
/* Figyelmeztetés: (1261) Row 5 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 5 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 6 */
/* Figyelmeztetés: (1261) Row 6 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 6 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 7 */
/* Figyelmeztetés: (1261) Row 7 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 7 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 8 */
/* Figyelmeztetés: (1261) Row 8 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 8 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 9 */
/* Figyelmeztetés: (1261) Row 9 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 9 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 10 */
/* Figyelmeztetés: (1261) Row 10 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 10 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 11 */
/* Figyelmeztetés: (1261) Row 11 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 11 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 12 */
/* Figyelmeztetés: (1261) Row 12 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 12 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 13 */
/* Figyelmeztetés: (1261) Row 13 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 13 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 14 */
/* Figyelmeztetés: (1261) Row 14 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 14 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 15 */
/* Figyelmeztetés: (1261) Row 15 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 15 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 16 */
/* Figyelmeztetés: (1261) Row 16 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 16 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 17 */
/* Figyelmeztetés: (1261) Row 17 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 17 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 18 */
/* Figyelmeztetés: (1261) Row 18 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 18 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 19 */
/* Figyelmeztetés: (1261) Row 19 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 19 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 20 */
/* Figyelmeztetés: (1261) Row 20 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 20 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 21 */
/* Figyelmeztetés: (1261) Row 21 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 21 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 22 */
-- 3. SZÁMLA IMPORTÁLÁSA
-- (Feltételezve, hogy a szamla.csv felépítése is hasonló, azaz vesszővel elválasztott)
LOAD DATA LOCAL INFILE 'C:\\Users\\ritzo\\Desktop\\nav_fel\\szamla.csv' 
REPLACE INTO TABLE `nav_fel_e`.`szamla` 
CHARACTER SET utf8mb4 
FIELDS TERMINATED BY ','                 -- Átírva pontosvesszőről vesszőre
OPTIONALLY ENCLOSED BY '"' 
LINES TERMINATED BY '\r\n' 
IGNORE 1 LINES 
(ESST_ID, X_BRUTTO_HUF, KATEGORIA, V_ADOSZAM_TORZSSZAM_DEP);
SHOW WARNINGS;
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 1 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 2 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 3 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 4 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 5 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 6 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 7 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 8 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 9 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 10 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 11 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 12 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 13 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 14 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 15 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 16 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 17 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 18 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 19 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 20 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 21 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 22 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 23 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 24 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 25 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 26 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 27 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 28 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 29 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 30 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 31 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 32 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 33 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 34 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 35 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 36 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 37 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 38 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 39 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 40 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 41 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 42 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 43 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 44 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 45 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 46 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 47 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 48 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 49 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 50 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 51 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 52 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 53 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 54 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 55 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 56 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 57 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 58 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 59 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 60 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 61 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 62 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'egyeb' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 63 */
/* Figyelmeztetés: (1366) Incorrect integer value: 'konyvel' for column `nav_fel_e`.`szamla`.`V_ADOSZAM_TORZSSZAM_DEP` at row 64 */
SET FOREIGN_KEY_CHECKS = 1;
SHOW WARNINGS;
/* Érintett sorok: 137 804  Talált sorok: 64  Figyelmeztetés: 68 340  Időtartam 8 lekérdezések: 1,984 mp. */
/* Could not determine name of table. */
SHOW CREATE TABLE `nav_fel_e`.`gazdmut`;
SHOW CREATE TABLE `nav_fel_e`.`szamla`;
USE `nav_fel_e`;
SET FOREIGN_KEY_CHECKS = 0;
-- 1. TÖRLÉS
TRUNCATE TABLE `nav_fel_e`.`szamla`;
TRUNCATE TABLE `nav_fel_e`.`gazdmut`;
-- 2. GAZDASÁGI MUTATÓK IMPORTÁLÁSA
LOAD DATA LOCAL INFILE 'C:\\Users\\ritzo\\Desktop\\nav_fel\\gazdmut.csv' 
REPLACE INTO TABLE `nav_fel_e`.`gazdmut` 
CHARACTER SET utf8mb4 
FIELDS TERMINATED BY ',' 
OPTIONALLY ENCLOSED BY '"' 
LINES TERMINATED BY '\r\n' 
IGNORE 1 LINES 
(AA_AZON, VALLALATMERET, TEAOR_KATEGORIA);
SHOW WARNINGS;
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 1 */
/* Figyelmeztetés: (1261) Row 1 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 1 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 2 */
/* Figyelmeztetés: (1261) Row 2 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 2 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 3 */
/* Figyelmeztetés: (1261) Row 3 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 3 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 4 */
/* Figyelmeztetés: (1261) Row 4 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 4 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 5 */
/* Figyelmeztetés: (1261) Row 5 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 5 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 6 */
/* Figyelmeztetés: (1261) Row 6 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 6 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 7 */
/* Figyelmeztetés: (1261) Row 7 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 7 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 8 */
/* Figyelmeztetés: (1261) Row 8 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 8 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 9 */
/* Figyelmeztetés: (1261) Row 9 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 9 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 10 */
/* Figyelmeztetés: (1261) Row 10 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 10 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 11 */
/* Figyelmeztetés: (1261) Row 11 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 11 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 12 */
/* Figyelmeztetés: (1261) Row 12 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 12 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 13 */
/* Figyelmeztetés: (1261) Row 13 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 13 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 14 */
/* Figyelmeztetés: (1261) Row 14 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 14 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 15 */
/* Figyelmeztetés: (1261) Row 15 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 15 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 16 */
/* Figyelmeztetés: (1261) Row 16 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 16 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 17 */
/* Figyelmeztetés: (1261) Row 17 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 17 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 18 */
/* Figyelmeztetés: (1261) Row 18 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 18 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 19 */
/* Figyelmeztetés: (1261) Row 19 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 19 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 20 */
/* Figyelmeztetés: (1261) Row 20 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 20 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 21 */
/* Figyelmeztetés: (1261) Row 21 doesn't contain data for all columns */
/* Figyelmeztetés: (1261) Row 21 doesn't contain data for all columns */
/* Figyelmeztetés: (1265) Data truncated for column 'AA_AZON' at row 22 */
-- 3. SZÁMLA IMPORTÁLÁSA (Megcserélt oszlopsorrenddel!)
LOAD DATA LOCAL INFILE 'C:\\Users\\ritzo\\Desktop\\nav_fel\\szamla.csv' 
REPLACE INTO TABLE `nav_fel_e`.`szamla` 
CHARACTER SET utf8mb4 
FIELDS TERMINATED BY ',' 
OPTIONALLY ENCLOSED BY '"' 
LINES TERMINATED BY '\r\n' 
IGNORE 1 LINES 
(ESST_ID, X_BRUTTO_HUF, V_ADOSZAM_TORZSSZAM_DEP, KATEGORIA);
/* Információ: Records: 136868  Deleted: 1  Skipped: 0  Warnings: 0 */
-- Itt a csere!

SET FOREIGN_KEY_CHECKS = 1;
/* Érintett sorok: 137 804  Talált sorok: 0  Figyelmeztetés: 2 805  Időtartam 7 lekérdezések: 1,547 mp. */
USE `nav_fel_e`;
SET FOREIGN_KEY_CHECKS = 0;
-- 1. TÖRLÉS
TRUNCATE TABLE `nav_fel_e`.`szamla`;
TRUNCATE TABLE `nav_fel_e`.`gazdmut`;
-- 2. GAZDASÁGI MUTATÓK IMPORTÁLÁSA (Tisztítással)
LOAD DATA LOCAL INFILE 'C:\\Users\\ritzo\\Desktop\\nav_fel\\gazdmut.csv' 
REPLACE INTO TABLE `nav_fel_e`.`gazdmut` 
CHARACTER SET utf8mb4 
FIELDS TERMINATED BY ',' 
LINES TERMINATED BY '\r\n' 
IGNORE 1 LINES 
(@Nyers_AA_AZON, @Nyers_VALLALATMERET, @Nyers_TEAOR_KATEGORIA)
SET 
  -- Eltávolítjuk a felesleges macskakörmöket a szövegek elejéről és végéről
  AA_AZON = REPLACE(TRIM(BOTH '"' FROM @Nyers_AA_AZON), '"', ''),
  VALLALATMERET = REPLACE(TRIM(BOTH '"' FROM @Nyers_VALLALATMERET), '"', ''),
  TEAOR_KATEGORIA = REPLACE(TRIM(BOTH '"' FROM @Nyers_TEAOR_KATEGORIA), '"', '');
/* Információ: Records: 935  Deleted: 0  Skipped: 0  Warnings: 0 */
-- 3. SZÁMLA IMPORTÁLÁSA
LOAD DATA LOCAL INFILE 'C:\\Users\\ritzo\\Desktop\\nav_fel\\szamla.csv' 
REPLACE INTO TABLE `nav_fel_e`.`szamla` 
CHARACTER SET utf8mb4 
FIELDS TERMINATED BY ',' 
OPTIONALLY ENCLOSED BY '"' 
LINES TERMINATED BY '\r\n' 
IGNORE 1 LINES 
(ESST_ID, X_BRUTTO_HUF, V_ADOSZAM_TORZSSZAM_DEP, KATEGORIA);
/* Információ: Records: 136868  Deleted: 1  Skipped: 0  Warnings: 0 */
SET FOREIGN_KEY_CHECKS = 1;
/* Érintett sorok: 137 804  Talált sorok: 0  Figyelmeztetés: 0  Időtartam 7 lekérdezések: 1,297 mp. */
USE `nav_fel_a`;
USE `nav_fel_a`;
-- Itt már az _a adatbázist használjuk
SET FOREIGN_KEY_CHECKS = 0;
-- 1. TÖRLÉS
TRUNCATE TABLE `nav_fel_a`.`szamla`;
TRUNCATE TABLE `nav_fel_a`.`gazdmut`;
-- 2. GAZDASÁGI MUTATÓK IMPORTÁLÁSA
LOAD DATA LOCAL INFILE 'C:\\Users\\ritzo\\Desktop\\nav_fel\\gazdmut.csv' 
REPLACE INTO TABLE `nav_fel_a`.`gazdmut` 
CHARACTER SET utf8mb4 
FIELDS TERMINATED BY ',' 
LINES TERMINATED BY '\r\n' 
IGNORE 1 LINES 
(@Nyers_AA_AZON, @Nyers_VALLALATMERET, @Nyers_TEAOR_KATEGORIA) -- Csak a CSV oszlopai!
SET 
  AA_AZON = REPLACE(TRIM(BOTH '"' FROM @Nyers_AA_AZON), '"', ''),
  VALLALATMERET = REPLACE(TRIM(BOTH '"' FROM @Nyers_VALLALATMERET), '"', ''),
  TEAOR_KATEGORIA = REPLACE(TRIM(BOTH '"' FROM @Nyers_TEAOR_KATEGORIA), '"', '');
/* Információ: Records: 935  Deleted: 0  Skipped: 0  Warnings: 0 */
-- Az auto_increment ID-t itt meg sem említjük, a MySQL magától osztja ki!

-- 3. SZÁMLA IMPORTÁLÁSA
LOAD DATA LOCAL INFILE 'C:\\Users\\ritzo\\Desktop\\nav_fel\\szamla.csv' 
REPLACE INTO TABLE `nav_fel_a`.`szamla` 
CHARACTER SET utf8mb4 
FIELDS TERMINATED BY ',' 
OPTIONALLY ENCLOSED BY '"' 
LINES TERMINATED BY '\r\n' 
IGNORE 1 LINES 
(ESST_ID, X_BRUTTO_HUF, V_ADOSZAM_TORZSSZAM_DEP, KATEGORIA);
/* Információ: Records: 136868  Deleted: 0  Skipped: 0  Warnings: 0 */
-- Itt is csak a CSV-ben létező 4 oszlopot soroljuk fel. Az auto_increment ID automatikusan nőni fog a háttérben.

SET FOREIGN_KEY_CHECKS = 1;
/* Érintett sorok: 137 803  Talált sorok: 0  Figyelmeztetés: 0  Időtartam 7 lekérdezések: 2,328 mp. */