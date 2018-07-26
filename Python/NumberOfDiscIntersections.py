# Task: https://app.codility.com/programmers/lessons/6-sorting/number_of_disc_intersections/
# Results: https://app.codility.com/demo/results/trainingUKDRUY-65Z/

from collections import defaultdict

def NumberOfDiscIntersections(arr):
    disks = [(ix - x, ix + x) for ix, x in enumerate(arr)]
    edges = []
    disksBegin = defaultdict(list)
    disksEnd = defaultdict(list)
    
    intersections = 0
    currentlyOpenDisks = 0
    
    for d in disks:
        e1,e2 = d
        edges.append(e1)
        edges.append(e2)
        
        disksBegin[e1].append(d)
        disksEnd[e2].append(d)
        
    edges = sorted(list(set(edges)))
    
    for e in edges:
        openingDisks = len(disksBegin[e])

        if (openingDisks > 0 and currentlyOpenDisks > 0):
            intersections = intersections + currentlyOpenDisks * openingDisks
            if intersections > 10000000:
                return -1
            
        currentlyOpenDisks = currentlyOpenDisks + openingDisks
            
        if (openingDisks > 1):
            intersections = intersections + openingDisks * (openingDisks - 1) // 2
            if intersections > 10000000:
                return -1
            
        closingDisks = len(disksEnd[e])
        
        currentlyOpenDisks = currentlyOpenDisks - closingDisks
        
    return intersections

#NumberOfDiscIntersections([1,5,2,1,4,0])