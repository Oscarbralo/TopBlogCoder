def checkio(number):
    step = 1
    birds = []
    while number > 0:
        birds += [0] * step
        for i in range(len(birds)):
            if number == 0:
                break
            if birds[i] < 1:
                birds[i] += 1
            number -= 1
        step += 1
    print(birds.count(1))


if __name__ == '__main__':
    #These "asserts" using only for self-checking and not necessary for auto-testing
    checkio(5)