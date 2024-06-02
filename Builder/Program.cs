using Builder.BuilderExercise;
using Builder.FacetedBuilder;
using Builder.FluentBuilder;
using Builder.FunctionalBuilder;
using Builder.Inheritance;
using Builder.StepwiseBuilder;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new FluentBuilder())
    .WithProgram(new Inheritance())
    .WithProgram(new StepwiseBuilder())
    .WithProgram(new FunctionalBuilder())
    .WithProgram(new FacetedBuilder())
    .WithProgram(new BuilderExercise())
    .Build();

await runner.RunAsync();