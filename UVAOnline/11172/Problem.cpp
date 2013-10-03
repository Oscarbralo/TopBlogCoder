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
	int cases;
	cin >> cases;
	for(int i = 0; i < cases; i++)
	{
		int a;
		int b;
		cin >> a >> b;
		if(a > b)
			cout << ">" << endl;
		else if(a < b)
			cout << "<" << endl;
		else
			cout << "=" << endl;
	}
	return 0;
}

