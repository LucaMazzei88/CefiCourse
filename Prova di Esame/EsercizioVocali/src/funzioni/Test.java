package funzioni;

import java.util.ArrayList;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		ArrayList<String> parole=Funzioni.maxParolaVocali("Diego va sempre al bagno la mattin");
		for(String ele:parole){
			System.out.println(ele);
		}
		System.out.println(Funzioni.prefSuffString("pippo marpo giovanni potere", "po"));
	}

}
