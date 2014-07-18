sum1 = sum([int(n) for n in input().split()])
sum2 = sum([int(n) for n in input().split()])
shelves = int(input())
while shelves > 0:
	if sum1 > 0:
		sum1 -= 5
	elif sum2 > 0:
		sum2 -= 10
if sum1 > 0 or sum2 > 0:
	print("NO")
else:
	print("YES")