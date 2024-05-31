namespace Utilities;

public class ProgramRunnerBuilder
{
    private readonly ProgramRunner _programRunner = new();

    public ProgramRunnerBuilder WithProgram(ConsoleKey key, ConsoleProgram program)
    {
        _programRunner.ConsolePrograms.Add(key, program);
        return this;
    }

    public ProgramRunner Build() => _programRunner;
}