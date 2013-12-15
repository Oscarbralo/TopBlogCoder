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

int FirstFactorial(int num) { 
  if(num == 1)
    return num;
  num *= FirstFactorial(num - 1);
  return num; 
            
}

int main() { 
  string s;
  cin >> s;
  cout << FirstFactorial(s);
  return 0;
    
} 

