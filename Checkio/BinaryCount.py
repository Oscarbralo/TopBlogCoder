def checkio(number):
    print(bin(number).count('1'))

#These "asserts" using only for self-checking and not necessary for auto-testing
if __name__ == '__main__':
    checkio(1022) == 9