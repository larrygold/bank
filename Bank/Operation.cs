namespace Bank
{
    internal class Operation
    {
        public Movement MovementType { get; set; }
        public double Amount { get; set; }

        public Operation(Movement movementType, double amount)
        {
            this.MovementType = movementType;
            this.Amount = amount;
        }
    }
}