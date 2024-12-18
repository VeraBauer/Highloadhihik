namespace SpaceBattle.Lib;

public interface IMoveCommandStartable
{
    IUObject uobj { get; }
    Vector velocity { get; }
    IQueue<ICommand> queue { get; }
}

