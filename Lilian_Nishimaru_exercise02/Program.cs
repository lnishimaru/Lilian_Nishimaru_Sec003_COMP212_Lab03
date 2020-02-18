using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilian_Nishimaru_exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoiceArray = new Invoice[]
            {
                new Invoice (87, "Eletric Sander", 7, 57.98M ),
                new Invoice (24, "Power Saw", 18, 99.99M ),
                new Invoice (7, "Sledge Hammer", 11,21.50M),
                new Invoice (77, "Hammer      ", 76, 11.99M),
                new Invoice (39, "Lawn Mowner", 3, 79.50M),
                new Invoice (68, "Screw Driver", 106, 6.99M),
                new Invoice (56, "Jig Saw", 21, 11.00M)
            };
            var query1 = from Invoice in invoiceArray
                         let totalInvoice = Invoice.Quantity * Invoice.Price
                         let partName = Invoice.PartDescription
                         orderby totalInvoice
                         select new { Invoice.PartDescription, totalInvoice };

            Console.WriteLine("A) Invoice List in ascending order \n");
            foreach (var i in query1)
            {
                Console.WriteLine($"{i.PartDescription} \t Price: {i.totalInvoice}");
            }

            var query2 = (from Invoice in invoiceArray
                         orderby Invoice.Quantity descending
                         select Invoice.PartDescription).Take(1);

            Console.WriteLine("\nB) Part Description with the highest quantity \n");
            foreach (var i in query2)
            {
                Console.WriteLine($"{i}");
            }

            decimal query3 = (from Invoice in invoiceArray
                          orderby Invoice.Quantity descending
                          select Invoice.Price).Average();

            Console.WriteLine("\nC) Average Price of Parts \n");
            
            Console.WriteLine($"{query3:N2}\n");
            
        }
    }
}
