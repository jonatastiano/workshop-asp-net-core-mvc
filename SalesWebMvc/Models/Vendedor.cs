﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroVendedor> Vendas { get; set; } = new List<RegistroVendedor>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVenda(RegistroVendedor sr)
        {
            Vendas.Add(sr);
        }

        public void RemoverVenda(RegistroVendedor sr)
        {
            Vendas.Remove(sr);
        }
        
        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Vendas.Where(sr => sr.Data >= inicio && sr.Data <= final).Sum(sr => sr.Quantidade);
        }
    }
}
