using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class QueueReconstructionByHeight
    {
        public void Main()
        {
            
        }

        public int[,] ReconstructQueue(int[,] people)
        {
            return new int[0, 0];
            //if (people == null || people.GetLength(0) == 0 || people.GetLength(1) == 0)
            //    return new int[0,0];

            //var listOfPeople = new List<Tuple<int, int>>();
            //for (int j = 0; j < people.GetLength(0); j++)
            //{
            //    listOfPeople.Add(new Tuple<int, int>(people[j,0],people[j, 1]));
            //}

            //listOfPeople = listOfPeople.OrderByDescending(p => p.Item1).ThenByDescending(s => s.Item2).ToList();

            //int n = people.GetLength(0);
            //var tmp = new Dictionary<int,List<int>>();
            //for (int j = 0; j<n; j++)
            //    tmp.Add(people[j,1], new List<int>{people[j,0], people[j,1]});


            //var res = new int[people.GetLength(0),2];
            //int i = 0;
            //foreach (var dictElement in tmp)
            //{
            //    res[i,0] = dictElement[0];
            //    res[i++,1] = dictElement[1];
            //}

            //for (int[] k : tmp) {
            //    res[i][0] = k[0];
            //    res[i++][1] = k[1];
            //}

            //return res;

        }
    }
}
