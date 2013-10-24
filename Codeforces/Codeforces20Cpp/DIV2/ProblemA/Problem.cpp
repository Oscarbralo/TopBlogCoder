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

int main()
{
	string s;
	cin >> s;
	string result;
	bool temp = false;
	for(int i = 0; i < s.length(); i++)
	{
		if(s[i] == '/')
		{
			if(temp == false)
			{
				result += s[i];
				temp = true;
			}
		}
		else
		{
			temp = false;
			result += s[i];
		}
	}
	if(result[result.length() - 1] == '/' && result.length() != 1)
		result.erase(result.length() - 1, 1);
	cout << result << endl;
	return 0;
}

