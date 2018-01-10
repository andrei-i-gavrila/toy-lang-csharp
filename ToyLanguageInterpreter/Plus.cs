namespace ToyLanguageInterpreter
{
    class Plus : ArithmeticExpression
    {
        public Plus(Expression lhs, Expression rhs) : base(lhs, rhs)
        {
        }

        public override int Evaluate(ProgramState state)
        {
            return lhs.Evaluate(state) + rhs.Evaluate(state);
        }
    }
}