#https://app.codility.com/demo/results/trainingS88NEB-82D/
def odd_occurrences_in_array(arr):
    if arr == []:
        return 0

    result = 0

    for x in arr:
        result = result ^ x

    return result

#print(odd_occurrences_in_array([9,3,9,3,9,7,9]))