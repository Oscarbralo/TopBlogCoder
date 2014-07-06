import math,string,itertools,fractions,heapq,collections,re,array,bisect,random

class LevelUp:
    def toNextLevel(self, expNeeded, received):
        index = 0
        for i in range(len(expNeeded)):
            if received < expNeeded[i]:
                index = i
                break
        return expNeeded[i] - received