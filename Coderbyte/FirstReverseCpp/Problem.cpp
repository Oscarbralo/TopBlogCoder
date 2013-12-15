#include "stdafx.h"
#include <iostream>
#include <sstream>
#include <algorithm>
using namespace std;

string FirstReverse(string str) {
  reverse(str.begin(), str.end());
  // code goes here   
  return str; 
            
}

int main() { 
  string s;
  cin >> s;
  // keep this function call here
  cout << FirstReverse(s);
  return 0;
    
}  
