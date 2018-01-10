namespace ToyLanguageInterpreter
{
    class Minus : ArithmeticExpression
    {
        public Minus(Expression lhs, Expression rhs) : base(lhs, rhs)
        {
        }

        public override int Evaluate(ProgramState state)
        {
            return lhs.Evaluate(state) - rhs.Evaluate(state);
        }
    }
}