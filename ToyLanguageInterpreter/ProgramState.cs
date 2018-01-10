using System.Collections.Generic;
using System.Linq;

namespace ToyLanguageInterpreter
{
    public class ProgramState
    {

        public IDictionary<string, int> SymbolTable { get; }
        public IList<int> Output { get; }
        public Stack<Statement> ExecutionStack { get; }
        public FileTable FileTable { get; }

        public ProgramState(Statement statement)
        {

            SymbolTable = new Dictionary<string, int>();
            Output = new ToyList<int>();
            ExecutionStack = new Stack<Statement>();
            ExecutionStack.Push(statement);
            FileTable = new ToyFileTable();
        }

        public override string ToString()
        {
            return SymbolTable + "\n" + Output + "\n" + ExecutionStack;
        }
    }
}