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

-- 3. SZÁMLA IMPORTÁLÁSA
LOAD DATA LOCAL INFILE 'C:\\Users\\ritzo\\Desktop\\nav_fel\\szamla.csv' 
REPLACE INTO TABLE `nav_fel_e`.`szamla` 
CHARACTER SET utf8mb4 
FIELDS TERMINATED BY ',' 
OPTIONALLY ENCLOSED BY '"' 
LINES TERMINATED BY '\r\n' 
IGNORE 1 LINES 
(ESST_ID, X_BRUTTO_HUF, V_ADOSZAM_TORZSSZAM_DEP, KATEGORIA);

SET FOREIGN_KEY_CHECKS = 1;