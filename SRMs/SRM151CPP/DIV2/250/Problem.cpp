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

class PrefixCode {
public:
	string isOne(vector <string> words) {
		bool finish = true;
		int index = 10000000;
		for(int a = 0; a < words.size(); a++)
		{
			for(int b = 0; b < words.size(); b++)
			{
				if(a != b)
				{
					if(words[a].find(words[b]) == 0)
					{
						finish = false;
						if(b < index)
							index = b;
						continue;
					}
				}
			}
		}
		stringstream s;
		s << index;
		string temp = s.str();
		if(finish)
			return "Yes";
		else
			return "No, " + temp;
	}
};

int main()
{
	PrefixCode x;
	vector<string> v;
	v.push_back("10001");
	v.push_back("011");
	v.push_back("100");
	v.push_back("001");
	v.push_back("10");
	string a = x.isOne(v);
	cout << a << endl;
	return 0;
}

