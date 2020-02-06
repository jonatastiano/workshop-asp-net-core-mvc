using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            /*if (_context.Departamento.Any() ||
                _context.Vendedores.Any() || 
                _context.Vendas.Any())
            {
                return; // DB ja foi populado.
            }*/

            Departamento d1 = new Departamento(4, "Computador");
            Departamento d2 = new Departamento(5, "Fashion");

            Vendedor s1 = new Vendedor(1, "Bob Brow", "bob@gamil.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedor s2 = new Vendedor(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Vendedor s3 = new Vendedor(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Vendedor s4 = new Vendedor(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d1);
            Vendedor s5 = new Vendedor(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d2);
            Vendedor s6 = new Vendedor(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            RegistroVendedor r1 = new RegistroVendedor(1, new DateTime(2018, 09, 25), 11000.0, SallesStatus.Faturado, s1);
            RegistroVendedor r2 = new RegistroVendedor(2, new DateTime(2018, 09, 4), 7000.0, SallesStatus.Faturado, s5);
            RegistroVendedor r3 = new RegistroVendedor(3, new DateTime(2018, 09, 13), 4000.0, SallesStatus.Cancelado, s4);
            RegistroVendedor r4 = new RegistroVendedor(4, new DateTime(2018, 09, 1), 8000.0, SallesStatus.Faturado, s1);
            RegistroVendedor r5 = new RegistroVendedor(5, new DateTime(2018, 09, 21), 3000.0, SallesStatus.Faturado, s3);
            RegistroVendedor r6 = new RegistroVendedor(6, new DateTime(2018, 09, 15), 2000.0, SallesStatus.Faturado, s1);
            RegistroVendedor r7 = new RegistroVendedor(7, new DateTime(2018, 09, 28), 13000.0, SallesStatus.Faturado, s2);
            RegistroVendedor r8 = new RegistroVendedor(8, new DateTime(2018, 09, 11), 4000.0, SallesStatus.Faturado, s4);
            RegistroVendedor r9 = new RegistroVendedor(9, new DateTime(2018, 09, 14), 11000.0, SallesStatus.Pendente, s6);
            RegistroVendedor r10 = new RegistroVendedor(10, new DateTime(2018, 09, 7), 9000.0, SallesStatus.Faturado, s6);
            RegistroVendedor r11 = new RegistroVendedor(11, new DateTime(2018, 09, 13), 6000.0, SallesStatus.Faturado, s2);
            RegistroVendedor r12 = new RegistroVendedor(12, new DateTime(2018, 09, 25), 7000.0, SallesStatus.Pendente, s3);
            RegistroVendedor r13 = new RegistroVendedor(13, new DateTime(2018, 09, 29), 10000.0, SallesStatus.Faturado, s4);
            RegistroVendedor r14 = new RegistroVendedor(14, new DateTime(2018, 09, 4), 3000.0, SallesStatus.Faturado, s5);
            RegistroVendedor r15 = new RegistroVendedor(15, new DateTime(2018, 09, 12), 4000.0, SallesStatus.Faturado, s1);
            RegistroVendedor r16 = new RegistroVendedor(16, new DateTime(2018, 10, 5), 2000.0, SallesStatus.Faturado, s4);
            RegistroVendedor r17 = new RegistroVendedor(17, new DateTime(2018, 10, 1), 12000.0, SallesStatus.Faturado, s1);
            RegistroVendedor r18 = new RegistroVendedor(18, new DateTime(2018, 10, 24), 6000.0, SallesStatus.Faturado, s3);
            RegistroVendedor r19 = new RegistroVendedor(19, new DateTime(2018, 10, 22), 8000.0, SallesStatus.Faturado, s5);
            RegistroVendedor r20 = new RegistroVendedor(20, new DateTime(2018, 10, 15), 8000.0, SallesStatus.Faturado, s6);
            RegistroVendedor r21 = new RegistroVendedor(21, new DateTime(2018, 10, 17), 9000.0, SallesStatus.Faturado, s2);
            RegistroVendedor r22 = new RegistroVendedor(22, new DateTime(2018, 10, 24), 4000.0, SallesStatus.Faturado, s4);
            RegistroVendedor r23 = new RegistroVendedor(23, new DateTime(2018, 10, 19), 11000.0, SallesStatus.Cancelado, s2);
            RegistroVendedor r24 = new RegistroVendedor(24, new DateTime(2018, 10, 12), 8000.0, SallesStatus.Faturado, s5);
            RegistroVendedor r25 = new RegistroVendedor(25, new DateTime(2018, 10, 31), 7000.0, SallesStatus.Faturado, s3);
            RegistroVendedor r26 = new RegistroVendedor(26, new DateTime(2018, 10, 6), 5000.0, SallesStatus.Faturado, s4);
            RegistroVendedor r27 = new RegistroVendedor(27, new DateTime(2018, 10, 13), 9000.0, SallesStatus.Pendente, s1);
            RegistroVendedor r28 = new RegistroVendedor(28, new DateTime(2018, 10, 7), 4000.0, SallesStatus.Faturado, s3);
            RegistroVendedor r29 = new RegistroVendedor(29, new DateTime(2018, 10, 23), 12000.0, SallesStatus.Faturado, s5);
            RegistroVendedor r30 = new RegistroVendedor(30, new DateTime(2018, 10, 12), 5000.0, SallesStatus.Faturado, s2);

            _context.Departamento.AddRange(d1, d2);

            _context.Vendedores.AddRange(s1, s2, s3, s4, s5, s6);

            _context.Vendas.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, 
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
