public class Solution {
   public int[] TwoSum(int[] nums, int target) {
        
        // Loop 1: Pick the first number
        for (int i = 0; i < nums.Length; i++) {
            
            // Loop 2: Pick a second number (always starts after i)
            for (int j = i + 1; j < nums.Length; j++) {
                
                // Check if they add up to the target
                if (nums[i] + nums[j] == target) {
                    // Return their positions (indices)
                    return new int[] { i, j };
                }
            }
        }
        
        // Return an empty array if no answer is found
        return new int[0];
    }
}
