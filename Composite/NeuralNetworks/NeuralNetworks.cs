using Utilities;

namespace Composite.NeuralNetworks;

public class NeuralNetworks() : ConsoleProgram("Composite in Neural Networks")
{
    public override Task RunAsync()
    {
        var neuron1 = new Neuron();
        var neuron2 = new Neuron();

        neuron1.ConnectTo(neuron2);

        var layer1 = new NeuronLayer { new(), new() };
        var layer2 = new NeuronLayer { new(), new(), new() };

        neuron1.ConnectTo(layer1);
        layer1.ConnectTo(layer2);

        return Task.CompletedTask;
    }
}