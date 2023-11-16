namespace Tymakov
{
    public interface IChipher
    {
        string Encode(string s);
        string Decode(string s);
    }
}
