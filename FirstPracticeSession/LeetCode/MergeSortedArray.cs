namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array/
    /// </summary>
    public class MergeSortedArray
    {
        public void Main()
        {
            Merge(new [] {0,0,0}, 0, new []{2,5,6}, 3 );
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
                return;

            var index = 0;
            for (var nums2Index = 0; nums2Index < n; nums2Index++)
            {
                var foundIt = false;
                while (!foundIt)
                {
                    if (nums1[index] <= nums2[nums2Index] && index < m + nums2Index)
                    {
                        index++;
                        continue;
                    }

                    for (int i = m + nums2Index - 1; i >= index; i--)
                    {
                        nums1[i + 1] = nums1[i];
                    }

                    nums1[index] = nums2[nums2Index];
                    foundIt = true;
                }
            }

        }
    }
}
