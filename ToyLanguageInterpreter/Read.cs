using System;

namespace ToyLanguageInterpreter
{
    class Read : Statement
    {
        private readonly string Variable;
        private readonly int FileDescriptor;

        public Read(string variable, int fileDescriptor)
        {
            Variable = variable;
            FileDescriptor = fileDescriptor;
        }

        public void Execute(ProgramState state)
        {
            try
            {
                state.SymbolTable[Variable] = int.Parse(state.FileTable.getFileReader(FileDescriptor).ReadLine());
            }
            catch (FormatException)
            {
                throw new ToyInvalidNumberException();
            }
            catch (ArgumentNullException)
            {
                throw new ToyEndOfFileException();
            }
        }
    }
}