CREATE TABLE tanar (
lakcim VARCHAR(100) NOT NULL,
telefonszam VARCHAR(20) NOT NULL,
szemigszam CHAR(10) PRIMARY KEY,
nev VARCHAR(100) NOT NULL,
evf INT,
betu CHAR(1), 
CONSTRAINT `Ofő`
FOREIGN KEY (evf, betu) REFERENCES osztaly(evf, betu)
ON DELETE SET NULL ON UPDATE CASCADE, 
UNIQUE (evf, betu)
)