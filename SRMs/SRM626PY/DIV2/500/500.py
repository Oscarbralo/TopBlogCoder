import math,string,itertools,fractions,heapq,collections,re,array,bisect,random

class FixedDiceGameDiv2:
    def getExpectation(self, a, b):
        games = 5
        totalAlice = 0.0
        totalWins = 0.0
        if b > a:
            b = a
        for i in range(games):
            for x in range(1, a + 1):
                temp = b
                for j in range(1, b + 1):
                    if x > j:
                        totalAlice += float(x)
                        totalWins += 1.0
        return totalAlice / totalWins