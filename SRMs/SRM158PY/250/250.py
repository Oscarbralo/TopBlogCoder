import math,string,itertools,fractions,heapq,collections,re,array,bisect,random

class TireRotation:
    def getCycle(self, initial, current):
        if initial == current:
        	return 1
        init = [initial[0], initial[1], initial[2], initial[3]]
        initStr = ""
        result = 1
        while initStr != current:
        	initStr = ""
        	temp1 = init[2]
        	init[2] = init[0]
        	init[0] = init[3]
        	temp2 = init[1]
        	init[1] = temp1
        	temp3 = init[3]
        	init[3] = temp2
        	initStr += init[0] + init[1] + init[2] + init[3]
        	result += 1
        return result