﻿namespace RPG.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string Sobrenome { get; set; } = string.Empty;
        public string? Fantasia { get; set; }
        public string?  Local { get; set; }

    }
}
