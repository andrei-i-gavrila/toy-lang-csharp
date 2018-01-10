namespace ToyLanguageInterpreter
{
    class Open : Statement
    {
        private readonly string Variable;
        private readonly string Filename;

        public Open(string variable, string filename)
        {
            Variable = variable;
            Filename = filename;
        }

        public void Execute(ProgramState state)
        {
            state.SymbolTable[Variable] = state.FileTable.openFile(Filename);
        }
    }
}