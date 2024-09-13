using WebAPI_back_end.Enums;

namespace WebAPI_back_end.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public StatusTarefa Status { get; set; }
    }
}
