using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoney
{
    public class Gastos
    {
        public int Id { get; set; }

        public decimal Valor { get; set; }

        public DateTime Data { get; set; }

        public string Descricao { get; set; }

        public Gastos(decimal? valor, DateTime data, string descricao)
        {
            if (!valor.HasValue)
            {
                throw new ArgumentNullException(nameof(valor), "O campo 'valor' não pode ficar vazio.");
            }

            if (valor.Value <= 0m)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "O valor deve ser maior que zero.");
            }

            this.Valor = valor.Value;
            this.Data = data;
            this.Descricao = descricao ?? string.Empty;
        }
    }
}
