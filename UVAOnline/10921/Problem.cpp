// TCTemplate.cpp: define el punto de entrada de la aplicación de consola.
//

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
	string temp = "0123456789-";
	const char* nums[] = {"", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"};
	vector<string> v (nums, nums + 10);
	string s;
	while(getline(cin, s))
	{
	string result;
	for(int i = 0; i < s.length(); i++)
	{
		if(temp.find(s[i]) != -1)
			result += s[i];
		else
		{
			for (int a = 2; a < v.size(); a++)
			{
				if(v[a].find(s[i]) != -1)
				{
					stringstream ss;
					ss << a;
					result += ss.str();
					break;
				}
			}
		}
	}
	cout << result << endl;
	}
	return 0;
}



