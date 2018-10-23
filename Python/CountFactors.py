# task: https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/count_factors/
# solution: https://app.codility.com/demo/results/trainingW3A2V4-9UQ/

import math
import collections

def solution(input: int) -> int:
    if input < 0:
        raise ValueError
        
    if input < 2:
        return 1
    
    if input < 4:
        return 2
    
    counter = 0
    
    for ix in range(2, math.floor(math.sqrt(input)) + 1):
        v = input / ix
        
        if math.floor(v) == v:
            if ix != v:
                counter = counter + 2
            else:
                counter = counter + 1
                
    counter = counter + 2 # 1 and input
    
    return counter