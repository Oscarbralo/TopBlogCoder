import math,string,itertools,fractions,heapq,collections,re,array,bisect,random

class WidgetRepairs:
    def days(self, arrivals, numPerDay):
        newList = []
        for item in arrivals:
            newList.append(item)
        totalDays = 0
        length = len(arrivals)
        last = 0
        for arrival in newList:
            if last > 0:
                arrival += last
            if arrival != 0:
                last = arrival - numPerDay
                totalDays += 1
        if last > 0:
            totalDays += math.ceil(int(last / numPerDay))
            if last % numPerDay > 0:
                totalDays += 1
        return totalDays