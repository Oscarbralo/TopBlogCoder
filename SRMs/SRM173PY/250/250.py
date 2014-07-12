import math,string,itertools,fractions,heapq,collections,re,array,bisect,random

class ProgressBar:
    def showProgress(self, taskTimes, tasksCompleted):
        totalSum = sum(taskTimes)
        completedSum = sum(taskTimes[0:tasksCompleted])
        temp = float(completedSum / totalSum)
        result = int(20.0 * temp)
        resto = 0
        if result == 0:
            resto = 20
        else:
            resto = 20 - result
        completed = ""
        while result > 0:
            completed += "#"
            result -= 1
        while resto > 0:
            completed += "."
            resto -= 1
        return completed