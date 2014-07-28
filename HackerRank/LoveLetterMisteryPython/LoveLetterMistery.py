def main():
	cases = int(input())
	for a in range(cases):
		abc = "abcdefghijklmnopqrstuvwxyz"
		result = 0
		word = input()
		j = -1
		for i in range(int(len(word) / 2)):
			if abc.index(word[i]) > abc.index(word[j]):
				result += abc.index(word[i]) - abc.index(word[j])
			else:
				result += abc.index(word[j]) - abc.index(word[i])
			j -= 1
		print(result)

def isPalindrome(word):
	j = -1
	for i in range(int(len(word) / 2)):
		if word[i] != word[j]:
			return False
		j -= 1
	return True

if __name__ == "__main__":
	main()