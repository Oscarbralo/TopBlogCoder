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

class SuperRot {
public:
	string decoder(string message) {
		string abc = "abcdefghijklmABCDEFGHIJKLM";
		string ABC = "nopqrstuvwxyzNOPQRSTUVWXYZ";
		string num = "01234";
		string NUM = "56789";
		string result = "";
		for(int i = 0; i < message.length(); i++)
		{
			stringstream ss;
			ss << message[i];
			if(abc.find(ss.str()) != -1)
				result += ABC[abc.find(ss.str())];
			else if(ABC.find(ss.str()) != -1)
				result += abc[ABC.find(ss.str())];
			else if(num.find(ss.str()) != -1)
				result += NUM[num.find(ss.str())];
			else if(NUM.find(ss.str()) != -1)
				result += num[NUM.find(ss.str())];
			else
				result += message[i];
		}
		return result;
	}
};

int main()
{
	SuperRot s;
	string res = s.decoder("Uryyb 28");
	cout << res << endl;
	return 0;
}

