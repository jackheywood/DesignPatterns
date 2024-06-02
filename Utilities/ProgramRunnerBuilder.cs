namespace Utilities;

public class ProgramRunnerBuilder
{
    private readonly ProgramRunner _programRunner = new();

    public ProgramRunnerBuilder WithProgram(ConsoleProgram program)
    {
        _programRunner.ConsolePrograms.Add(program);
        return this;
    }

    public ProgramRunner Build() => _programRunner;
}