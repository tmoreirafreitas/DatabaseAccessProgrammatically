﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVD.Model
{
    public class Locacao
    {
        public int              ID            { get; set; }
        public Socio             Socio         { get; set; }
        public DateTime?         DataLocacao   { get; set; }
        public DateTime?         DataDevolucao { get; set; }
        public bool?             Status        { get; set; }
        public List<ItemLocacao> ItemsLocacao  { get; set; }

        public Locacao()
        {
            ItemsLocacao = new List<ItemLocacao>();
        }
    }
}
