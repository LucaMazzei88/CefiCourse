package controller;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String path="vespa.txt";
		try {
			Controller.statistica(path);
		} catch (Exception e) {
		e.printStackTrace();
		}
	}

}
