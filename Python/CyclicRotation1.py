#https://app.codility.com/demo/results/trainingE4UNAA-Y9B/
def cyclic_rotation_1(arr, k):
    if k < 0 or k > 100:
        raise ValueError

    al = len(arr)

    if al == 0:
        return []

    k = k % al

    if k == 0:
        return arr

    return (arr * 2)[al-k:al + al-k]

#print(cyclic_rotation_1([3, 8, 9, 7, 6],5))