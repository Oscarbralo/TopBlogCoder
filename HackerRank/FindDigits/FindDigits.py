def main():
	cases = int(input())
	for i in range(cases):
		result = 0
		number = input()
		n = int(number)
		for a in range(len(number)):
			if number[a] != "0":
				if n % int(number[a]) == 0:
					result += 1
		print(result)

if __name__ == "__main__":
	main()