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

class ProfitCalculator {
public:
	int percent(vector <string> items) {
		int result = 0;
		double price = 0.0;
		double cost = 0.0;
		for(int a = 0; a < items.size(); a++)
		{
			istringstream ss(items[a].substr(0,6));
			double x = 0;
			ss >> x;
			price += x;
			istringstream sss(items[a].substr(7,6));
			double xx = 0;
			sss >> xx;
			cost += xx;
		}
		double tot = price - cost;
		double res = (tot * 100) / price;
		result = res;
		return result;
	}
};

int main()
{
	ProfitCalculator x;
	vector<string> v;
	v.push_back("012.99 008.73");
	v.push_back("099.99 050.00");
	v.push_back("123.45 101.07");
	int res = x.percent(v);
	cout << res << endl;
	return 0;
}

