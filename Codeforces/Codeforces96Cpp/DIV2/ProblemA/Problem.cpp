// TCTemplate.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <sstream>
#include <iostream>

using namespace std;

int main()
{
	string s;
	cin >> s;
	int countZeros = 0;
	int countOnes = 0;
	if (s[0] == '0')
		countZeros++;
	else
		countOnes++;
	bool finish = false;
	for(int i = 1; i < s.length(); i++)
	{
		if(s[i] == '0' && countZeros > 0)
			countZeros++;
		else if(s[i] == '0' && countZeros == 0)
		{
			countZeros++;
			countOnes = 0;
		}
		if(s[i] == '1' && countOnes > 0)
			countOnes++;
		else if(s[i] == '1' && countOnes == 0)
		{
			countOnes++;
			countZeros = 0;
		}
		if(countOnes == 7 || countZeros == 7)
		{
			finish = true;
			break;
		}
	}
	if(finish)
		cout << "YES" << endl;
	else
		cout << "NO" << endl;
	return 0;
}
