namespace LongesCommonPrefix
{
    internal class longestCommon
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string longestCommon = strs[0];
            string finalStr = "";
            for (int i = 1; i < strs.Length; i++)
            {
                for (int j = 0; j < strs[i].Length; j++)
                {
                    if (longestCommon.Length - 1 < j)
                    {
                        break;
                    }

                    if (longestCommon[j] == strs[i][j])
                    {
                        finalStr = finalStr + strs[i][j];
                    }
                    else {
                        break;
                    }

                    
                }
                longestCommon = finalStr;
                finalStr = "";

            }

            return longestCommon;
        }
    }




}
