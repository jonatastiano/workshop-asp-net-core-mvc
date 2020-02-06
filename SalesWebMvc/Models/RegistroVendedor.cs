using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class RegistroVendedor
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public SallesStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendedor()
        {
        }

        public RegistroVendedor(int id, DateTime data, double quantidade, SallesStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
