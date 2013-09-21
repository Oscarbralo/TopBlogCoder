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
#include <sstream>

using namespace std;

class Quipu {
public:
	int readKnots(string knots) {
		int zeros = 0;
		string res = "";
		int num = 0;
		for(int i = 0; i < knots.length(); i++)
		{
			if(knots[i] == '-')
			{
				if(num > 0)
				{
					stringstream ss;
					ss << num;
					res += ss.str();
				}
				num = 0;
				zeros++;
				if(zeros > 1)
					res.push_back('0');
			}
			else
			{
				num++;
				zeros = 0;
			}
		}
		int result = atoi(res.c_str());
		return result;
	}
};



int main()
{
	Quipu x;
	int res = x.readKnots("-XX--XXXX---XXX-");
	cout << res << endl;
	return 0;
}

