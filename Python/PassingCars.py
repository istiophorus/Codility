
# PassingCars
# https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/
# https://app.codility.com/demo/results/trainingRXF888-6T2/
def solution(arr):
    if arr == []:
        return 0
    
    result = 0
    zeros = 0
    
    for x in arr:
        if x == 0:
            zeros += 1
        else:
            if result > 1000000000 - zeros:
                return -1
            result += zeros            
        
    return result