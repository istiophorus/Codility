import math

# task: https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/min_perimeter_rectangle/
# solution: https://app.codility.com/demo/results/training3DNWVX-97Z/

def solution(input: int) -> int:
    if input < 1:
        raise ValueError

    x = math.sqrt(input)
    
    v1 = math.ceil(x)
    
    while True:
        v2 = input / v1
        
        if v2 == math.ceil(v2):
            break
            
        v1 = v1 - 1
       
    return math.ceil(2 * (v1 + v2))