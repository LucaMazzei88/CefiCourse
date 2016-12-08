package sottomatrici;

import java.util.ArrayList;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Matrici matrix=new Matrici(new int[][]{{2,1,4},{7,4,5},{8,5,3}});
		ArrayList<Object> sottomatrici=matrix.sottoMatrici(2, 2);
		for (Object ele : sottomatrici) {
			int[][] temp=(int[][])ele;
			System.out.println("sottomatrice:");
			stampaMatrice(temp);
		}
		System.out.println("Sottomatrice con media più alta= "+matrix.calcola(sottomatrici));
//		stampaMatrice(matrix.copiaSottomatrice(matrix.getMat(), 1, 0, 2, 2));
	}
	public static void stampaMatrice(int[][] mat){
		for (int[] ele : mat) {
			for (int ele1 : ele) {
				System.out.print(ele1+" ");
			}
			System.out.println();
		}
	}
}
