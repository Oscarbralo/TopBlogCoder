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
	for(int i = 0; i < cases; i++)
	{
		int farmers = 0;
		cin >> farmers;
		int result = 0;
		for(int a = 0; a < farmers;a++)
		{
			double square = 0;
			double animals = 0;
			double bill = 0;
			cin >> square >> animals >> bill;
			double temp = square / animals;
			temp *= bill;
			temp *= animals;
			result += ceil(temp);
		}
		cout << result << endl;
	}
	return 0;
}

