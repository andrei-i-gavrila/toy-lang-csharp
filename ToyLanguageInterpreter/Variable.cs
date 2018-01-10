namespace ToyLanguageInterpreter
{
    class Variable : Expression
    {
        private readonly string VariableName;

        public Variable(string variableName)
        {
            VariableName = variableName;
        }

        public override int Evaluate(ProgramState state)
        {
            if (!state.SymbolTable.ContainsKey(VariableName))
            {
                throw new ToyUnknownVariable();
            }
            return state.SymbolTable[VariableName];
        }
    }
}