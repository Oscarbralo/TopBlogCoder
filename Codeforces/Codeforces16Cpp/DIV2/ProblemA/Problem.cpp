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
	int rows = 0;
	int columns = 0;
	cin >> rows >> columns;
	string last = " ";
	bool finish = false;
	for(int i = 0; i < rows; i++)
	{
		string s;
		cin >> s;
		int temp = 1;
		for(int a = 1; a < s.length(); a++)
		{
			if(s[a] == s[a - 1])
				temp++;
		}
		if(temp != s.length())
			finish = true;
		if(s[0] == last[0])
			finish = true;
		last = s;
	}
	if(finish)
		cout << "NO" << endl;
	else
		cout << "YES" << endl;
	return 0;
}

