def count_neighbours(grid, row, col):
    neig = 0
    if (col - 1 >= 0):
        if (grid[row][col - 1] == 1):
            neig += 1
    if (col - 1 >= 0 and row - 1 >= 0):
        if (grid[row - 1][col -1] == 1):
            neig += 1
    if (row - 1 >= 0):
        if (grid[row - 1][col] == 1):
            neig += 1
    if (col + 1 < len(grid[0]) and row - 1 >= 0):
        if (grid[row - 1][col + 1] == 1):
            neig += 1
    if (col + 1 < len(grid[0])):
        if (grid[row][col + 1] == 1):
            neig += 1
    if (col + 1 < len(grid[0]) and row + 1 < len(grid)):
        if (grid[row + 1][col + 1] == 1):
            neig += 1
    if (row + 1 < len(grid)):
        if (grid[row + 1][col] == 1):
            neig += 1
    if (col - 1 >= 0 and row + 1 < len(grid)):
        if (grid[row + 1][col - 1] == 1):
            neig += 1
    return neig


if __name__ == '__main__':
    #These "asserts" using only for self-checking and not necessary for auto-testing
    assert count_neighbours(((1, 0, 0, 1, 0),
                             (0, 1, 0, 0, 0),
                             (0, 0, 1, 0, 1),
                             (1, 0, 0, 0, 0),
                             (0, 0, 1, 0, 0),), 1, 2) == 3, "1st example"
    assert count_neighbours(((1, 0, 0, 1, 0),
                             (0, 1, 0, 0, 0),
                             (0, 0, 1, 0, 1),
                             (1, 0, 0, 0, 0),
                             (0, 0, 1, 0, 0),), 0, 0) == 1, "2nd example"
    assert count_neighbours(((1, 1, 1),
                             (1, 1, 1),
                             (1, 1, 1),), 0, 2) == 3, "Dense corner"
    assert count_neighbours(((0, 0, 0),
                             (0, 1, 0),
                             (0, 0, 0),), 1, 1) == 0, "Single"
