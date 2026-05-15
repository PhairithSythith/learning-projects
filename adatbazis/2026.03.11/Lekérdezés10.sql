CREATE TABLE kepesites (
szakId INT,
tanarSzemig CHAR(10),
PRIMARY KEY(szakId, tanarSzemig),
FOREIGN KEY (szakId) REFERENCES szak(id) ON DELETE CASCADE ON UPDATE CASCADE, 
FOREIGN KEY (tanarSzemig) REFERENCES tanar(szemigszam) ON DELETE CASCADE ON UPDATE CASCADE  
)