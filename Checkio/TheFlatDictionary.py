def flatten(dictionary):
    stack = [((), dictionary)]
    result = {}
    while stack:
        path, current = stack.pop()
        for k, v in current.items():
            if isinstance(v, dict):
                if len(v) == 0:
                    v[""] = ""
                stack.append((path + (k,), v))
            else:
                result["/".join((path + (k,))).strip("/")] = v
    print(result)

if __name__ == "__main__":
    flatten({"name": {
                        "first": "One",
                        "last": "Drone"},
                    "job": "scout",
                    "recent": {},
                    "additional": {
                        "place": {
                            "zone": "1",
                            "cell": "2"}}})