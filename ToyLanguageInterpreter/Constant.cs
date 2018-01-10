namespace ToyLanguageInterpreter
{
    class Constant : Expression
    {
        private readonly int Value;

        public Constant(int value)
        {
            Value = value;
        }

        public override int Evaluate(ProgramState state)
        {
            return Value;
        }
    }
}