namespace Tymakov
{
    public class BChipher : IChipher
    {
        public string Encode(string s)
        {
            char[] res = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLower(s[i]))
                {
                    res[i] = (char)('я' - s[i] + 'а');
                }
                else if (char.IsUpper(s[i]))
                {
                    res[i] = (char)('Я' - s[i] + 'А');
                }
                else
                {
                    res[i] = s[i];
                }
            }

            return new string(res);
        }

        public string Decode(string s)
        {
            return Encode(s);
        }
    }
}
