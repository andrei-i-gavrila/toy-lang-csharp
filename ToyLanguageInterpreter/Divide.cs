namespace ToyLanguageInterpreter
{
    class Divide : ArithmeticExpression
    {
        public override int Evaluate(ProgramState state)
        {
            int rhsValue = rhs.Evaluate(state);
            if (rhsValue == 0)
            {
                throw new ToyDivisionByZero();
            }

            return lhs.Evaluate(state) / rhsValue;
        }

        public Divide(Expression lhs, Expression rhs) : base(lhs, rhs)
        {
        }
    }
}