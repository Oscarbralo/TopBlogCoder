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

class StreetParking {
public:
	int freeParks(string street) {
		string finalStreet = "..." + street + "...";
		int result = 0;
		for(int a = 3; a < finalStreet.length() - 3; a++)
		{
			if(finalStreet[a] == '-')
			{
				if(finalStreet[a + 1] != 'B' && finalStreet[a + 2] != 'B')
				{
					if(finalStreet[a - 1] != 'S' && finalStreet[a + 1] != 'S')
						result++;
				}
			}
		}
		return result;
	}
};

int main()
{
	StreetParking x;
	int result = x.freeParks("---B--S-D--S--");
	cout << result << endl;
	return 0;
}

