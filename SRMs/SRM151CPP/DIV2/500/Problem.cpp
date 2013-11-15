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

class Birthday {
public:
	string getNext(string date, vector <string> birthdays) {
		string result = "";
		int m = atoi(date.substr(0,2).c_str());
		int d = atoi(date.substr(3, 2).c_str());
		int r = ((m - 1) * 31) + d;
		int min = 100000000;
		for(int i = 0; i < birthdays.size(); i++)
		{
		    string month = birthdays[i].substr(0,2);
		    string day = birthdays[i].substr(3, 2);
			int mm = atoi(month.c_str());
			int dd = atoi(day.c_str());
			int rr = ((mm - 1) * 31) + dd;
			if (rr < r) { rr += 372; }
			if(rr - r < min) {
				result = month + "/" + day;
				min = rr - r;
			}
		}
		return result;
	}
};

int main()
{
	Birthday b;
	vector<string> v;
	v.push_back("12/31 aa");
	v.push_back("01/01 aa");
	string res = b.getNext("12/30", v);
	cout << res << endl;
	return 0;
}

