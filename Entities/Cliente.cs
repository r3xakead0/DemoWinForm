using LINQtoCSV;
using System;

namespace Demo.Entities
{
    public class Cliente
    {
        public int ID { get; set; }

        [CsvColumn(FieldIndex = 1)]
        public string Codigo { get; set; }

        [CsvColumn(FieldIndex = 2)]
        public string Nombres { get; set; }

        [CsvColumn(FieldIndex = 3)]
        public string Apellidos { get; set; }

        public int DocumentoId { get; set; }

        [CsvColumn(Name = "Documento", FieldIndex = 4)]
        public string DocumentoNombre { get; set; }

        [CsvColumn(FieldIndex = 5)]
        public string NroDocumento { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public SexoEnum Sexo { get; set; } 

        [CsvColumn(FieldIndex = 12)]
        public ActivoEnum Activo { get; set; }
    }
}
