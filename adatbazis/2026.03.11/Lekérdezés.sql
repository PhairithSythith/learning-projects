/* CREATE DATABASE de5jfi; */

/* CREATE TABLE diak(
 om CHAR(10) PRIMARY KEY,
 nev VARCHAR(100) NOT NULL,
 szuldatum DATE,
 szulhely VARCHAR(100) 
); */

CREATE TABLE osztaly(
 evf INT,
 betu CHAR(1),
 terem INT,
 PRIMARY KEY(evf, betu)
)



# így lehet kommentelni
# create :létrehoz séma elemetde5jfi
#create databasa de5jfi :adatbázist hoz létre és ott az elnevezés 