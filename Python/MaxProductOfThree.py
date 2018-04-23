


# https://app.codility.com/programmers/lessons/6-sorting/max_product_of_three/
# https://app.codility.com/demo/results/trainingNCDRZJ-HQE/

def MaxProductOfThree(arr):
    if arr == None:
        raise ValueError
        
    if len(arr) < 3:
        raise ValueError
        
    arr.sort()
    r1 = arr[0] * arr[1] * arr[-1]
    r2 = arr[-1] * arr[-2] * arr[-3]
    
    if r1 > r2:
        return r1
    else:
        return r2