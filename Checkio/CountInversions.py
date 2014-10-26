def count_inversion(sequence):
    res = []
    for i in range(len(sequence)):
        res.append(sequence[i])
    count = 0
    i = 0
    while i < (len(res) - 1):
        j = i
        while res[j] > res[j + 1]:
            temp = res[j + 1]
            res[j + 1] = res[j]
            res[j] = temp
            count += 1
            j += 1
            i = -1
            if j + 1 >= len(res):
                break
        i += 1
    return count
    

if __name__ == '__main__':
    #These "asserts" using only for self-checking and not necessary for auto-testing
    assert count_inversion((1, 2, 5, 3, 4, 7, 6)) == 3, "Example"
    assert count_inversion((0, 1, 2, 3)) == 0, "Sorted"
    assert count_inversion((99, -99)) == 1, "Two numbers"
    assert count_inversion((5, 3, 2, 1, 0)) == 10, "Reversed"
