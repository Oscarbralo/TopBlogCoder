// TopCoderCppTemplate.cpp : Defines the entry point for the console application.
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

class WidgetRepairs {
public:
	int days(vector <int> arrivals, int numPerDay) {
		int result = 0;
		if(arrivals.size() == 1)
		{
			while(arrivals[0] > 0)
			{
				arrivals[0] -= numPerDay;
				result++;
			}
		}
		for(int a = 0; a < arrivals.size() - 1; a++)
		{
			if(arrivals[a] == 0)
				continue;
			if(arrivals[a] > numPerDay)
			{
				arrivals[a] -= numPerDay;
				result++;
				arrivals[a + 1] += arrivals[a];
				arrivals[a] = 0;
			}
			else
				result++;
		}
		while(arrivals[arrivals.size() - 1] > 0)
		{
			arrivals[arrivals.size() - 1] -= numPerDay;
			result++;
		}
		return result;
	}
};

int _tmain(int argc, _TCHAR* argv[])
{
	WidgetRepairs x;
	vector<int> v;
	v.push_back(6);
	v.push_back(5);
	v.push_back(4);
	v.push_back(3);
	v.push_back(2);
	v.push_back(1);
	v.push_back(0);
	v.push_back(0);
	v.push_back(1);
	v.push_back(2);
	v.push_back(3);
	v.push_back(4);
	v.push_back(5);
	v.push_back(6);
	int result = x.days(v, 3);
	std::cout << result << std::endl;
	return 0;
}

