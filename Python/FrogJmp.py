import math

#https://app.codility.com/demo/results/trainingHMVFK8-43N/
def frog_jmp(x, y, d):
    if x < 1 or y < x or d < 1:
        raise ValueError

    diff = y - x
    return math.ceil(diff / d)
        
#print(frog_jmp(10,85,30))
#print(frog_jmp(1,2,10))
#print(frog_jmp(1,4,2))
#print(frog_jmp(1,5,2))
#print(frog_jmp(1,2,1))