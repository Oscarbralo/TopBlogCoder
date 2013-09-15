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

class ImageDithering {
public:
	int count(string dithered, vector <string> screen) {
		int result = 0;
		for (int i = 0; i < dithered.length(); i++)
		{
			for(int a = 0; a < screen.size();a++)
			{
				for(int b = 0; b < screen[a].size();b++)
				{
					if(dithered[i] == screen[a][b])
						result++;
				}
			}
		}
		return result;
	}
};