using Entitas;

public class PlayerInputFeature : Feature
{
    private InputContext _context;

    public PlayerInputFeature(Contexts contexts)
    {
        _context = contexts.input;

        Add(new ListenForInputSystem(contexts));
        Add(new ProcessInputSystem(contexts));
        Add(new ProcessLeftMouseClickSystem(contexts));
        Add(new LeftMouseClickConsumedSystem(contexts));
    }
    
    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }

}
