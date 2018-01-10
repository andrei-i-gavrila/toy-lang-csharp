namespace ToyLanguageInterpreter
{
    class Print : Statement
    {
        private readonly Expression ExpressionValue;

        public Print(Expression expressionValue)
        {
            ExpressionValue = expressionValue;
        }

        public void Execute(ProgramState state)
        {
            state.Output.Add(ExpressionValue.Evaluate(state));
        }
    }
}