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

class YahtzeeScore {
public:
	int maxPoints(vector <int> toss) {
		int max = 0;
		for(int a = 0; a < toss.size(); a++)
		{
			int count = toss[a];
			for(int b = 0; b < toss.size(); b++)
			{
				if(a != b && toss[b] == toss[a])
				{
					count += toss[b];
				}
			}
			if(count > max)
				max = count;
		}
		cout << max << endl;
		return 0;
	}
};

int main()
{
	vector<int> v;
	v.push_back(5);
	v.push_back(3);
	v.push_back(5);
	v.push_back(3);
	v.push_back(3);
	YahtzeeScore y;
	cout << y.maxPoints(v) << endl;
	return 0;
}

