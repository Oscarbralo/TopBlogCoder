class DinkyFish:
    def monthsUntilCrowded(self, tankVolume, maleNum, femaleNum):
        months = 0
        while maleNum + femaleNum <= (tankVolume * 2):
            minFishes = min(maleNum, femaleNum)
            maleNum += minFishes
            femaleNum += minFishes
            months += 1
        return months