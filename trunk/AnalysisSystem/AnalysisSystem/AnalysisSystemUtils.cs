using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AnalysisSystem
{
    class AnalysisSystemUtils
    {
        private static AnalysisSystemDataContext _db = new AnalysisSystemDataContext();

        public delegate void DoWorkAction(Sample sample);

        /// <summary>
        /// Check if the list have name item.
        /// </summary>
        /// <param name="list">List to find name, modified after return</param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="containColletion">
        ///     Loop all samples, do Action if the current sample is
        ///     contained in containCollection
        /// </param>
        /// <param name="action"></param>
        public static void DoWork(ICollection containColletion, DoWorkAction action)
        {
            ArrayList containList = new ArrayList();
            foreach (object obj in containColletion)
            {
                containList.Add(obj.ToString());
            }
            containList.Sort();

            var dataQuery =
                from samples in _db.Samples
                from volpics in _db.VolPics
                where samples.SID == volpics.SID
                select new { samples, volpics };

            foreach (var data in dataQuery)
            {
                if (Find(containList, data.samples.SID))
                {
                    action(data.samples);
                }
            }
        }
    }
}