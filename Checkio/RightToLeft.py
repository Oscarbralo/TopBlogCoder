def left_join(phrases):
    print(",".join(phrases).replace("right", "left"))

if __name__ == '__main__':
    left_join(("bright aright", "ok")) == "bleft aleft,ok", "Bright Left"