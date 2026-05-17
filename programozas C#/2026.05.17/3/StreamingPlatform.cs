using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_3
{
    internal class StreamingPlatform
    {
        List<Media> mediaLista;
        public StreamingPlatform(Media[] m)
        {
            mediaLista = new List<Media>();
            foreach (Media media in m)
            {
                mediaLista.Add(media);
            }
        }
        public void Animek()
        {
            foreach (Media media in mediaLista)
            {
                if (media is Anime)
                {
                    Console.WriteLine(media);
                }
            }
        }
        public void LeghosszabbFilm()
        {
            Film leghosszabbFilm = null;
            foreach (Media media in mediaLista)
            {
                if (media is Film film )
                {
                    if (leghosszabbFilm == null || film.Hossz > leghosszabbFilm.Hossz)
                    {
                        leghosszabbFilm = film;
                    }
                }
            }
            if (leghosszabbFilm != null)
            {
                Console.WriteLine($"A leghosszabb film: {leghosszabbFilm}");
            }
        }
        public void PremiumTartalmak()
        {
            foreach (Media media in mediaLista)
            {
                if (media.Premium)
                {
                    Console.WriteLine(media);
                }
            }
        }
        public void AtlagHossz()
        {
            int osszHossz = 0;
            int mediaSzam = mediaLista.Count;
            foreach (Media media in mediaLista)
            {
                osszHossz += media.Hossz;
            }
            double atlagHossz = (double)osszHossz / mediaSzam;
            Console.WriteLine($"Az átlagos hossz: {atlagHossz} perc");
        }
    }
}
