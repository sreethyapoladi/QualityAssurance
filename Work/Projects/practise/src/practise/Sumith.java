package practise;

public class Sumith {

	   public void eat()
	   {
	      System.out.println("Human is eating");
	   }
	}
	class Human extends Sumith{
	   private static Human obj;
	public void eat(){
	      System.out.println("Sumith is eating");
	   }
	   public static void main( String args[]) {
	      Human. obj = new Human();
	      obj.eat();
	   }
	   }