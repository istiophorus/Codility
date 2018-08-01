# https://app.codility.com/programmers/lessons/7-stacks_and_queues/stone_wall/
# https://app.codility.com/demo/results/trainingQBVARR-MTN/

def StoneWall(wall):
    if wall == None:
        raise valueError()
        
    if len(wall) <= 1:
        return len(wall)
    
    blocks = []
    blockCount = 0
    
    for ix,h in enumerate(wall):
        while len(blocks) > 0:
            last = blocks[-1]
            if (last > h):
                blocks.pop()
            elif last == h:
                break
            else:
                blocks.append(h)
                blockCount += 1
                break
        
        if len(blocks) <= 0:
            blockCount += 1
            blocks.append(h)
            
    return blockCount
    