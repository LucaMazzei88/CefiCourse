package dasd;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Articolo art=new Articolo("testo.txt","ciao");
		System.out.println("conta="+Articolo.conta(5));
		System.out.println("palindrome"+Articolo.palindrome());
		double[] medie=Articolo.media();
		for (double d : medie) {
			System.out.println("Medie:"+d);
		}
	}

}
