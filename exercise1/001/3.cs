public class Solution_001_3
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n <= 0)
            return;

        int nums1Index = m - 1;
        int nums2Index = n - 1;
        int saveIndex = m + n - 1;
        while (nums1Index >= 0 && nums2Index >= 0)
        {
            if (nums2[nums2Index] >= nums1[nums1Index])
            {
                nums1[saveIndex] = nums2[nums2Index];
                nums2Index--;
            }
            else
            {
                nums1[saveIndex] = nums1[nums1Index];
                nums1Index--;
            }
            saveIndex--;
        }

        for (int i = nums2Index; i >= 0; i--)
        {
            nums1[i] = nums2[i];
        }
    }
}