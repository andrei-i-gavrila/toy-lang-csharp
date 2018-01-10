using System;
using System.Linq;

namespace ToyLanguageInterpreter
{
    class Compound : Statement
    {
        private readonly Statement thisStatement;
        private readonly Statement nextStatement;

        public Compound(params Statement[] statements)
        {
            if (statements.Length < 2)
            {
                throw new ArgumentException("At least two statements needed");
            }
            thisStatement = statements[0];
            nextStatement = statements.Length == 2  ? statements[1] : new Compound(statements.Skip(1).ToArray());
        }

        public void Execute(ProgramState state)
        {
            state.ExecutionStack.Push(nextStatement);
            state.ExecutionStack.Push(thisStatement);
        }
    }
}