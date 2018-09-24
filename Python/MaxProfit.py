# MaxProfit
# https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_profit/
# https://app.codility.com/demo/results/trainingEWJ9TM-QJH/

def solution(arr):
    if None == arr:
        raise ValueError
       
    arrLen = len(arr)
    
    if arrLen < 2:
        return 0
    
    maxArr = [0] * arrLen
    
    maxValue = 0
    
    for ix in range(arrLen - 1, -1, -1):
        currentValue = arr[ix]
        if currentValue > maxValue:
            maxValue = currentValue
            
        maxArr[ix] = maxValue
        
    if maxValue <= 0:
        return 0
        
    maxResult = 0
        
    for ix in range(arrLen):
        diff = maxArr[ix] - arr[ix]
        
        if diff > maxResult:
            maxResult = diff
            
    return maxResult