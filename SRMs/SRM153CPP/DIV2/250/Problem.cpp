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

class MostProfitable {
public:
	string bestItem(vector <int> costs, vector <int> prices, vector <int> sales, vector <string> items) {
		string res = "";
		int max = 0;
		for(int a = 0; a < costs.size(); a++)
		{
			int diff = prices[a] - costs[a];
			if(diff > 0)
			{
				diff *= sales[a];
				if(diff > max)
				{
					max = diff;
					res = items[a];
				}
			}
		}
		return res;
	}
};

int main()
{
	return 0;
}

