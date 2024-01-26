using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_Array_leetcode_problem_3
{
    public class testcase1
    {
        public async Task TestcaseAsync()
        {
            await Task.Delay(1000);
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int? pre = null;
            var i = 0;
            foreach (var num in nums)
            {
                if (num != pre)
                {
                    nums[i] = num;
                    i++;
                }
                pre = num;
            }
            Console.WriteLine(i);
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(nums));
        }
    }
}