def checkio(words_set):
    isFinish = False
    for word in words_set:
    	tempResult = 0
    	for checkWord in words_set:
    		if word.endswith(checkWord):
    			tempResult += 1
    	if tempResult > 1:
    		isFinish = True
    		break
    if isFinish:
    	print("True")
    else:
    	print("False")

#These "asserts" using only for self-checking and not necessary for auto-testing
if __name__ == '__main__':
    checkio({"hello", "he"}) == True, "helLO"