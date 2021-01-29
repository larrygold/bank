namespace Bank
{
    internal class Operation
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