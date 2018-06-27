# Nesting task from Codility
# https://app.codility.com/programmers/lessons/7-stacks_and_queues/nesting/
# https://app.codility.com/demo/results/trainingX2CG68-Z6K/

def Nesting(input):
    counter = 0
    for ch in input:
        if ch == '(':
            counter += 1
        elif ch == ')':
            if counter > 0:
                counter -= 1
            else:
                return 0
        else:
            raise ValueError("Input string contains invalid character: " + ch)
            
    if counter == 0:
        return 1
    else:
        return 0
            