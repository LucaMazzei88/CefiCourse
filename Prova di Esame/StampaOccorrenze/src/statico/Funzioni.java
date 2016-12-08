package statico;

public class Funzioni {

	public static String occorrenze(int[] a){
		int occ;
		String ret="";
		for(int i=0;i<a.length;i++){
			occ=0;
			for(int j=i+1;j<a.length;j++){
				if(a[i]==a[j]){
					occ=j;
					break;
				}
			}
			if(occ!=0){
				ret+=occ;
			}else{
				ret+=-1;
			}
		}
		return ret;
	}
	public static String maxAdiacenti(int[][] mat){
		String temp="";
		double medie=0,temp1;
		for(int i=0;i<mat.length;i++){
			for(int j=0;j<mat[i].length;j++){
				temp1=medieAdiacenti(mat, i, j);

				if(temp1>medie){
					temp="("+i+","+j+","+mat[i][j]+")";
					medie=temp1;
				}
				else if(temp1==medie){
					temp+="("+i+","+j+","+mat[i][j]+")";
				}
			}
		}
		return temp;
	}
	private static double medieAdiacenti(int[][] mat, int i, int j){
		int somme=0;
		int colonne=mat.length;
		int righe=mat[i].length;
		somme+=mat[(i+1==colonne)?0:i+1][j];
		somme+=mat[(i-1<0)?colonne-1:i-1][j];
		somme+=mat[i][(j+1==righe)?0:j+1];
		somme+=mat[i][(j-1<0)?righe-1:j-1];
		return (double)somme/4;
	}
}
