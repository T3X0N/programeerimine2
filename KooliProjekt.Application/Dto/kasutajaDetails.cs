using System.Collections.Generic;

namespace KooliProjekt.Application.Dto
{
    // 16.01.2026
    public class kasutajaDetailsDto
    {
        public int Id { get; set; }
        public string Kasutajanimi { get; set; }
        public List<kasutajaDto> Parool { get; set; } = new List<kasutajaDto>();
    }
}
