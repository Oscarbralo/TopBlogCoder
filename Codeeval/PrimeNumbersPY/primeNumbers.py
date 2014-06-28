import fileinput
import sys
import math
 
def gen_primes(limit):
    assert limit < 4294967295
    primes = [2]
    for n in range(1, limit, 2):
        if isPrime(n):
            primes.append(n)
    return ','.join(map(str, primes)) 

def isPrime(n):
    if n <= 1 or n % 2 == 0:
        return False
    if n == 2:
        return True
    m = int(math.sqrt(n))
    for i in range(3, m + 1, 2):
        if n % i == 0:
            return False
    return True
 
if __name__ == '__main__':
    for line in fileinput.input():
        print(gen_primes(int(line)))