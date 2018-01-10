namespace ToyLanguageInterpreter
{
    public class If : Statement
    {
        private readonly Expression condition;
        private readonly Statement thenStatement;
        private readonly Statement elseStatement;

        public If(Expression condition, Statement thenStatement, Statement elseStatement)
        {
            this.condition = condition;
            this.thenStatement = thenStatement;
            this.elseStatement = elseStatement;
        }

        public void Execute(ProgramState state)
        {
            state.ExecutionStack.Push(condition.Evaluate(state) == 0 ? thenStatement : elseStatement);
        }
    }
}