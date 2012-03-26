using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AnalysisSystem
{
    class FindUtils
    {
        /// <summary>
        /// Check if the list have name item.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool Find(ArrayList list, String name)
        {
            bool found = false;

            while (true)
            {
                if (list.Count <= 0)
                    break;

                if (String.Compare(name, list[0] as String) > 0)
                {
                    list.RemoveAt(0);
                    continue;
                }
                else if (String.Compare(name, list[0] as String) == 0)
                {
                    found = true;
                    break;
                }
                else
                {
                    break;
                }
            }

            return found;
        }
    }
}
