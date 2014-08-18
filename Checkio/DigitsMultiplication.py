def checkio(number):
	strNumber = str(number).replace("0", "")
	result = 1
	for i in range(len(strNumber)):
		result *= int(strNumber[i])
	print(result)

#These "asserts" using only for self-checking and not necessary for auto-testing
if __name__ == '__main__':
    checkio(123405) == 120