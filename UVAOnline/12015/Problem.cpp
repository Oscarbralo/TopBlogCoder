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
	int cases = 0;
	cin >> cases;
	for(int a = 0; a < cases; a++)
	{
		vector<string> webs;
		vector<int> totals;
		int max = 0;
		for(int i = 0; i < 10; i++)
		{
			string web = "";
			int num = 0;
			cin >> web >> num;
			webs.push_back(web);
			totals.push_back(num);
			if(num > max )
				max = num;
		}
		cout << "Case #" << a + 1 << ":" << endl;
		for(int b = 0; b < totals.size();b++)
		{
			if(totals[b] == max)
				cout << webs[b] << endl;
		}
	}
	return 0;
}

