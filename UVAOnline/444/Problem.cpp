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
	string n = "0123456789";
	string s;
	while(getline(cin, s))
	{
		string result;
		if(n.find(s[0]) == -1)
		{
			for(int i = 0; i < s.length(); i++)
			{
				int temp = static_cast<int>(s[i]);
				stringstream ss;
				ss << temp;
				string t = ss.str();
				string res = string(t.rbegin(),t.rend());
				result.insert(0, res);
			}
		}
		else
		{
			for(int i = s.length() - 1; i >= 0; i--)
			{
				string temp;
				if(s[i] == '1')
				{
					temp = s.substr(i - 2, 3);
					i -= 2;
				}
				else
				{
					temp = s.substr(i - 1, 2);
					i--;
				}
				stringstream ss;
				ss << string(temp.rbegin(),temp.rend());
				int x = atoi(ss.str().c_str());
				char c = (char)x;
				result += c;
			}
		}
		cout << result << endl;
	}
	return 0;
}

