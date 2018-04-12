
# https://app.codility.com/demo/results/trainingBGZ5KN-W9Z/

def solution(arr):
    arr.sort()
    le = len(arr) - 2
    for ix in range(le):
        if arr[ix] + arr[ix + 1] > arr[ix + 2]:
            return 1

        if ix == le:
            break

    return 0