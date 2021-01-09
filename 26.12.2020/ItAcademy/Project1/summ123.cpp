#include <iostream>
using namespace std;

int main (){
cout << "Please, input number" << endl;
int mmm;
int x;
int y;
int z;
cin >> mmm;
x = mmm / 100;
y = (mmm%100) / 10;
z = (mmm%100)%10;
int sum = x + y +z;
cout << "Summa chisel coctavljaet\n"<<sum;

}