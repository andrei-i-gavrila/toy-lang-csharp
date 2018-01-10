namespace ToyLanguageInterpreter
{
    public class ToyRepository : Repository
    {
        private readonly ProgramState state;

        public ToyRepository(ProgramState state)
        {
            this.state = state;
        }

        public ProgramState getProgramState()
        {
            return state;
        }
    }
}