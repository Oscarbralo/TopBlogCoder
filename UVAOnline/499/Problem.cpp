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
	string abc = "abcdefghijklmnopqrstuvwxyz";
	string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	string s;
	while(getline(cin,s))
	{
		vector<int> lower (26,0);
		vector<int> upper (26,0);
		string result;
		int max = 0;
		for(int a = 0; a < s.length(); a++)
		{
			int x = abc.find(s[a]);
			int xx = ABC.find(s[a]);
			if(x != -1)
			{
				lower[x]++;
				if(lower[x] > max)
					max = lower[x];
			}
			if(xx != -1)
			{
				upper[xx]++;
				if(upper[xx] > max)
					max = upper[xx];
			}
			else
				continue;
		}
		for(int b = 0; b < upper.size(); b++)
		{
			if(upper[b] == max)
				result.push_back(ABC[b]);
		}
		for(int c = 0; c < lower.size(); c++)
		{
			if(lower[c] == max)
				result.push_back(abc[c]);
		}
		result.append(" ");
		stringstream sss;
		sss << result << max;
		cout << sss.str() << endl;
	}
	return 0;
}

