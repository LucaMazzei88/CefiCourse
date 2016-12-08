package esame;

public class Matrice {

	private String[][] mat;

	public Matrice(String[][] mat) {
		super();
		this.mat = mat;
	}
	public int[][] calcola(char a){
		int[][] mat1=new int[mat.length][mat[0].length];
		String temp;
		String[] arr;
		int conta;
		for(int i=0;i<mat.length;i++){
			for(int j=0;j<mat[i].length;j++){
				temp=mat[i][j];
				arr=temp.split("\\p{Space}");
				conta=0;
				for(String ele:arr){
					if(ele.contains(a+""+a))
						conta++;
				}
				mat1[i][j]=conta;
			}
		}
		return mat1;
	}
	public int[][] calcola1(char a){
		int[][] mat1=new int[mat.length][mat[0].length];
		String temp;
		int pos, conta;
		for(int i=0;i<mat.length;i++){
			for(int j=0;j<mat[i].length;j++){
				temp=mat[i][j];
				pos=-1;
				conta=0;
				while((pos=temp.indexOf(a, pos+1))!=-1){
						conta++;
				}
				mat1[i][j]=conta;
			}
		}
		return mat1;
	}
	
}
