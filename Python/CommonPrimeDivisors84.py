
#
# https://app.codility.com/programmers/lessons/12-euclidean_algorithm/common_prime_divisors/
# https://app.codility.com/demo/results/trainingKEBYGS-74H/
#

def UniquePrimeDivisors(x):
    result = set()
    divisor = 2
    while divisor < x:
        if x % divisor == 0:
            result.add(divisor)
            x = x / divisor
        else:
            divisor += 1
    result.add(int(x))
    return result

def solution(a, b):
    if a == None:
        raise ValueError()
        
    if b == None:
        raise ValueError()
        
    if len(a) != len(b):
        raise ValueError()
        
    counter = 0
        
    for ix, xa in enumerate(a):
        xb = b[ix]
        s1 = UniquePrimeDivisors(xa)
        s2 = UniquePrimeDivisors(xb)
        
        if s1 == s2:
            counter += 1
        
    return counter