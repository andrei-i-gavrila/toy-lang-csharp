namespace ToyLanguageInterpreter
{
    public class Assignment : Statement
    {
        private readonly string VariableName;
        private readonly Expression ValueExpression;

        public Assignment(string variableName, Expression valueExpression)
        {
            VariableName = variableName;
            ValueExpression = valueExpression;
        }

        public void Execute(ProgramState state)
        {
            state.SymbolTable.Add(VariableName, ValueExpression.Evaluate(state));
        }
    }
}