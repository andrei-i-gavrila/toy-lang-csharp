using System;

namespace ToyLanguageInterpreter
{
    public class ToyController
    {
        private readonly Repository _repository;

        public ToyController(Repository repository)
        {
            _repository = repository;
        }

        public void oneStep(ProgramState state)
        {
            if (state.ExecutionStack.Count == 0)
            {
                throw new ToyExecutionEnded();
            }
            state.ExecutionStack.Pop().Execute(state);
        }

        public void allSteps()
        {
            ProgramState state = _repository.getProgramState();

            while (state.ExecutionStack.Count > 0)
            {
                try
                {
                    oneStep(state);
                }
                catch (ToyException e)
                {
                    Console.WriteLine(e);
                }
            }

            state.FileTable.closeAllFiles();
        }
    }
}