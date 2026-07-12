SELECT kategoria, COUNT(*) AS szamlasorok_szama, SUM(X_BRUTTO_HUF) AS ossz_brutto, AVG(x_brutto_huf) AS atlag_brutto FROM szamla 
GROUP BY kategoria ORDER BY  szamlasorok_szama ASC;