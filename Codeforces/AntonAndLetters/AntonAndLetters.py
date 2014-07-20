text = input().replace(",", "").replace("{", "").replace("}", "").split()

result = []
for i in range(len(text)):
	if text[i] not in result:
		result.append(text[i])
print len(result)