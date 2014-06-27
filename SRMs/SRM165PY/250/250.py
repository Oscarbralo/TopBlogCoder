import math,string,itertools,fractions,heapq,collections,re,array,bisect,random

class BritishCoins:
    def coins(self, pence):
        result = []
        result.append(int(pence / (20 * 12)))
        result.append(int((pence % (20 * 12)) / 12))
        result.append(int((pence % (20 * 12)) % 12))
        return result