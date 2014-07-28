def main():
	l = int(input())
	r = int(input())
	result = 0
	for i in range(l, r + 1):
		for a in range(i, r + 1):
			result = max(result, i ^ a)
	print(result)

if __name__ == "__main__":
	main()