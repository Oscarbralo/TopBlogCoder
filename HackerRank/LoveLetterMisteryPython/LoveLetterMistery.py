def main():
	cases = int(input())
	for a in range(cases):
		abc = "abcdefghijklmnopqrstuvwxyz"
		result = 0
		word = input()
		j = -1
		for i in range(int(len(word) / 2)):
			result += abs(abc.index(word[i]) - abc.index(word[j]))
			j -= 1
		print(result)

if __name__ == "__main__":
	main()