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
	string temp = "";
	int sets = 1;
	cin>> temp;
	while(temp != "0")
	{
		int nums = atoi(temp.c_str());
		vector<int> v (nums, 0);
		int sum = 0;
		for(int i = 0; i < nums; i++)
		{
			cin >> v[i];
			sum += v[i];
		}
		int med = sum / nums;
		int result = 0;
		int box = 0;
		int down = 0;
		for(int a = 0; a < v.size(); a++)
		{
			int n = 0;
			result += abs(v[a] - med);
			if(v[a] > med)
				down += v[a] - med;
		}
		cout << "Set #" << sets << endl;
		cout << "The minimum number of moves is " << result << ".\n" << endl;
		cin >> temp;
		sets++;
	}
	return 0;
}

