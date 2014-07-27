class ExerciseMachine:
    def getPercentages(self, time):
        totalTimes = 0
        seconds = 0
        temp = time.split(":")
        seconds += int(temp[0]) * 3600
        seconds += int(temp[1]) * 60
        seconds += int(temp[2])
        stepPercentage = int(str(seconds)[-2:])
        completed = 0
        for i in range(99):
            completed += stepPercentage
            if completed % 100 == 0:
                totalTimes += 1
        return totalTimes