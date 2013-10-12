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
		vector<string> cards (52, "");
		for(int a = 0; a < 52;a++)
			cin >> cards[a];
		cout << "Case " << i + 1 << ": " << cards[32] << endl;
	}
	return 0;
}

