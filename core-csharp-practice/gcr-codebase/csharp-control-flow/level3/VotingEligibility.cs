using System ;
class VotingEligibility {
	static void Main(String[] args){
		int age = int.Parse(Console.ReadLine());
		if(age>18){
			Console.WriteLine("Eligible");
		}
		else{
			Console.WriteLine("Not Eligible");
		}
	}
}