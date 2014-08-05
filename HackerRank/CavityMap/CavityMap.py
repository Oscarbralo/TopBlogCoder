def main():
	length = int(input())
	board = []
	result = []
	for i in range(length):
		board.append(input())
	result.append(board[0])
	for i in range(1, len(board) - 1):
		result.append(board[i][0])
		for a in range(1, len(board[i]) - 1):
			mid = int(board[i][a])
			top = int(board[i - 1][a])
			right = int(board[i][a + 1])
			bottom = int(board[i + 1][a])
			left = int(board[i][a - 1])
			if mid > top and mid > right and mid > bottom and mid > left:
				result[i] += "X"
			else:
				result[i] += board[i][a]
		result[i] += board[i][-1]
	if length != 1:
		result.append(board[-1])
	for i in range(len(result)):
		print(result[i])


if __name__ == "__main__":
	main()

