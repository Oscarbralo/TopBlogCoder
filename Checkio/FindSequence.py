def checkio(matrix):
    for row in range(len(matrix)):
        for col in range(len(matrix[row])):
            if (col + 1 < len(matrix[0])):
                i = 1
                count = 1
                while (col + i < len(matrix[0])):
                    if matrix[row][col + i] == matrix[row][col]:
                        count += 1
                        i += 1
                    else:
                        break
                    if count == 4:
                        return True
            if (row + 1 < len(matrix)):
                i = 1
                count = 1
                while (row + i < len(matrix)):
                    if matrix[row + i][col] == matrix[row][col]:
                        count += 1
                        i += 1
                    else:
                        break
                    if count == 4:
                        return True  
            if (col + 1 < len(matrix[0]) and row + 1 < len(matrix)):
                i = 1
                count = 1
                while (col + i < len(matrix[0]) and row + i < len(matrix)):
                    if matrix[row + i][col + i] == matrix[row][col]:
                        count += 1
                        i += 1
                    else:
                        break
                    if count == 4:
                        return True
            if (col - 1 >= 0 and row + 1 < len(matrix)):
                i = 1
                count = 1
                while (col - i >= 0 and row + i < len(matrix)):
                    if matrix[row + i][col - i] == matrix[row][col]:
                        count += 1
                        i += 1
                    else:
                        break
                    if count == 4:
                        return True
    return False

if __name__ == '__main__':
    #These "asserts" using only for self-checking and not necessary for auto-testing
    assert checkio([
        [1, 2, 1, 1],
        [1, 1, 4, 1],
        [1, 3, 1, 6],
        [1, 7, 2, 5]
    ]) == True, "Vertical"
    assert checkio([
        [7, 1, 4, 1],
        [1, 2, 5, 2],
        [3, 4, 1, 3],
        [1, 1, 8, 1]
    ]) == False, "Nothing here"
    assert checkio([
        [2, 1, 1, 6, 1],
        [1, 3, 2, 1, 1],
        [4, 1, 1, 3, 1],
        [5, 5, 5, 5, 5],
        [1, 1, 3, 1, 1]
    ]) == True, "Long Horizontal"
    assert checkio([
        [7, 1, 1, 8, 1, 1],
        [1, 1, 7, 3, 1, 5],
        [2, 3, 1, 2, 5, 1],
        [1, 1, 1, 5, 1, 4],
        [4, 6, 5, 1, 3, 1],
        [1, 1, 9, 1, 2, 1]
    ]) == True, "Diagonal"
