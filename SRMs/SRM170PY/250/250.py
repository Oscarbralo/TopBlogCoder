import math,string,itertools,fractions,heapq,collections,re,array,bisect,random

class LevelUp:
    def toNextLevel(self, expNeeded, received):
        index = 0
        while received > 0:
        	if received - expNeeded[index] >= 0:
        		received -= expNeeded[index]
        		index += 1
        	else:
        		break
        return expNeeded[index] - current