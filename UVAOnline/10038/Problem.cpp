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
	while(getline(cin, s))
	{
		vector<int> v;
		bool finish = true;
		stringstream temp;
		string ss;
		temp << s;
		while(temp >> ss)
			v.push_back(atoi(ss.c_str()));
		if(v[0] == 1)
			finish = true;
		else
		{
			vector<bool> v2 (v.size() - 1, false);
			for(int i = 1; i < v.size() - 1; i++)
			{
				int diff = abs(v[i] - v[i + 1]);
				if(diff >= 1 && diff <= v[0] - 1)
				{
					v2[diff] = true;
				}
			}
			for(int a = 1; a < v2.size(); a++)
			{
				if(v2[a] == false)
				{
					finish = false;
					break;
				}
			}
		}
		if(finish)
			cout << "Jolly" << endl;
		else
			cout << "Not jolly" << endl;
	}
	return 0;
}

