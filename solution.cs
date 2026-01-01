public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        int size = 0;
        for(int i = 0; i < nums.Length; i += 2) size += nums[i];

        int[] ret = new int[size];
        int index = 0;
        for(int i = 0; i < nums.Length; i += 2) for(int j = 0; j < nums[i]; j++) ret[index++] = nums[i + 1];

        return(ret);
    }
}
