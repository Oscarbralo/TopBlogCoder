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

class DivisorDigits {
public:
	int howMany(int number) {
		ostringstream convert;
		convert << number;
		string s = convert.str();
		int result = 0;
		for(int a = 0; a < s.length(); a++)
		{
			int n = s[a] - '0';
			if(n != 0)
			{
				if(number % n == 0)
					result++;
			}
		}
		return result;
	}
};

int main()
{
	DivisorDigits d;
	cout << d.howMany(661232) << endl;
	return 0;
}

