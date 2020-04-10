
# https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/flags/
# https://app.codility.com/demo/results/trainingR7DR65-4KT/
# https://app.codility.com/demo/results/trainingR7MBGU-ZPE/
# correctness 100%
# performance 28%
# task score  66%

def find_peaks_distances(arrin):
    if arrin is None:
        raise ValueError
    
    arr = [1000000001] + arrin + [1000000001]
    
    previous_level = 1000000001
    was_greater = False
    previous_peak = -1
    min_distance = 1000000
    max_distance = 0
    
    peaks = []
    distances = []
    for ix, x in enumerate(arr):
        if (x < previous_level) and was_greater:
            last_peak = ix - 1 - 1 
            peaks.append(last_peak)
            
            if previous_peak >= 0:
                peak_distance = last_peak - previous_peak
                distances.append(peak_distance)
                
                if peak_distance < min_distance:
                    min_distance = peak_distance
                    
                if peak_distance > max_distance:
                    max_distance = peak_distance
                
            previous_peak = last_peak
            
        was_greater = x > previous_level
        previous_level = x

    return (peaks, distances, min_distance, max_distance)

def solution(arr):
    peaks, distances, min_distance, max_distance = find_peaks_distances(arr)
    
    if len(peaks) <= 0:
        return 0
    
    max_flags = len(peaks)
    min_flags = 1
   
    if max_flags > min_distance: # can not use max_flags due to minimum distance condition requirement
        max_flags = max_flags - 1
        
    maxAchievedFlagsCount = 0
    
    for currentFlagMinDist in range(max_flags, min_flags - 1, -1):
        if currentFlagMinDist < maxAchievedFlagsCount:
            return maxAchievedFlagsCount
        
        allFlagsCount = currentFlagMinDist
        flagsCount = 1
        cumulatedDist = 0
        for peakDist in distances:
            cumulatedDist = cumulatedDist + peakDist
            if cumulatedDist >= currentFlagMinDist:
                flagsCount = flagsCount + 1
                if flagsCount > maxAchievedFlagsCount:
                    maxAchievedFlagsCount = flagsCount
                if flagsCount >= allFlagsCount:
                    return allFlagsCount
                cumulatedDist = 0

    return 1
