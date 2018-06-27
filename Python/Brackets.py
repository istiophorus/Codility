# Brackets
# Task:                 https://app.codility.com/programmers/lessons/7-stacks_and_queues/brackets/
# Solution and results: https://app.codility.com/demo/results/training9RBUZY-DVN/

def solution(input):
    if input == None:
        raise ValueError
        
    if input == '':
        return 1
        
    stack = []
        
    for ch in input:
        if ch == '(':
            stack.append('(')
        elif ch == ')':
            last = stack.pop()
            if last != '(':
                return 0
        elif ch == '[':
            stack.append('[')
        elif ch == ']':
            last = stack.pop()
            if last != '[':
                return 0
        elif ch == '{':
            stack.append('{')
        elif ch == '}':
            last = stack.pop()
            if last != '{':
                return 0
        else:
            raise ValueError("Input string contains invalid characters")
            
    if len(stack) == 0:
        return 1
        
    return 0
        