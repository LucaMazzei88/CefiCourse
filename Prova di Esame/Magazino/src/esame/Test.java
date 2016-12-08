package esame;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Magazino mag=new Magazino();
		String[] ris=mag.entrataUscita();
		System.out.println(ris[0]+";"+ris[1]+";"+ris[2]);
		mag.riepilogo();
	}
}
