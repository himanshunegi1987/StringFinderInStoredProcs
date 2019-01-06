using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFinderInStoredProcs
{
    public class SearchedResult
    {
        public string StoredProcName { get; set; }

        public List<string> ChildStoredProcs { get; set; }

        public int SearchedItemCount { get; set; }

        public string FirstMatchedLine { get; set; }
    }

    public partial class SearchView : Form
    {
        public SearchView()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var results = new StringBuilder();
            var searchedResults = new List<SearchedResult>();
            var storedProcs = rtxtStoredProcsToLookFor.Text.Trim().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).OrderBy(x => x);
            var locations = rtxtStoredProcLocations.Text.Trim().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).OrderBy(x => x);

            foreach (var location in locations)
            {
                var directoryInfo = new DirectoryInfo(location);
                var files = directoryInfo.GetFiles("*.sql");

                foreach (var file in files)
                {
                    qwer(storedProcs, locations, file, null);
                }
            }
        }

        private SearchedResult qwer(IEnumerable<string> storedProcs, IEnumerable<string> locations, FileInfo file, SearchedResult parentSearchedResult = null)
        {
            var modifiedFileName = file.Name.Replace("Solomon:", String.Empty)
                                            .Replace("EMA.", String.Empty)
                                            .Replace("EPAY.", String.Empty)
                                            .Replace("AviTrack.", String.Empty)
                                            .Replace(".sql", String.Empty).ToLower();
            var searchedResult = new SearchedResult
            {
                StoredProcName = modifiedFileName,
                ChildStoredProcs = new List<string>(),
                SearchedItemCount = 0,
                FirstMatchedLine = String.Empty
            };

            if (storedProcs.Contains(modifiedFileName))
            {
                foreach (var line in File.ReadAllLines(file.FullName))
                {
                    var modifiedLine = line.ToLower().Trim();

                    if (modifiedLine.Contains(txtSearchString.Text.Trim()))
                    {
                        if (searchedResult.SearchedItemCount == 0)
                        {
                            searchedResult.FirstMatchedLine = line;
                        }

                        searchedResult.SearchedItemCount++;
                    }

                    if (modifiedLine.Contains("exec ")
                        && !modifiedLine.Contains("grant execute")
                        && !modifiedLine.Contains("exec @")
                        && !modifiedLine.Contains("exec (@"))
                    {
                        var modifiedLinev2 = modifiedLine.Replace("(", String.Empty)
                                                         .Replace(")", String.Empty)
                                                         .Replace("[", String.Empty)
                                                         .Replace("]", String.Empty);
                        var startIndex = -1;
                        var storedProcName = String.Empty;
                        var nextSpaceIndex = -1;
                        var storedProcNameLength = 0;
                        FileInfo childFile = null;

                        if (modifiedLinev2.Contains("dbo."))
                        {
                            startIndex = modifiedLinev2.IndexOf("dbo.");
                            startIndex += 4;
                        }
                        else if (modifiedLinev2.Contains("ema."))
                        {
                            startIndex = modifiedLinev2.IndexOf("ema.");
                            startIndex += 4;
                        }
                        else if (modifiedLinev2.Contains("epay."))
                        {
                            startIndex = modifiedLinev2.IndexOf("epay.");
                            startIndex += 5;
                        }

                        nextSpaceIndex = modifiedLinev2.IndexOf(' ', startIndex);
                        storedProcNameLength = nextSpaceIndex - startIndex;
                        storedProcName = modifiedLinev2.Substring(startIndex, storedProcNameLength);


                        foreach (var location in locations)
                        {
                            childFile = null;

                            if (File.Exists(Path.Combine(location, storedProcName + ".sql")))
                            {
                                childFile = new FileInfo(Path.Combine(location, storedProcName + ".sql"));
                            }
                            else if (File.Exists(Path.Combine(location, "EMA." + storedProcName + ".sql")))
                            {
                                childFile = new FileInfo(Path.Combine(location, "EMA." + storedProcName + ".sql"));
                            }

                            else if (File.Exists(Path.Combine(location, "EPAY." + storedProcName + ".sql")))
                            {
                                childFile = new FileInfo(Path.Combine(location, "EPAY." + storedProcName + ".sql"));
                            }
                        }

                        if (childFile != null)
                        {
                            qwer(storedProcs, locations, childFile, searchedResult);
                        }
                    }
                }
            }

            return searchedResult;
        }
    }
}
