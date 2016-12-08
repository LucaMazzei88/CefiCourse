package asads;

public class Funzioni {

	public static boolean sottoliste(int a[], int x){
		int temp;
		for(int ele:a){
			if(ele>x)
			{
				return false;
				
			}
		}
		for(int i=0;i<a.length;i++){
			temp=a[i];
			for(int j=i+1;j<a.length && temp<=x;j++){
				temp+=a[j];
				if(temp<=x){
					System.out.print("(");
					for(int k=i;k<=j;k++){
						System.out.print(a[k]+" ");
					}
					System.out.println(")");
				}
			}
		}
		return true;
	}
	public static boolean quaMa(int mat[][]){
		int valore=0;
		int temp;
		for(int i=0;i<mat[0].length;i++){
			valore+=mat[i][0];
		}
		for(int i=0;i<mat.length;i++){
			temp=0;
			for(int j=0;j<mat[i].length;j++){
				temp+=mat[i][j];
			}
			if(temp!=valore)
				return false;
		}
		for(int i=0;i<mat.length;i++){
			temp=0;
			for(int j=0;j<mat[i].length;j++){
				temp+=mat[j][i];
			}
			if(temp!=valore){
				return false;
			}
		}
		temp=0;
		for(int i=0;i<mat.length;i++){
			temp+=mat[i][i];
		}
		if(temp!=valore){
			return false;
		}
		temp=0;
		for(int i=0;i<mat.length;i++){
			temp+=mat[i][mat.length-i-1];
		}
		if(temp!=valore){
			return false;
		}
		return true;
	}
}
