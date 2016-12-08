package esame;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Matrice mat=new Matrice(new String[][]{{"ppaa aap","az aap"}, {"assa aap","az ap"}});
		int matrice[][]=mat.calcola('a');
		stampa(matrice);
		stampa(mat.calcola1('a'));
		
	}
	public static void stampa(int[][] mat){
		for(int ele[]: mat){
			for(int ele1:ele){
				System.out.print(ele1+" ");
			}
			System.out.println();
		}
	}
}
