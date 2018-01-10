namespace ToyLanguageInterpreter
{
    internal abstract class ArithmeticExpression : Expression
    {
        protected readonly Expression lhs;
        protected readonly Expression rhs;

        protected ArithmeticExpression(Expression lhs, Expression rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }
    }
}