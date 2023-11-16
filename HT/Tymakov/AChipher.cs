namespace Tymakov
{
    public class AChipher : IChipher
    {
        private int bs = 32;
        public string Encode(string s)
        {
            char[] res = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLower(s[i]))
                {
                    res[i] = (char)((s[i] + 1 - 'а') % bs + 'а');
                }
                else if (char.IsUpper(s[i]))
                {
                    res[i] = (char)((s[i] + 1 - 'А') % bs + 'А');
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
            char[] res = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLower(s[i]))
                {
                    res[i] = (char)((s[i] - 1 - 'а') % bs + 'а');
                }
                else if (char.IsUpper(s[i]))
                {
                    res[i] = (char)((s[i] - 1 - 'А') % bs + 'А');
                }
                else
                {
                    res[i] = s[i];
                }
            }

            return new string(res);
        }
    }
}
