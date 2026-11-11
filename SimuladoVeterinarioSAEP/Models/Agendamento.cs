using System.Text.Json.Serialization;

namespace SimuladoVeterinarioSAEP.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
       
        public int PetId { get; set; }

        [JsonIgnore]
        public Pet? Pet { get; set; }
    }
}
