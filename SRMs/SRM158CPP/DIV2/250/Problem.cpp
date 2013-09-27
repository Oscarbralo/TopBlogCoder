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

class TireRotation {
public:
	int getCycle(string initial, string current) {
		vector<char> init;
		vector<char> curr;
		if(initial == current)
			return 1;
		for (int a = 0; a < initial.size(); a++)
		{
			init.push_back(initial[a]);
			curr.push_back(current[a]);
		}
		int result = 0;
		for (int i = 0; i < 4; i++)
		{
			char one = init[0];
			char two = init[1];
			char three = init[2];
			char four = init[3];
			init[0] = four;
			init[1] = three;
			init[2] = one;
			init[3] = two;
			result++;
			int count = 0;
			for (int b = 0; b < init.size(); b++)
			{
				if(init[b] == curr[b])
					count++;
			}
			if(count == 4)
				return result + 1;
		}
		return -1;
	}
};

int main()
{
	TireRotation t;
	int result = t.getCycle("ABCD", "ABDC");
	cout << result << endl;
	return 0;
}

