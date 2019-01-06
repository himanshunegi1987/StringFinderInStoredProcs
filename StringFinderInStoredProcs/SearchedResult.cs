using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFinderInStoredProcs
{
    public class SearchedResult
    {
        public string StoredProcName { get; set; }

        public List<string> ChildStoredProcs { get; set; }

        public int SearchedItemCount { get; set; }

        public string FirstMatchedLine { get; set; }
    }
}
