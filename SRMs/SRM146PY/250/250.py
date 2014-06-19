import math,string,itertools,fractions,heapq,collections,re,array,bisect,random

class YahtzeeScore:
    def maxPoints(self, toss):
        max = 0
        for t in toss:
        	temp = 0;
        	for t2 in toss:
        		if t2 == t:
        			temp += t2
        	if temp > max:
        		max = temp
        return max