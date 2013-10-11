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

class Justifier {
public:
	vector <string> justify(vector <string> textIn) {
		int maxLength = 0;
		for(int i = 0; i < textIn.size();i++)
		{
			if(textIn[i].length() > maxLength)
				maxLength = textIn[i].length();
		}
		for(int a = 0; a < textIn.size();a++)
		{
			for(int b = 0; b < (maxLength - textIn[a].length()); b++)
				textIn[a].insert(0, " ");
		}
		return textIn;
	}
};

int main()
{
	vector<string> vec;
	vec.push_back("TOM");
	vec.push_back("TOMMY");
	vec.push_back("JIM");
	Justifier x;
	vector<string> result = x.justify(vec);
	return 0;
}

