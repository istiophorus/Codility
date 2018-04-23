

# https://app.codility.com/programmers/lessons/17-dynamic_programming/number_solitaire/
# https://app.codility.com/demo/results/training8D4P2J-N9F/

import sys

def NumberSolitaire(arr):
    if arr == None:
        raise ValueError
    
    arrL = len(arr)
        
    if arrL < 1:
        raise ValueError
        
    if arrL == 1:
        return arr[0]
        
    currentSum = arr[0]
    
    result = []
    result.append(arr[0])
    
    for ix,v in enumerate(arr[1:]):
        baseIndex = ix + 1
        
        innerMax = -sys.maxsize
        resultL = len(result)
        for ix in list(range(1,7)):
            index = baseIndex - ix
            if index >= 0 and index < resultL:
                currentMax = result[index] + v
                if currentMax > innerMax:
                    innerMax = currentMax
        
        result.append(innerMax)
        
    return result[-1]

NumberSolitaire([1, -2, 0, 9, -1, -2])

NumberSolitaire([1,0,0,0,0,1,0,0,0,0,1])