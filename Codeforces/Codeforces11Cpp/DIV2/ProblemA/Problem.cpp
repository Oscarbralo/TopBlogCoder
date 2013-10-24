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

int main()
{
	int result = 0;
	int numbers = 0;
	int add = 0;
	cin >> numbers >> add;
	int last = 0;
	for(int i = 0; i < numbers; i++)
	{
		int temp = 0;
		cin >> temp;
		if(i == 0)
			last = temp;
		else
		{
			if(temp == last)
			{
				result++;
				last = temp + add;
			}
			else if(temp < last)
			{
				int t1 = last - temp;
				if(t1 % add >= 1)
				{
					result += (t1 / add) + 1;
					last = temp + ((t1 / add) + 1) * add;
				}
				else
				{
					result += t1 / add;
					if(temp + t1 == last)
					{
						last = (temp + (t1 / add) * add) + add;
						result++;
					}
					else
						last = temp + (t1 / add) * add;
				}
			}
			else
				last = temp;
		}
	}
	cout << result << endl;
	return 0;
}

