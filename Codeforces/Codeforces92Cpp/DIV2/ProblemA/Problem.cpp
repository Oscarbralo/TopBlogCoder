// TCTemplate.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int n = 0;
	int chips = 0;
	cin >> n >> chips;
	int i = 1;
	while(chips - i >= 0)
	{
		chips -= i;
		if(i == n)
			i = 0;
		i++;
	}
	cout << chips << endl;
	return 0;
}

