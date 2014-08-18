def checkio(str_number, radix):
    try:
        print(int(str_number, radix))
    except:
        print(-1)

#These "asserts" using only for self-checking and not necessary for auto-testing
if __name__ == '__main__':
    checkio("AF", 16) == 175, "Hex"
    checkio("101", 2) == 5, "Bin"
    checkio("101", 5) == 26, "5 base"
    checkio("Z", 36) == 35, "Z base"
    checkio("AB", 10) == -1, "B > A > 10"