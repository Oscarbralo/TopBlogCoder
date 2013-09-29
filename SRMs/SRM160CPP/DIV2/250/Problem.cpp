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

class Substitute {
public:
	int getValue(string key, string code) {
		int result = 0;
		for(int i = 0; i < code.length(); i++)
		{
			bool x = false;
			int temp = key.find(code[i]);
			if(temp == 9)
			{
				temp = 0;
				x = true;
			}
			if(temp != -1)
			{
				if(temp == 0 && x)
					result = (result * 10) + temp;
				else
					result = (result * 10) + (temp + 1);
			}
		}
		return result;
	}
};

int main()
{
	Substitute x;
	int result = x.getValue("ABCDEFGHIJ","IXJYXIJAX");
	cout << result << endl;
	return 0;
}

