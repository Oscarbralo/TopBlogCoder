// TCTemplate.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int cases;
	cin >> cases;
	int v[] = {2048, 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1};
	for(int i = 0; i < cases; i++)
	{
		int result = 0;
		int n;
		cin >> n;
		for(int a = 0; a < 12; a++)
		{
			while(n - v[a] >= 0)
			{
				n -= v[a];
				result++;
			}
		}
		cout << result << endl;
	}
	return 0;
}

