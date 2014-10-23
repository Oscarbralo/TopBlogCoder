def checkio(expression):
    a = ["(", ")"]
    b = ["{", "}"]
    c = ["[", "]"]
    last = []
    countList = -1
    for i in range(len(expression)):
        if (expression[i] == "(" or expression[i] == ")" or expression[i] == "{" or expression[i] == "}" or expression[i] == "[" or expression[i] == "]"):
            if (len(last) == 0):
                last.append(expression[i])
                countList += 1
            else:
                if (expression[i] in a and last[countList] in a):
                    last.pop(countList)
                    countList -= 1
                elif (expression[i] in b and last[countList] in b):
                    last.pop(countList)
                    countList -= 1
                elif (expression[i] in c and last[countList] in c):
                    last.pop(countList)
                    countList -= 1
                else:
                    last.append(expression[i])
                    countList += 1
            
    if (len(last) == 0):
        return True
    else:
        return False

#These "asserts" using only for self-checking and not necessary for auto-testing
if __name__ == '__main__':
    assert checkio("((5+3)*2+1)") == True, "Simple"
    assert checkio("{[(3+1)+2]+}") == True, "Different types"
    assert checkio("(3+{1-1)}") == False, ") is alone inside {}"
    assert checkio("[1+1]+(2*2)-{3/3}") == True, "Different operators"
    assert checkio("(({[(((1)-2)+3)-3]/3}-3)") == False, "One is redundant"
    assert checkio("2+3") == True, "No brackets, no problem"
