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
	int cases = 0;
	cin >> cases;
	vector<string> res;
	res.push_back("Lumberjacks:");
	for(int i = 0; i < cases; i++)
	{
		vector<int> v (10, 0);
		for(int a = 0; a < 10;a++)
			cin >> v[a];
		int sortedFront = 0;
		int sortedRev = 0;
		for(int b = 1; b < v.size();b++)
		{
			if(v[b] > v[b - 1])
				sortedFront++;
		}
		for(int c = v.size() - 2; c >= 0;c--)
		{
			if(v[c]  > v[c + 1])
				sortedRev++;
		}
		if(sortedFront == 9 || sortedRev == 9)
			res.push_back("Ordered");
		else
			res.push_back("Unordered");
	}
	for (int i = 0; i < res.size(); i++)
		cout << res[i] << endl;
	return 0;
}

