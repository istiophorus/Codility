# https://app.codility.com/programmers/lessons/16-greedy_algorithms/tie_ropes/start/
# https://app.codility.com/demo/results/trainingVD4GEU-NET/

def solution(minLen, ropes):
    if (None == ropes):
        raise ValueError("ropes array is None")

    if len(ropes) <= 0:
        raise ValueError("ropes array is empty")
        
    if minLen <= 0:
        raise ValueError()
        
    currLen = 0
    count = 0
    
    for r in ropes:
        currLen = currLen + r
        if currLen >= minLen:
            count = count + 1
            currLen = 0
            
    if currLen >= minLen:
        count = count + 1
        currLen = 0
        
    return count
        