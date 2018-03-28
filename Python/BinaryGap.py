import sys

# https://app.codility.com/demo/results/training5ARS34-NED/
def binary_gap(input: int) -> int:
    if input < 1 or input > sys.maxsize:
        raise ValueError
       
    x = input
    current_count = 0
    max_gap = 0
    count_gap = False
    while x != 0:
        bit = x & 1
        if bit == 0 and count_gap:
            current_count = current_count + 1
        if bit == 1:
            count_gap = True
            if current_count > max_gap:
                max_gap = current_count
            current_count = 0
                
        x = x >> 1

    return max_gap

#print(binary_gap(561892))