def checkio(number):
    cents = ["one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred"]
    decs = ["ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"]
    units = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"]
    temp = -1
    result = ""
    if len(str(number)) == 3:
        if str(number)[0] != "0":
            result += cents[int(str(number)[0]) - 1] + " "
        if str(number)[1] == "1":
            tens = ["eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "ten"]
            result += tens[int(str(number)[2]) - 1] + " "
        else:
            if str(number)[1] != "0":
                result += decs[int(str(number)[1]) - 1] + " "
            if str(number)[2] != "0":
                result += units[int(str(number)[2]) - 1]
    elif len(str(number)) == 2:
        if str(number)[0] == "1":
            tens = ["eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "ten"]
            result += tens[int(str(number)[1]) - 1] + " "
        else:
            if str(number)[0] != "0":
                result += decs[int(str(number)[0]) - 1] + " "
            if str(number)[1] != "0":
                result += units[int(str(number)[1]) - 1] + " "
    else:
        result += units[int(str(number)[0]) - 1]
    print(result.strip())


if __name__ == "__main__":
    checkio(312)