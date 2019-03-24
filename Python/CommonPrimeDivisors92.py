
#
# https://app.codility.com/programmers/lessons/12-euclidean_algorithm/common_prime_divisors/
# https://app.codility.com/demo/results/training7YTF68-B9E/
#

def LargestCommonDivisor(a, b):
    if a == 0:
        raise ValueError()
        
    if b == 0:
        raise ValueError()
    
    if (a % b) == 0:
        return b

    if (b % a) == 0:
        return a
    
    if a >= b:
        return LargestCommonDivisor(b, a % b)
    else:
        return LargestCommonDivisor(a, b % a)
        
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
    
def HaveAllCommonPrimeDivisorsExt2(x1,x2):
    if x1 == x2:
        return True

    lcd = LargestCommonDivisor(x1, x2)
    
    if lcd == 1 and not (x1 == 1 and x2 == 1):
        return False
    
    d1 = x1 // lcd
    d2 = x2 // lcd
    
    print(d1, d2)
    
    x1ok = False
    x2ok = False

    if lcd % d1 == 0:
        x1ok = True
        
    if lcd % d2 == 0:
        x2ok = True
        
    if x1ok and x2ok:
        return True
        
    lcdprime = UniquePrimeDivisors(lcd)
    
    if not x1ok:
        d1prime = UniquePrimeDivisors(d1)
        x1ok = lcdprime.intersection(d1prime) == d1prime    
        
    if not x2ok:
        d2prime = UniquePrimeDivisors(d2)
        x2ok = lcdprime.intersection(d2prime) == d2prime
    
    return x1ok and x2ok  
    
def solution(a, b):
    if a == None:
        raise ValueError()
        
    if b == None:
        raise ValueError()
        
    if len(a) != len(b):
        raise ValueError()
        
    counter = 0
        
    for xa, xb in zip(a, b):
        print(xa)
        print(xb)
        if HaveAllCommonPrimeDivisorsExt2(xa, xb):
            print(True)
            counter += 1

        print("###")
        
    return counter