def checkio(n, m):
    count = 0
    res = n ^ m
    for element in str('{0:08b}'.format(res)):
        if element == '1':
            count += 1
    return count


if __name__ == '__main__':
    #These "asserts" using only for self-checking and not necessary for auto-testing
    assert checkio(117, 17) == 3, "First example"
    assert checkio(1, 2) == 2, "Second example"
    assert checkio(16, 15) == 5, "Third example"
