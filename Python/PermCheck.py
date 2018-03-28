#https://app.codility.com/demo/results/trainingW7RWX8-HEG/
import sys

def perm_check(arr):
    m = {}
    minValue = sys.maxsize
    maxValue = -1
    for x in arr:
        if x < minValue:
            minValue = x
            
        if x > maxValue:
            maxValue = x
            
        m[x] = True
    if minValue == 1 and maxValue == len(arr) and len(m) == len(arr):
        return 1
    else:
        return 0
    
#perm_check([1,3,2])