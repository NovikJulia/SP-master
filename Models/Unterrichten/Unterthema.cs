namespace SP.Models.Unterrichten
{
    public class Unterthema
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public virtual Thema? Themen { get; set; }

        public Guid ThemenId { get; set; }

        public string? NameUntertheme { get; set; }

        public string? Foto { get; set; }

        public string? Beschreibung { get; set; } 

        public string? Beispiele { get; set; }

        public virtual List<Übung>? Übungen { get; set; }

    }
}
