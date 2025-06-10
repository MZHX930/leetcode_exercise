public class Solution1
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m > 0 && n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + m - 1; j >= 0; j--)
                {
                    if (nums2[i] < nums1[j])
                    {
                        nums1[j + 1] = nums1[j];
                        nums1[j] = nums2[i];
                    }
                    else
                    {
                        nums1[j + 1] = nums2[i];
                        break;
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                nums1[i] = nums2[i];
            }
        }
    }
}