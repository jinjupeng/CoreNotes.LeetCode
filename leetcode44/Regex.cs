namespace leetcode44
{
    public class Regex
    {
        /// <summary>
        /// 44. 通配符匹配
        /// </summary>
        /// <param name="s">字符串</param>
        /// <param name="p">通配符</param>
        /// <returns></returns>
        public bool IsMatch(string s, string p)
        {
            var sp = 0; // 字符串索引位置
            var pp = 0; // 通配符索引位置
            var match = 0; // 匹配索引位置
            var star = -1; // '*'字符出现的索引位置
            while (sp < s.Length)
            {
                if (pp < p.Length && (s[sp] == p[pp] || p[pp] == '?'))
                {
                    sp++;
                    pp++;
                }else if (pp < p.Length && p[pp] == '*')
                {
                    star = pp;
                    match = sp;
                    pp++;
                } else if (star != -1)
                {
                    pp = star + 1;
                    match++;
                    sp = match;
                }
                else
                {
                    return false;
                }
            }

            // 当字符串s匹配完成后，通配符p还未匹配完成
            while (pp < p.Length && p[pp] == '*')
            {
                pp++;
            }

            return pp == p.Length;
        }
    }
}