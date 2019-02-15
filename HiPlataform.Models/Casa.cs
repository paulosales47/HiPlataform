﻿namespace HiPlataform.Models
{
    public class Casa
    {
        public Casa(Rua rua, int numero, int totalEleitores)
        {
            Rua = rua;
            Numero = numero;
            TotalEleitores = totalEleitores;
        }

        public Rua Rua { get; set; }
        public int Numero { get; set; }
        public int TotalEleitores { get; set; }
    }
}
