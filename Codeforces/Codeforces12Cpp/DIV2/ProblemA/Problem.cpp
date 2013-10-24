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
	vector<string> v;
	string s;
	int x = 0;
	while(getline(cin, s))
	{
		v.push_back(s);
		x++;
		if(x == 3)break;
	}
	int last = v.size() - 1;
	bool finish = false;
	for(int a = 0; a < v.size(); a++)
	{
		for(int b = 0; b < v[a].size(); b++)
		{
			if(v[a][b] != v[last][v[0].size() - 1 - b])
			{
				finish = true;
				break;
			}
		}
		last--;
		if(finish)
			break;
	}
	if(finish)
		cout << "NO" << endl;
	else
		cout << "YES" << endl;
	return 0;
}

