public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            int temp=target-nums[i];
            if(map.ContainsKey(temp))
                return new int[]{map[temp],i};
            else
                map[nums[i]]=i;
        }
        return new int[]{};
    }
}
