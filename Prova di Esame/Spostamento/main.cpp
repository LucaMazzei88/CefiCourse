#include <iostream>

using namespace std;
void shiftSinistra(int a[],int n);
void shiftDestra(int a[],int n);
void stampaArray(int a[], int n);
int main()
{
    int a[]{10,18,12,6};
    int n=sizeof(a)/sizeof(int);
    shiftDestra(a,n);
    shiftSinistra(a,n);
    return 0;
}
void shiftSinistra(int a[],int n){
    for(int i=1;i<n;i++){
        a[i-1]=a[i];
    }
    a[n-1]=0;
    stampaArray(a,n);
}
void shiftDestra(int a[],int n){
    for(int i=n-2;i>=0;i--){
        a[i+1]=a[i];
    }
    a[0]=0;
    stampaArray(a,n);
}
void stampaArray(int a[], int n){
    for(int i=0;i<n;i++){
        cout<<a[i]<<" ";
    }
    cout<<endl;
}
