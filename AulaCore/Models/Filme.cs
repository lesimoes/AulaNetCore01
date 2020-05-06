using System;
namespace AulaCore.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ano { get; set; }
        public int GeneroId { get; set; }

        public Filme()
        {
        }
    }
}
