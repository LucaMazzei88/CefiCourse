#include <iostream>
#include <string.h>
#define DIM 7
using namespace std;
int contaPalindrome(char mat[][DIM], int rig);
int main()
{
    char mat[][DIM]={{'p','i','p','p','o'},{'a','r','b','r','a'}};
    cout<<"Parole palindrome "<<contaPalindrome(mat,2)<<endl;
    return 0;
}
int contaPalindrome(char mat[][DIM], int righe){
    int conta=0;
    int lung;
    bool flag=true;
    for(int i=0;i<righe;i++){
        flag=true;
        for(int j=0;j<(lung=strlen(mat[i]))/2;j++){
            if(mat[i][j]!=mat[i][lung-1-j]){
                flag=false;
            }
        }
        if(flag)
            conta++;
    }
    return conta;
}
