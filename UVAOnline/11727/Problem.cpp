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
		vector <int> list (3, 0);
		cin >> list[0] >> list[1] >> list[2];
		sort(list.begin(), list.end());
		cout << "Case " << i + 1 << ": " << list[1] << endl;
	}
	return 0;
}

