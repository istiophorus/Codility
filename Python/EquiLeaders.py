# Task: https://app.codility.com/programmers/lessons/8-leader/equi_leader/
# Solution: https://app.codility.com/demo/results/trainingJWUPP9-QG5/

from collections import defaultdict

def Leaders(arr):
    if (arr == None):
        raise ValueError

    arrLen = len(arr)
    
    leaders = defaultdict(int)
    
    itemCounters = defaultdict(int)
    
    currentMax = -1
    currentMaxCounter = 0
    
    for (ix, x) in enumerate(arr):
        itemCounter = itemCounters[x] + 1
        itemCounters[x] = itemCounter
        
        if (itemCounter > currentMaxCounter):
            currentMax = x
            currentMaxCounter = itemCounter
            
        if (currentMaxCounter > ((ix + 1) // 2)):
            leaders[ix] = currentMax
            
    return leaders
    

def solution(arr):
    if (arr == None):
        raise ValueError
    
    arrLen = len(arr)
    if (arrLen < 2):
        return 0
    
    leaders1 = Leaders(arr)
    leaders2 = Leaders(arr[::-1])
    
    equiLeaders = 0
    
    for x in range(arrLen - 1):
        if x not in leaders1:
            continue
            
        revX = (arrLen - 1) - x - 1
        
        if revX not in leaders2:
            continue
            
        if leaders1[x] == leaders2[revX]:
            equiLeaders += 1
            
    return equiLeaders
    
    
