

# CountDiv task
# https://app.codility.com/programmers/lessons/5-prefix_sums/count_div/
# https://app.codility.com/demo/results/trainingQTS6GE-AFX/
def solution(a, b, k):
    if (b % k) != 0:
        b = b - b % k
    if (a % k) != 0:
        a = a + k - (a % k) 
    res = res = (b - a) // k + 1
    return res