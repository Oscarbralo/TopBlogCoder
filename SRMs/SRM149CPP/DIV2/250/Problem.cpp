// TopCoderCppTemplate.cpp : Defines the entry point for the console application.
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

class FormatAmt {
public:
	string amount(int dollars, int cents) {
		stringstream string1;
		string1 << dollars;
		string dol = string1.str();
		int max = dol.length();
		stringstream string2;
		string2 << cents;
		string cen = string2.str();
		string res = "$";
		if(dollars < 1)
			res.append("0.");
		else
		{
			int index = dol.length() % 3;
			(index == 0) ? index += 3 : index;
			int count = 0;
			while(index <= dol.length() - 3 && dol.length() > 3 && index < max)
			{
				dol.insert(index + count, ",");
				index += 3;
				count++;
			}
			res.append(dol + ".");
		}
		if(cents < 10)
				res.append("0" + cen);
			else
				res.append(cen);
		return res;
	}
};

int main()
{
	FormatAmt x;
	string result = x.amount(2000000000, 99);
	cout << result << endl;
	return 0;
}

