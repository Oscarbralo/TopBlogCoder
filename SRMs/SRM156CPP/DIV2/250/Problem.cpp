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

class DiskSpace {
public:
	int minDrives(vector <int> used, vector <int> total) {
		sort(total.begin(), total.end());
		int totalSpace = 0;
		int result = 0;
		for(int a = 0; a < used.size(); a++)
			totalSpace += used[a];
		int last = total.size() - 1;
		while(totalSpace > 0)
		{
			totalSpace -= total[last];
			result++;
			last--;
		}
		return result;
	}
};

int main()
{
	DiskSpace d;
	int a[] = {300,525,110};
    vector<int> v (a, a + 3);
	int b[] = {350,600,115};
	vector<int> v1 (b, b + 3);
	int result = d.minDrives(v, v1);
	cout << result << endl;
	return 0;
}

