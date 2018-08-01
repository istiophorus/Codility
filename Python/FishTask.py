# https://app.codility.com/programmers/lessons/7-stacks_and_queues/fish/
# https://app.codility.com/demo/results/trainingTAQU2M-AME/

def solution(arrA, arrB):
    if arrA == None:
        raise ValueError()
        
    if arrB == None:
        raise ValueError()        
        
    if len(arrA) != len(arrB):
        raise ValueError()
        
    ab = zip(arrA, arrB)
    
    alive = 0
    
    downstream = []
    upstream = []
    
    for currentFish,di in ab:
        if di == 0: # upstream
            if len(downstream) == 0:
                alive = alive + 1
            else:
                while len(downstream) > 0:
                    last = downstream[-1]
                    if last < currentFish:
                        downstream.pop()
                    elif last > currentFish:
                        break
                        
                if len(downstream) <= 0:
                    alive = alive + 1
        else: # di == 1
            downstream.append(currentFish)
            
    return alive + len(downstream)