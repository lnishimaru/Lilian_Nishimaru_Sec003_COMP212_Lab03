using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilian_Nishimaru_exercise02
{
    public class Invoice
    {
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Invoice(int partNumber, string partDescription, int quantity, decimal price)
        {
            this.PartNumber = partNumber;
            this.PartDescription = partDescription;
            this.Quantity = quantity;
            this.Price = price;
        }
    }
}
