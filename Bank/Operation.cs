using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Operation
    {
        public Movement MovementType { get; set; }
        public double Amount { get; set; }

        public Operation(Movement MovementType, double Amount)
        {
            this.MovementType = MovementType;
            this.Amount = Amount;
        }
    }
}
