def check_connection(network, first, second):
    areConnected = False
    friend1 = [first]
    friend2 = [second]
    for a in range(10):
        for i in range(len(network)):
            people = network[i].split('-')
            print(friend1)
            print(friend2)
            for a in range(len(friend1)):
                if friend1[a] in people[0]:
                    if people[1] not in friend1:
                        friend1.append(people[1])
                if friend1[a] in people[1]:
                    if people[0] not in friend1:
                        friend1.append(people[0])
            for a in range(len(friend2)):
                if friend2[a] in people[0]:
                    if people[1] not in friend2:
                        friend2.append(people[1])
                if friend2[a] in people[1]:
                    if people[0] not in friend2:
                        friend2.append(people[0])
    if first in friend2 or second in friend1:
        areConnected = True
    if areConnected:
        print("Connected")
    print("Not connected")



if __name__ == '__main__':
    #These "asserts" using only for self-checking and not necessary for auto-testing
    check_connection(("dr101-mr99","mr99-out00","dr101-out00","scout1-scout2",
        "scout3-scout1","scout1-scout4","scout4-sscout","sscout-super",),"super","scout2")