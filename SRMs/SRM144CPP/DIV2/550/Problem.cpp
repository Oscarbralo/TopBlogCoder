#include "stdafx.h"
#include <vector>
#include <list>
#include <map>
#include <set>
#include <queue>
#include <deque>
#include <stack>
#include <bitset>
#include <algorithm>
#include <functional>
#include <numeric>
#include <utility>
#include <sstream>
#include <iostream>
#include <iomanip>
#include <cstdio>
#include <cmath>
#include <cstdlib>
#include <ctime>

using namespace std;

class BinaryCode {
public:
	vector <string> decode(string message) {
		vector<string> result (2, "");
		result[0] += "00";
		result[1] += "01";
		int current = 0;
		string middle;
		string left;
		int index = 0;
		while(index != 2)
		{
			for(int i = 0; i < message.length(); i++)
			{
				stringstream l;
				l << result[index][i];
				stringstream m;
				m << result[index][i + 1];
				middle = message[i];
				int diff = atoi(middle.c_str()) - (atoi(l.str().c_str()) + atoi(m.str().c_str()));
				if(i == message.length() - 1)
				{
					if(diff != 0)
						result[index] = "NONE";
					break;
				}
				if(diff == 0)
					result[index] += "0";
				else if(diff == 1)
					result[index] += "1";
				else
				{
					result[index] = "NONE";
					break;
				}
			}
			index++;
		}
		if(result[0] != "NONE")
			result[0].erase(0, 1);
		if(result[1] != "NONE")
			result[1].erase(0, 1);
		return result;
	}
};

int main()
{
	BinaryCode b;
	vector<string> res = b.decode("123210122");
	return 0;
}

