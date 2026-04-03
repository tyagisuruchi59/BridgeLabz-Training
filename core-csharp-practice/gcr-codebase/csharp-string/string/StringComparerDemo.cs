using System;

class StringComparerDemo
{
 static void Main()
 {
	 string s1=Console.ReadLine();
	 string s2=Console.ReadLine();
	 bool result = StringCompare(s1, s2);
	   Console.WriteLine(result);
 }
 static bool StringCompare (string s1, string s2){
	 if(s1.Length!=s2.Length){
		 return false;
	 }
 for(int i=0;i<s1.Length;i++){
	 if(s1[i]!=s2[i]){
		 return false;
	 }
 }
 return true;
 }
}
