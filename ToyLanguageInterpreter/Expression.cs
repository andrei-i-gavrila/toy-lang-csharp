namespace ToyLanguageInterpreter
{
    public abstract class Expression
    {
        public abstract int Evaluate(ProgramState state);
    }
}