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
	int cases = 0;
	cin >> cases;
	for (int a = 0; a < cases; a++)
	{
		int number = 0;
		cin >> number;
		number *= 567;
		number /= 9;
		number += 7492;
		number *= 235;
		number /= 47;
		number -= 498;
		stringstream s;
		s << number;
		string temp = "";
		temp = s.str();
		cout << temp[temp.length() - 2] << endl;
	}
	return 0;
}

