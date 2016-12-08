#include <iostream>
#include <string>
#include <stdlib.h>

using namespace std;

int main()
{

    string numeri="1346345";
    int temp;
    string stamp;
    char carattere;
    for(int i=0;i<numeri.length()-2;i++){
        temp=0;
        stamp="";
        for(int j=i;j<3+i;j++){
            carattere=numeri[j];
            temp+=atoi(&carattere);
            stamp+=numeri[j];
        }
        stamp+="=";
        cout<<stamp<<temp<<endl;
    }
    return 0;
}
