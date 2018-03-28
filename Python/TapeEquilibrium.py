import math

#https://app.codility.com/demo/results/trainingSMJ6AD-ZBK/
def tape_equilibrium(arr):
    if len(arr) < 2:
        raise ValueError

    temp = []
    current_sum = 0
    current_abs_sum = 0

    for x in arr:
        current_sum += x
        current_abs_sum += abs(x)
        temp.append(current_sum)

    del temp[len(temp) - 1]

    min_diff = current_abs_sum + 1
    min_diff_index = -1
    ix = 1

    for s in temp:
        current_diff = abs((current_sum - s) - s)
        if (current_diff < min_diff):
            min_diff = current_diff
            min_diff_index = ix
        ix += 1

    return min_diff

#print(tape_equilibrium([-1,3]))
#print(tape_equilibrium([1,2,3]))
#print(tape_equilibrium([3,1,2,4,3]))