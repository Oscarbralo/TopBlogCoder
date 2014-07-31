def main():
	abc = "abcdefghijklmnopqrstuvwxyz"
	abcList = [0] * 26
	text = input()
	for i in range(len(text)):
		abcList[abc.index(text[i])] += 1
	odd = 0
	even = 0
	for i in range(len(abcList)):
		if abcList[i] != 0 and abcList[i] % 2 == 0:
			even += 1
		elif abcList[i] != 0 and abcList[i] % 2 == 1:
			odd += 1
	if even >= 0 and odd <= 1:
		print("YES")
	else:
		print("NO")

if __name__ == "__main__":
	main()