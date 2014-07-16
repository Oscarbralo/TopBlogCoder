cases = int(input())
fib = [1, 1]
index = 1
while fib[index] + fib[index - 1] <= 40000000000000000:
    fib.append(fib[index] + fib[index - 1])
    index += 1

for i in range(cases):
    n = int(input())
    result = 0
    for i in range(1, len(fib)):
        if fib[i] > n:
            break
        if fib[i] % 2 == 0:
            result += fib[i]
    print(result)