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
		string res;
		istringstream ss(s);
		string c;
		while(ss >> c)
		{
			for(int i = c.length() - 1; i >= 0; i--)
				res += c[i];
			res += " ";
		}
		res.erase(res.length() - 1, 1);
		cout << res << endl;
	}
	return 0;
}

