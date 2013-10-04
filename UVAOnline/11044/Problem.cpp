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
	for(int a = 0; a < cases; a++)
	{
		int x;
		int y;
		cin >> x >> y;
		int res = x / 3;
		res *= y / 3;
		cout << res << endl;
	}
	return 0;
}

