using System;

namespace ToyLanguageInterpreter
{
    public class ToyLanguageInterpreter
    {
        static void Main(string[] args)
        {
            Statement program = new Compound(
                new Assignment("a", new Minus(new Constant(2), new Constant(2))),
                new If(new Variable("a"),
                    new Assignment("v", new Constant(2)),
                    new Assignment("v", new Constant(3))),
                new Print(new Variable("v"))
            );

            ProgramState State = new ProgramState(program);

            Repository Repo = new ToyRepository(State);

            ToyController Controller = new ToyController(Repo);

            Controller.allSteps();

            Console.WriteLine(State.Output.ToString());
        }
    }
}