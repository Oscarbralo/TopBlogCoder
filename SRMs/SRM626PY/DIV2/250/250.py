import math,string,itertools,fractions,heapq,collections,re,array,bisect,random

class SumOfPower:
    def findSum(self, array):
        totalSum = 0
        lenght = len(array)
        for i in range(lenght):
            for x in range(i, lenght + 1):
                temp = array[i:x]
                totalSum += sum(temp)
        return totalSum