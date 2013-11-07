class Time:
    def whatTime(self, seconds):
        return str(seconds / 60) + ":" + str((seconds % 60) / 60) + ":" + str((seconds % 60) % 60)
