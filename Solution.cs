using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CodilityDemoTest
{
    public class Solution
    {
        public string solution(int AA, int AB, int BB)
        {
            var listAA = InitializeListsStrings(AA, "AA");
            var listAB = InitializeListsStrings(AB, "AB");
            var listBB = InitializeListsStrings(BB, "BB");

            var buildedSequence = BuildSequenceString(listAA, listAB, listBB);

            return buildedSequence;
        }

        static string BuildSequenceString(List<string>AA, List<string> AB, List<string> BB)
        {
            StringBuilder result = new StringBuilder();
            var lastAdded = AA.Count > 0 ? "AA" : BB.Count > 0 ? "BB" : "AB";
            var isFirstRound = true;

            while (AA.Count > 0 || BB.Count > 0 || AB.Count > 0)
            {
                if (isFirstRound)
                {
                    result.Append(lastAdded);
                    
                    switch (lastAdded)
                    {
                        case "AA":
                            AA.RemoveAt(0);
                        break;

                        case "BB":
                            BB.RemoveAt(0);
                            break;

                        default:
                            AB.RemoveAt(0);
                            break;
                    }
                    isFirstRound = false;
                }

                string nextToAdd = null;

                if (lastAdded == "AA")
                {
                    if (BB.Count > 0)
                    {
                        nextToAdd = "BB";
                    }
                }
                else if (lastAdded == "BB")
                {
                    if (AA.Count > 0)
                    {
                        nextToAdd = "AA";
                    }
                    else if (AB.Count > 0)
                    {
                        nextToAdd = "AB";
                    }
                }
                else
                {
                    if (AA.Count > 0)
                    {
                        nextToAdd = "AA";
                    }
                    else if (AB.Count > 0)
                    {
                        nextToAdd = "AB";
                    }
                }

                if (nextToAdd != null)
                {
                    result.Append(nextToAdd);

                    if (nextToAdd == "AA")
                    {
                        AA.RemoveAt(0);
                    }
                    else if (nextToAdd == "AB")
                    {
                        AB.RemoveAt(0);
                    }
                    else if (nextToAdd == "BB")
                    {
                        BB.RemoveAt(0);
                    }

                    lastAdded = nextToAdd;
                }
                else
                {
                    break;
                }
            }

            return result.ToString();
        }

        static List<string> InitializeListsStrings(int timesToAdd, string letterToAdd)
        {
            var entries = new List<string>();

            for (int i = 0; i < timesToAdd; i++)
            {
                entries.Add(letterToAdd);
            }

            return entries;
        }
    }
}
