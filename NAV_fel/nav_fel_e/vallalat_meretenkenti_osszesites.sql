SELECT g.VALLALATMERET, COUNT(*) AS szamlak_szama, SUM(s.X_BRUTTO_HUF) AS ossz_brutto, AVG(s.X_BRUTTO_HUF) 
AS atlag_brutto_ FROM gazdmut as g JOIN szamla as s ON s.V_ADOSZAM_TORZSSZAM_DEP = g.AA_AZON GROUP BY g.VALLALATMERET
ORDER BY ossz_brutto DESC;