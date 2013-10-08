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
	for(int i = 0; i < cases; i++)
	{
		int n = 0;
		cin >> n;
		vector <int> v (n, 0);
		int min = 0;
		int max = 0;
		for(int a = 0; a < n;a++)
			cin >> v[a];
		if(v.size() == 1)
			cout << "Case " << i + 1 << ": " << max << " " << min << endl;
		else 
		{
			for(int b = 1; b < v.size(); b++)
			{
				if(v[b] > v[b - 1])
					max++;
				else if(v[b] < v[b - 1])
					min++;
			}
			cout << "Case " << i + 1 << ": " << max << " " << min << endl;
		}
	}
	return 0;
}

