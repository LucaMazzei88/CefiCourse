#include <iostream>
#include <string>
#include <vector>
#include <stdlib.h>
using namespace std;
struct Studente{
    double media;
    string codMatricola;
};
int main()
{
    string mat[][4]={{"A001","29","25","28"},{"A002","18","19","21"},{"A003","24","30","28"},{"A004","24","23","27"}};
    vector<Studente>* mediaSuf=new vector<Studente>();
    vector<Studente>* mediaInsuf=new vector<Studente>();
    double temp;
    Studente temp1;
    for(int i=0;i<sizeof(mat)/(sizeof(string)*4);i++)
    {
        temp=0;
        for(int j=1;j<4;j++){
            temp+=atof(mat[i][j].c_str());
        }
        temp/=3;
        temp1.media=temp;
        temp1.codMatricola=mat[i][0];
        if(temp>=25){
            mediaSuf->push_back(temp1);
        }
        else
            mediaInsuf->push_back(temp1);
    }
    vector<Studente>::iterator it;
    cout<<"Studenti sufficenti"<<endl;
    for(it=mediaSuf->begin();it<mediaSuf->end();it++){
        temp1=*it;
        cout<<"Matricola "<<temp1.codMatricola<<" Media voti: "<<temp1.media<<endl;
    }
    cout<<"Studenti insufficenti"<<endl;
    for(it=mediaInsuf->begin();it<mediaInsuf->end();it++){
        temp1=*it;
        cout<<"Matricola "<<temp1.codMatricola<<" Media voti: "<<temp1.media<<endl;
    }
    return 0;
}
