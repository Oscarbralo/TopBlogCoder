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
		string res = "";
		for(int i = 0; i < s.length(); i++)
		{
			int temp = static_cast<int>(s[i]) - 7;
			res += static_cast<char>(temp);
		}
		cout << res << endl;
	}
	return 0;
}

