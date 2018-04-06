import sys

def MinAvgTwoSlice(arr):
    minSliceIndex = -1
    minSliceAvg = sys.maxsize
    currentSliceSum = 0
    currentSliceStart = 0
    currentSliceLength = 0
    currentSliceEnd = 0
    arrLen = len(arr)

    while currentSliceStart < arrLen:
        if currentSliceLength < 3:
            if currentSliceEnd >= arrLen:
                break

            currentSliceSum += arr[currentSliceEnd]
            currentSliceLength += 1
            currentSliceEnd += 1
        else:
            currentSliceSum -= arr[currentSliceStart]
            currentSliceStart += 1
            currentSliceLength -= 1

        if currentSliceLength >= 2:
            currentSliceAvg = currentSliceSum / currentSliceLength

            if currentSliceAvg < minSliceAvg:
                minSliceAvg = currentSliceAvg
                minSliceIndex = currentSliceStart

    return minSliceIndex