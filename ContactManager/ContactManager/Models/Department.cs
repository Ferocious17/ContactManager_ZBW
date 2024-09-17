using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    /// <summary>
    /// Repräsentiert eine Abteilung innerhalb der Organisation.
    /// </summary>
    /// <remarks>
    /// Die <see cref="Department"/>-Klasse modelliert eine Abteilung, die durch einen Namen identifiziert wird. 
    /// Sie enthält eine eindeutige ID für die Abteilung, die als Primärschlüssel verwendet wird, und den Namen der Abteilung.
    /// </remarks>
    public class Department
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Department"/>-Klasse mit dem angegebenen Namen.
        /// </summary>
        /// <param name="name">Der Name der Abteilung.</param>
        public Department(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Department"/>-Klasse ohne Parameter.
        /// Dieser Konstruktor wird in der Regel von der Entity Framework-Bibliothek verwendet.
        /// </summary>
        public Department() { }

        /// <summary>
        /// Die eindeutige ID der Abteilung, die als Primärschlüssel verwendet wird.
        /// </summary>
        [Key]
        public int DepartmentId { get; set; }

        /// <summary>
        /// Der Name der Abteilung.
        /// </summary>
        public string Name { get; set; }
    }
}
