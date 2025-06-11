public class Solution_001_2
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] source = new int[m];
        for (int i = 0; i < m; i++)
        {
            source[i] = nums1[i];
        }
        int nums1Index = 0;
        int nums2Index = 0;
        for (int i = 0; i < m + n; i++)
        {
            if (nums1Index >= m)
            {
                for (int k = nums2Index; k < n; k++)
                {
                    nums1[i++] = nums2[k];
                }
                return;
            }

            if (nums2Index >= n)
            {
                for (int k = nums1Index; k < m; k++)
                {
                    nums1[i++] = source[k];
                }
                return;
            }

            if (source[nums1Index] <= nums2[nums2Index])
            {
                nums1[i] = source[nums1Index];
                nums1Index++;
            }
            else
            {
                nums1[i] = nums2[nums2Index];
                nums2Index++;
            }
        }
    }

    public void Test()
    {
        Merge(new int[] { 4, 5, 6, 0, 0, 0 }, 3, new int[] { 1, 2, 3 }, 3);
    }
}