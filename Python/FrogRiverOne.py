#https://app.codility.com/demo/results/training3DS4KM-SWE/
def frog_river_one(x, arr):
    if x < 1:
        raise ValueError

    if arr == []:
        raise ValueError

    si = 0
    m = set([])

    for ix,v in enumerate(arr):
        if v not in m:
            m.add(v)
            si += 1
            if si >= x:
                return ix

    return -1

#print(frog_river_one(5, [1,3,1,4,2,3,5,4]))