class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        #return len(set(nums)) != len(nums)
        hash = set()

        for i in nums:
            if i in hash:
                return True
            hash.add(i)
        return False