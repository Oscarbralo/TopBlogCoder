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

class Inchworm {
public:
	int lunchtime(int branch, int rest, int leaf) {
		int actual = 0;
		int res = 1;
		while(actual <= branch)
		{
			actual += rest;
			if(actual % leaf == 0)
				res++;
		}
		return res;
	}
};

int main()
{
	Inchworm x;
	int res = x.lunchtime(11, 2, 4);
	cout << res << endl;
	return 0;
}

