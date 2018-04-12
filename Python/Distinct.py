# https://app.codility.com/demo/results/trainingD6NGDZ-8RQ/

def Distinct(arr):
    m = {x for x in arr}
    return len(m)