var twoSum = (nums: number[], target: number) => {
    for(let i = 0; i < nums.length; i++)
    {
        let complement = target - nums[i];
        if(nums.indexOf(complement) !== -1 && nums.indexOf(complement) !== i)
        {
            return [i, nums.indexOf(complement)];
        }else{
            if(nums.indexOf(complement, i) !== -1 && nums.indexOf(complement, i) !== i){
                return [i, nums.indexOf(complement, i)];
            }
        }
    }
}

console.log(twoSum([3,2,4], 6));