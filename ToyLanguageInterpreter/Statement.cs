using System.IO;

namespace ToyLanguageInterpreter
{
    public interface Statement
    {
        void Execute(ProgramState state);
    }
}