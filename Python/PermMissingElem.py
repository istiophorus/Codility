
#https://app.codility.com/demo/results/trainingQ37ACM-3XF/
def perm_missing_elem(arr):
    if arr == []:
        return 1

    al = len(arr)
    sum = 0
    sum_all = (al + 1) * (al + 2) // 2

    for x in arr:
        sum += x

    return sum_all - sum