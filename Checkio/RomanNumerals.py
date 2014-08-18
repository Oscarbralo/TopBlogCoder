def checkio(data):
    mil = ["M", "MM", "MMM"]
    cents = ["C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", ""]
    tens = ["X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", ""]
    units = ["I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", ""]
    roman = ""
    if len(str(data)) == 4:
        roman += mil[int(str(data)[0]) - 1]
        roman += cents[int(str(data)[1]) - 1]
        roman += tens[int(str(data)[2]) - 1]
        roman += units[int(str(data)[3]) - 1]
    if len(str(data)) == 3:
        roman += cents[int(str(data)[0]) - 1]
        roman += tens[int(str(data)[1]) - 1]
        roman += units[int(str(data)[2]) - 1]
    if len(str(data)) == 2:
        roman += tens[int(str(data)[0]) - 1]
        roman += units[int(str(data)[1]) - 1]
    if len(str(data)) == 1:
        roman += units[int(str(data)[0]) - 1]
    print(roman)

if __name__ == '__main__':
    checkio(3888) == 'MMMDCCCLXXXVIII', '3888'