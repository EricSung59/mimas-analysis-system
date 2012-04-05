using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace AnalysisSystem
{
    public static class AnalysisSystemUtils
    {
        private static AnalysisSystemDataContext _db = new AnalysisSystemDataContext();

        //-------------------- DELEGATE ------------------------------//

        public delegate void AnalysisSystemTask(AnalysisSystemTaskArgs args);

        //-------------------- STATIC METHOD -------------------------//

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
        /// if a item in itemToSearchCollection if found in searchCollection, doWorkAction 
        /// will be executed.
        /// </summary>
        /// <param name="searchCollection">
        /// </param>
        /// <param name="itemToSearchCollection"></param>
        /// <param name="task"></param>
        public static void PerformTask(
                ICollection searchCollection, 
                ICollection<AnalysisSystemTaskArgs> itemToSearchCollection, 
                AnalysisSystemTask task)
        {
            ArrayList searchList = new ArrayList();
            foreach (ListViewItem item in searchCollection)
            {
                searchList.Add(item.Text);
            }
            searchList.Sort();

            foreach (AnalysisSystemTaskArgs args in itemToSearchCollection)
            {
                if (Find(searchList, args.SearchValue))
                    task(args);
            }
        }


        //-------------------- PUBLIC INNER CLASS --------------------//
        public class AnalysisSystemTaskArgs
        {
            private string _searchValue = null;
            private int _ordinal;
            private int _total;

            private Sample _sample = null;
            private Volunteer _volunteer = null;
            private Picture _picture = null;
            private VolPic _volpic = null;

            //----------------------- CONSTRUCTOR --------------------//

            public AnalysisSystemTaskArgs(string searchValue)
            {
                _searchValue = searchValue;
            }

            public AnalysisSystemTaskArgs(string searchValue, int ordinal, int total)
                : this(searchValue)
            {
                _ordinal = ordinal;
                _total = total;
            }

            // ---------------------- PROPERTIES ---------------------//

            public string SearchValue
            {
                get { return _searchValue; }
            }

            public Sample Sample
            {
                get { return _sample; }
                set { _sample = value; }
            }

            public Volunteer Volunteer
            {
                get { return _volunteer; }
                set { _volunteer = value; }
            }

            public Picture Picture
            {
                get { return _picture; }
                set { _picture = value; }
            }

            public VolPic VolPic
            {
                get { return _volpic; }
                set { _volpic = value; }
            }

            public int Ordinal
            {
                get { return _ordinal; }
                set { _ordinal = value; }
            }

            public int Total
            {
                get { return _total; }
                set { _total = value; }
            }
        }
    }
}