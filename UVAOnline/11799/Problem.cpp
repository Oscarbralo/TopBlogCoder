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
	string s;
	int x = 0;
	while(getline(cin, s))
	{
		if(x == 0)
		{
			x++;
			continue;
		}
		vector<int> v;
		istringstream ss (s);
		int max = 0;
		int n = 0;
		while(ss >> n)
		{
			if(n > max)
				max = n;
		}
		cout << "Case " << x << ": " << max << endl;
		x++;
	}
	return 0;
}

