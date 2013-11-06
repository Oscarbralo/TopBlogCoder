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
	int cases;
	cin >> cases;
	for(int i = 0; i < cases; i++)
	{
		int shops;
		cin >> shops;
		int minimum = 10000000;
		int maximum = 0;
		for(int a = 0; a < shops;a++)
		{
			int temp;
			cin >> temp;
			minimum = min(minimum, temp);
			maximum = max(maximum, temp);
		}
		cout << (maximum - minimum) * 2 << endl;
	}
	return 0;
}

