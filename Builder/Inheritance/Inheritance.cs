﻿using Utilities;

namespace Builder.Inheritance;

using static Console;

public class Inheritance : ConsoleProgram
{
    public Inheritance()
    {
        Name = "Fluent Builder Inheritance";
    }

    public override Task RunAsync()
    {
        var me = Person.New
            .Called("Jack")
            .WorksAsA("Developer")
            .Build();

        WriteLine(me);

        return Task.CompletedTask;
    }
}