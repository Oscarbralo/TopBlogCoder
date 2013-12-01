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

class Sets {
public:
	vector <int> operate(vector <int> A, vector <int> B, string operation) {
		vector<int> result;
		if(operation == "UNION")
		{
			for (int i = 0; i < A.size(); i++)
				if(find(result.begin(), result.end(), A[i]) == result.end())
					result.push_back(A[i]);
			for (int i = 0; i < B.size(); i++)
				if(find(result.begin(), result.end(), B[i]) == result.end())
					result.push_back(B[i]);
		}
		else if(operation == "INTERSECTION")
		{
			for (int i = 0; i < A.size(); i++)
				if(find(B.begin(), B.end(), A[i]) != B.end())
					if(find(result.begin(), result.end(), A[i]) == result.end())
						result.push_back(A[i]);
			for (int i = 0; i < B.size(); i++)
				if(find(A.begin(), A.end(), B[i]) != A.end())
					if(find(result.begin(), result.end(), B[i]) == result.end())
						result.push_back(B[i]);
		}
		else
		{
			for (int i = 0; i < A.size(); i++)
				if(find(B.begin(), B.end(), A[i]) == B.end())
					if(find(result.begin(), result.end(), A[i]) == result.end())
						result.push_back(A[i]);
			for (int i = 0; i < B.size(); i++)
				if(find(A.begin(), A.end(), B[i]) == A.end())
					if(find(result.begin(), result.end(), B[i]) == result.end())
						result.push_back(B[i]);
		}
		sort(result.begin(), result.end());
		return result;
	}
};

int main()
{
	Sets s;
	vector<int> A;
	vector<int> B;
	vector<int> result;
	A.push_back(1);
	A.push_back(2);
	A.push_back(3);
	A.push_back(4);
	B.push_back(3);
	B.push_back(4);
	B.push_back(5);
	B.push_back(6);
	result = s.operate(A, B, "INTERSECTION");
	return 0;
}

