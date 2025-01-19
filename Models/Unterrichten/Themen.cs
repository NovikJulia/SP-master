﻿namespace SP.Models.Unterrichten
{
    public class Themen
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Bereich Bereich  { get; set; }

        public string? ThemeName { get; set; }

        public virtual List<Unterthema>? UnterthemenList { get; set; } 
    }
    public enum Bereich
    {
        None = 0,
        Grammatik = 1,
        Wortschatz = 2
    }
}
