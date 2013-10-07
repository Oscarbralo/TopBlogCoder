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
	while(getline(cin, s))
	{
		int cases = atoi(s.c_str());
		if(s == "")
			continue;
		if(cases == 0)
			break;
		else
		{
			int pointX = 0;
			int pointY = 0;
			cin >> pointX >> pointY;
			for(int a = 0; a < cases;a++)
			{
				int x = 0;
				int y = 0;
				cin >> x >> y;
				if(x == pointX || y == pointY)
					cout << "divisa" << endl;
				else if(x > pointX && y > pointY)
					cout << "NE" << endl;
				else if(x > pointX && y < pointY)
					cout << "SE" << endl;
				else if(x < pointX && y > pointY)
					cout << "NO" << endl;
				else if(x < pointX && y < pointY)
					cout << "SO" << endl;
			}
		}
	}
	return 0;
}

