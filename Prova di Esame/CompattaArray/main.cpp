#include <iostream>
#include <stdlib.h>
using namespace std;
void compatta(int* a, int* b, int dim);
int main()
{
    int* a=new int[10]{1,5,8,8,9,0,4,8,3,2};
    int* b=new int[10];
    compatta(a,b,10);
    for(int i=0;i<7;i++){
        cout<<*(b+i)<<endl;
    }
    return 0;
}
void compatta(int* a, int* b, int dim){
    int indiceA, indiceB;
    bool flag;
    for(indiceA=0, indiceB=0; indiceA<dim;indiceA++){
        flag=true;
        if(*(a+indiceA)!=0){
            for(int i=0;i<indiceB;i++){
                if(*(a+indiceA)==*(b+i)){
                    flag=false;
                    break;
                }
            }
            if(flag){
                *(b+(indiceB))=*(a+indiceA);
                indiceB++;
              //  b=(int*)realloc(b,(indiceB+1)*sizeof(int));
               // cout<<indiceB<<endl;
            }
        }
    }
   // cout<<endl;
   // b=(int*)realloc(b,indiceB*sizeof(int));
}
