namespace Memento;
internal class Program
{
    private static void Main(string[] args)
    {
        var savedStates = new List<Memento>();

        var originator = new Memento.Originator();
        originator.Set("State1");
        originator.Set("State2");
        savedStates.Add(originator.SaveToMemento());
        originator.Set("State3");
        // We can request multiple mementos, and choose which one to roll back to.
        savedStates.Add(originator.SaveToMemento());
        originator.Set("State4");

        originator.RestoreFromMemento(savedStates[1]);
    }
}