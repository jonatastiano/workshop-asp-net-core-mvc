﻿using System;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Servicos
{
    public class VendedorServico
    {
        private readonly SalesWebMvcContext _context;

        public VendedorServico(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedores.ToList();
        }
    }
}
