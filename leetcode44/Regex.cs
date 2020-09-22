namespace leetcode44
{
    // TODO：递归需要剪枝，会超时
    public class Regex
    {
        private bool _matched; // 默认不匹配false
        private char[] _pattern; // 正则表达式
        private int _patternLen; // 正则表达式长度

        /// <summary>
        /// 通配符匹配
        /// </summary>
        /// <param name="s">字符串</param>
        /// <param name="p">通配符</param>
        /// <returns></returns>
        public bool IsMatch(string s, string p)
        {
            _pattern = p.ToCharArray();
            _patternLen = p.Length;
            _matched = false;
            RMatch(0, 0, s.ToCharArray(), s.Length);
            return _matched;
        }

        /// <summary>
        /// 通配符匹配
        /// </summary>
        /// <param name="ti">文本串下标</param>
        /// <param name="pj">正则表达式下标</param>
        /// <param name="text">文本串</param>
        /// <param name="textLen">文本串长度</param>
        private void RMatch(int ti, int pj, char[] text, int textLen)
        {
            // 如果已经匹配了，就不要继续递归了
            if (_matched) return;

            // 正则表达式到结尾了
            if (pj == _patternLen)
            {
                // 文本串也到结尾了
                if (ti == textLen) _matched = true;
                return;
            }

            switch (_pattern[pj])
            {
                // *可以匹配任意字符串（包括空字符串）
                case '*':
                    {
                        for (var k = 0; k <= textLen - ti; ++k)
                        {
                            RMatch(ti + k, pj + 1, text, textLen);
                        }

                        break;
                    }
                // ?可以匹配任何单个字符
                case '?':
                    // RMatch(ti, pj + 1, text, textLen);
                    RMatch(ti + 1, pj + 1, text, textLen);

                    break;
                // 纯字符匹配才行
                default:
                    {
                        if (ti < textLen && _pattern[pj] == text[ti])
                        {
                            RMatch(ti + 1, pj + 1, text, textLen);
                        }

                        break;
                    }
            }
        }
    }
}