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

class LCMRange {
public:
	int lcm(int first, int last) {
		int res = first;
		for(int a = first; a <= 27720; a++)
		{
			bool finish = true;
			for(int b = first; b <= last; b++)
			{
				if(a % b != 0)
				{
					finish = false;
					break;
				}
			}
			if(finish)
			{
				res = a;
				break;
			}
		}
		return res;
	}
};

int main()
{
	return 0;
}

