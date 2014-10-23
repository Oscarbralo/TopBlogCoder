def letter_queue(commands):
    queue = []
    for i in range(len(commands)):
        splitt = commands[i].split(" ")
        if (splitt[0] == "PUSH"):
            queue.append(splitt[1])
        else:
            if (len(queue) > 0):
                element = queue.pop(0)
    return "".join(queue)

if __name__ == '__main__':
    #These "asserts" using only for self-checking and not necessary for auto-testing
    assert letter_queue(["PUSH A", "POP", "POP", "PUSH Z", "PUSH D", "PUSH O", "POP", "PUSH T"]) == "DOT", "dot example"
    assert letter_queue(["POP", "POP"]) == "", "Pop, Pop, empty"
    assert letter_queue(["PUSH H", "PUSH I"]) == "HI", "Hi!"
    assert letter_queue([]) == "", "Nothing"
