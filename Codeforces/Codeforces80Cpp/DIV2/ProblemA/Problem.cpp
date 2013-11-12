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

bool isPrime(int n)
{
	if(n <= 1) { return false; };
	if(n == 2) { return true; };
	if(n % 2 == 0) { return false; };
	int m = sqrt(n);
	for(int i = 3; i <= m; i += 2)
		if(n % i == 0) {return false; };
	return true;
}

int main()
{
	int first;
	int second;
	cin >> first >> second;
	bool result = false;
	for(int i = first + 1; i <= second; i++)
	{
		if(isPrime(i))
		{
			result = (i == second) ? true : false;
			break;
		}
	}
	if(result)
		cout << "YES" << endl;
	else
		cout << "NO" << endl;
	return 0;
}



