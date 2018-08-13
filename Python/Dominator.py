# Task:   https://app.codility.com/c/run/trainingAWNVAU-D3U
# Result: https://app.codility.com/demo/results/trainingAWNVAU-D3U/

from collections import defaultdict

def solution(arr):
    if arr == None:
        raise ValueError
        
    arr_len = len(arr)
        
    if (arr_len <= 0):
        return -1
    
    if (arr_len == 1):
        return 0
    
    values = defaultdict(int)
    indexes = defaultdict(list)
    current_max = -1
    current_max_count = 0
    
    for ix, a in enumerate(arr):
        new_count = values[a] + 1
        values[a] = new_count
        indexes[a].append(ix)
        
        if (new_count > current_max_count):
            current_max = a
            current_max_count = new_count
            
            
    if (current_max_count > (arr_len / 2)):
        return indexes[current_max][0]
    
    return -1