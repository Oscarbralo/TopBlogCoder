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
	string s;
	while(getline(cin, s))
	{
		if(s == "0")
			continue;
		int len = s.length();
		string res = s;
		while(len > 1)
		{
			int temp = 0;
			for(int a = 0; a < res.length(); a++)
			{
				stringstream ss;
				ss << res[a];
				temp += atoi(ss.str().c_str());
			}
			stringstream numTemp;
			numTemp << temp;
			res = numTemp.str();
			len = res.length();
		}
		cout << res << endl;
	}
	return 0;
}

