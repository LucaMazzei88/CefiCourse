#include <iostream>
#include <math.h>
#include <stdlib.h>
using namespace std;
void sommaBinaria(char a[], char b[], int dim);
int convertiB2D(char a[], int dim);
char* convertiD2B(int a, int dim);
int main()
{
    char a[5]{'1','1','0','0',0};
    char b[5]{'1','1','0','1',0};
    sommaBinaria(a,b,4);
    return 0;
}
void sommaBinaria(char a[], char b[], int dim){
    int limite=pow(2,(double)dim)-1;
    int num1=convertiB2D(a,dim);
    int num2=convertiB2D(b,dim);
    char c[dim];
    if(num1+num2>limite)
        cout<<"OverFlow"<<endl;
    else
        cout<<"Somma="<<itoa(num1+num2,c,2);

}
int convertiB2D(char a[], int dim){
    char temp;
    double somma=0;
    for(int i=0; i<dim;i++){
        temp=a[i];
        somma+=atoi(&temp)*pow(2,(double)(dim-1-i));
    }
    return somma;
}
