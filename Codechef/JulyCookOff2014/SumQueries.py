temp = input().split()
n = int(temp[0])
queries = int(temp[1])
a = range(1, n + 1)
b = range(n + 1, (n * 2) + 1)
for i in range(queries):
    query = input()
    if int(query) <= n + 1:
        print(0)
    elif int(query) <= (2 * n + 1):
        print(int(query) - n - 1)
    else:
        print((3 * n) - int(query) + 1)