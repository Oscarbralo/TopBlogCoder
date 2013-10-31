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
		for(int i = 0; i < message.length(); i++)
		{
			stringstream l;
			l << result[0][i];
			stringstream m;
			m << result[0][i + 1];
			middle = message[i];
			int diff = atoi(middle.c_str()) - (atoi(l.str().c_str()) + atoi(m.str().c_str()));
			if(i == message.length() - 1)
			{
				if(diff != 0)
					result[0] = "NONE";
				break;
			}
			if(diff == 0)
				result[0] += "0";
			else if(diff == 1)
				result[0] += "1";
			else
			{
				result[0] = "NONE";
				break;
			}
		}
		if(result[0] != "NONE")
			result[0].erase(0, 1);
		for(int i = 0; i < message.length(); i++)
		{
			stringstream l;
			l << result[1][i];
			stringstream m;
			m << result[1][i + 1];
			middle = message[i];
			int diff = atoi(middle.c_str()) - (atoi(l.str().c_str()) + atoi(m.str().c_str()));
			if(i == message.length() - 1)
			{
				if(diff != 0)
					result[1] = "NONE";
				break;
			}
			if(diff == 0)
				result[1] += "0";
			else if(diff == 1)
				result[1] += "1";
			else
			{
				result[1] = "NONE";
				break;
			}
		}
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

