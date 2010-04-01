namespace Game304.Core
{
    public interface IDeck
    {
        Card[] Cards { get; }
        void Shuffle();
    }
}