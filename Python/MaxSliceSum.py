# MaxSliceSum
# https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_slice_sum/
# https://app.codility.com/demo/results/trainingEVDBT5-B3H/
# it is marked as Painless but it took me over 2 hours to solve it

import sys

def is_negative(x):
    return x < 0

def MaxSliceSum(arr):
    if None == arr:
        raise ValueError
        
    arrLen = len(arr)
    
    if arrLen <= 0:
        return 0
    
    if arrLen == 1:
        return arr[0]
    
    allNegative = True
    maxNumber = -sys.maxsize

    currentBlob = 0
    first = True
    
    mergedRanges = []
    
    for x in arr:
        if x > maxNumber:
            maxNumber = x
            
        if x >= 0:
            allNegative = False
        
        if first:
            currentBlob = x
            first = False
        else:
            if is_negative(x) == is_negative(currentBlob):
                currentBlob += x
            else:
                mergedRanges.append(currentBlob)
                currentBlob = x
                
    mergedRanges.append(currentBlob)

    if allNegative:
        return maxNumber

    currentMerged = 0
    
    mergedRangesLen = len(mergedRanges)
    maxSliceSum = 0
    first = True
    
    for (ix, v) in enumerate(mergedRanges):
        if v >= 0:
            currentMerged += v
        else:
            if not first:
                if ix < mergedRangesLen - 1:
                    if (mergedRanges[ix + 1] + v >= 0) and (currentMerged + v >= 0):
                        currentMerged += v
                    else:
                        currentMerged = 0
           
        if currentMerged > maxSliceSum:
            maxSliceSum = currentMerged
            
        first = False
        
    if currentMerged > maxSliceSum:
        maxSliceSum = currentMerged
            
    return maxSliceSum    
    