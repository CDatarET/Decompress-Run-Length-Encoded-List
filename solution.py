class Solution:
    def decompressRLElist(self, nums):
        ret = []
        for i in range(0, len(nums), 2):
            ret.extend([nums[i + 1]] * nums[i])
        
        return ret
