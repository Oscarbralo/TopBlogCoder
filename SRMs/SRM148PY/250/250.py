import math,string,itertools,fractions,heapq,collections,re,array,bisect,random

class DivisorDigits:
    def howMany(self, number):
    	result = 0
        for n in number:
        	if number % n == 0:
        		result += 1
        return result