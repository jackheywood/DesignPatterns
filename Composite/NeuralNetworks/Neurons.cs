using System.Collections;
using System.Collections.ObjectModel;

namespace Composite.NeuralNetworks;

public class Neuron : IEnumerable<Neuron>
{
    public readonly List<Neuron> In = [];
    public readonly List<Neuron> Out = [];

    public float Value;

    public IEnumerator<Neuron> GetEnumerator()
    {
        yield return this;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class NeuronLayer : Collection<Neuron>
{ }