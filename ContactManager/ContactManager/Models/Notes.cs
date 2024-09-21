using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    /// <summary>
    /// Repräsentiert eine Notiz, die Text und Datum enthält.
    /// </summary>
    /// <remarks>
    /// Die <see cref="Note"/>-Klasse wird verwendet, um Notizen zu speichern, die mit einem bestimmten Datum und Text versehen sind.
    /// Jede Notiz hat eine eindeutige ID, die als Primärschlüssel verwendet wird und automatisch generiert wird.
    /// </remarks>
    public class Note
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Note"/>-Klasse mit dem angegebenen Text und Datum.
        /// </summary>
        /// <param name="text">Der Text der Notiz.</param>
        /// <param name="date">Das Datum der Notiz.</param>
        public Note(string text, DateTime date)
        {
            Text = text;
            Date = date;
        }

        /// <summary>
        /// Die eindeutige ID der Notiz, die als Primärschlüssel verwendet wird und automatisch generiert wird.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Der Textinhalt der Notiz.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Das Datum, an dem die Notiz erstellt wurde.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
