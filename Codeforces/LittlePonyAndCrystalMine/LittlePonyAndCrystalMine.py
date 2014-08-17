def main():
	d = "D"
	star  ="*"
	n = int(input())
	mid = int(n / 2)
	times = int(n / 2)
	timesD = 1
	diamond = []
	for i in range(n):
		if i < mid:
			temp = (star * times) + (d * timesD) + (star * times)
			diamond.append(temp)
			times -= 1
			timesD += 2
		elif i == mid:
			temp = (d * timesD)
			diamond.append(temp)
		else:
			times += 1
			timesD -= 2
			temp = (star * times) + (d * timesD) + (star * times)
			diamond.append(temp)
	for i in range(len(diamond)):
		print(diamond[i])

if __name__ == "__main__":
	main()