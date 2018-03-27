
# GenomicRangeQuery
# https://app.codility.com/programmers/lessons/5-prefix_sums/genomic_range_query/
# https://app.codility.com/demo/results/trainingBDRSRN-WDW/

def solution(genom, p, q):
    si = len(genom)
    arrAP = [0] * si
    arrCP = [0] * si
    arrGP = [0] * si
    arrTP = [0] * si

    arrAQ = [0] * si
    arrCQ = [0] * si
    arrGQ = [0] * si
    arrTQ = [0] * si
    
    queries = zip(p, q)
    
    counterA = 0
    counterC = 0
    counterG = 0
    counterT = 0
    
    for ix, ch in enumerate(genom):
        arrAP[ix] = counterA
        arrGP[ix] = counterG
        arrCP[ix] = counterC
        arrTP[ix] = counterT            
        
        if ch == 'A':
            counterA += 1
        if ch == 'C':
            counterC += 1
        if ch == 'G':
            counterG += 1
        if ch == 'T':
            counterT += 1        
            
        arrAQ[ix] = counterA
        arrGQ[ix] = counterG
        arrCQ[ix] = counterC
        arrTQ[ix] = counterT            

    result = []
    
    for ix, t in enumerate(queries):
        vp, vq = t
        
        diffA = arrAQ[vq] - arrAP[vp]
        diffG = arrGQ[vq] - arrGP[vp]
        diffC = arrCQ[vq] - arrCP[vp]
        diffT = arrTQ[vq] - arrTP[vp]
        
        minImpact = 0
        
        if diffA > 0:
            minImpact = 1
        elif diffC > 0:
            minImpact = 2
        elif diffG > 0:
            minImpact = 3
        elif diffT > 0:
            minImpact = 4
            
        result.append(minImpact)
        
    return result