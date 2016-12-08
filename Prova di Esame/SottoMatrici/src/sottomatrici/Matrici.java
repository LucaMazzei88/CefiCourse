package sottomatrici;

import java.util.ArrayList;
import java.util.Arrays;

public class Matrici {
	private int[][] mat;

	public Matrici(int[][] mat) {
		this.mat = mat;
	}
	
	public ArrayList<Object> sottoMatrici(int n, int m){
		ArrayList<Object> lista=new ArrayList<>();		
		for(int i=0;i<=mat.length-n;i++){
			for(int j=0;j<=mat[i].length-m;j++){
				lista.add(copiaSottomatrice(mat, i, j, n, m));
			}
		}
		return lista;
	}
	public int[][] getMat() {
		return mat;
	}

	public int[][] copiaSottomatrice(int[][] matPartenza,int i,int j, int dim1, int dim2){
		int[][] temp=new int[dim1][dim2];
		for(int k=0;k<dim1;k++){
			temp[k]=Arrays.copyOfRange(matPartenza[i+k], j, j+dim2);
		}
		return temp;
	}
	public double calcola(ArrayList<Object> sottomatrici){
		double media=0;
		double mediaTemp;
		double somma=0;
		int contaRighe;
		int contaColonne;
		for (Object ele : sottomatrici) {
			contaRighe=0;
			contaColonne=0;
			int[][] temp=(int[][]) ele;
			for (int[] is : temp) {
				contaRighe++;
				for (int i : is) {
					somma+=i;
					contaColonne++;
				}
			}
			if(media<(mediaTemp=(somma/(contaRighe*contaColonne)))){
				media=mediaTemp;
			}
		}
		return media;
	}
}
