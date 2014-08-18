def count_words(text, words):
    result = []
    for temp in words:
    	if temp in text.lower():
    		result.append(temp)
    res = set(result)
    print(len(res))


if __name__ == '__main__':
    count_words("How aresjfhdskfhskd you?", {"how", "are", "you", "hello"}) == 3, "Example"
