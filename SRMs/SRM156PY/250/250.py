import math,string,itertools,fractions,heapq,collections,re,array,bisect,random

class DiskSpace:
    def minDrives(self, used, total):
        totalSum = sum(used)
        total = sorted(total, reverse=True)
        result = 0
        index = 0
        while totalSum > 0:
        	totalSum -= total[index]
        	index += 1
        	result += 1
        return result