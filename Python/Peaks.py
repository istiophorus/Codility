# task: https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/peaks/
# solution: https://app.codility.com/demo/results/training7JHSRM-NBT/

import math
from itertools import islice

def chunk(it, size):
    it = iter(it)
    return iter(lambda: tuple(islice(it, size)), ())

def checkSlicing(sliceLen, flags):
    chunks = chunk(flags, sliceLen)
    return all(any(x == 1 for x in ch) for ch in chunks)

def solution(arr: list) -> int:
    if arr == None:
        raise valueError
        
    arrLen = len(arr)
    
    if arrLen <= 2:
        return 0
    
    flags = [0] * arrLen
    
    peaks = set()
    
    for ix in range(1, arrLen - 1):
        if (arr[ix] > arr[ix - 1]) and (arr[ix] > arr[ix + 1]):
            peaks.add(ix)
            flags[ix] = 1
            
    peaksCount = len(peaks)
    
    if peaksCount < 1:
        return 0
    
    if peaksCount == 1:
        return 1
    
    maxValue = math.floor(arrLen / 2)
    
    if maxValue < 2:
        return 1
    
    for sliceLen in range(2, maxValue + 1):
        blocks = arrLen / sliceLen
        if math.floor(blocks) == blocks:
            if checkSlicing(math.floor(sliceLen), flags):
                return math.floor(blocks)
            
    return 1